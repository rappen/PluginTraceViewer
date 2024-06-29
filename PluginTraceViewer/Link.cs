using Microsoft.Xrm.Sdk.Metadata;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Cinteros.XTB.PluginTraceViewer
{
    public class Link
    {
        public Guid Id;
        public string EntityName;

        public EntityMetadata EntityMeta;
        public Record Record;

        public string LogIdentifier;
        public string TypeIdentifier;
        public int GuidPosition = -1;
        public int GuidLength = 0;
        public int EntityRelativePosition = 0;
        public int InsertPosition = -1;

        private Link()
        { }

        internal static bool TryParse(Match m, out Link link)
        {
            if (Guid.TryParse(m.Value, out var guid))
            {
                link = new Link();
                link.GuidLength = m.Length;
                link.GuidPosition = m.Index;
                link.Id = guid;
                return true;
            }
            link = null;
            return false;
        }

        internal bool SetEntityMeta(RecordList recordlist, string guidrelated, string triggerentity)
        {
            LogIdentifier = guidrelated;
            switch (guidrelated.ToLowerInvariant())
            {
                case "target":
                case "record":
                case "id":
                case "primaryentityid":
                    TypeIdentifier = "Target";
                    EntityName = triggerentity;
                    break;

                case "user":
                case "userid":
                case "principal":
                    TypeIdentifier = "UserId";
                    EntityName = "systemuser";
                    break;

                case "inituserid":
                case "inituserappid":
                case "initiating user":
                case "initiatinguserid":
                    TypeIdentifier = "InitUserId";
                    EntityName = "systemuser";
                    break;

                case "userazureadid":
                    EntityName = "systemuser";
                    break;

                case "businessunitid":
                case "objectbusinessunitid":
                    EntityName = "businessunit";
                    break;

                case "environment":
                case "environmentid":
                case "organization":
                    EntityName = null;
                    TypeIdentifier = "EnvironmentId";
                    Record = new Record
                    {
                        Id = Id,
                        Name = "Environment",
                        Url = $"https://admin.powerplatform.microsoft.com/environments/environment/{Id}/hub"
                    };
                    return true;

                case "step":
                    EntityName = "sdkmessageprocessingstep";
                    break;

                case "correlation id":
                    EntityName = string.Empty;
                    EntityRelativePosition = 0;
                    break;

                default:
                    EntityName = guidrelated;
                    if (EntityName.ToLowerInvariant().StartsWith("object") && EntityName.ToLowerInvariant().EndsWith("id"))
                    {
                        EntityName = EntityName.Substring(6, EntityName.Length - 8);
                    }
                    if (EntityName.ToLowerInvariant().EndsWith("id"))
                    {
                        EntityName = EntityName.Substring(0, EntityName.Length - 2);
                    }
                    break;
            }
            EntityMeta = recordlist.GetEntityMetadata(EntityName);
            if (EntityMeta == null)
            {
                LogIdentifier = string.Empty;
            }
            return EntityMeta != null;
        }

        public string LinkName => Record?.Name;

        public override string ToString() => $"{LogIdentifier} {Id} {LinkName}";
    }

    public class Links : List<Link>
    {
        private const string guidregex = @"([a-z0-9]{8}[-][a-z0-9]{4}[-][a-z0-9]{4}[-][a-z0-9]{4}[-][a-z0-9]{12})";
        private static char[] spacechars = { ' ', '\t', '\n', '\r', ':', '.', ',', '=', '"', '\'', '(', ')' };
        private static char[] separators = { ';', ':', '(', ')', '[', ']', '{', '}', '<', '>', '/', '|', '^', '"', '\'', '\\', '/', '`' };
        private static string[] wordsbetweenstableandguid = { "new guid", ", id", "with id", "of entity", "context.primaryentityid" };
        private string log;
        private RecordList records;
        private string triggerentity;

        public Links(string log, RecordList records, string triggerentity)
        {
            this.log = log;
            this.records = records;
            this.triggerentity = triggerentity;
        }

        internal string InsertRecordsInLog()
        {
            var extratextlength = 0;
            foreach (var link in this)
            {
                link.GuidPosition += extratextlength;
                if (!string.IsNullOrEmpty(link.LinkName))
                {
                    var insertpos = link.GuidPosition + link.GuidLength;
                    while (insertpos < log.Length && separators.Contains(log[insertpos]))
                    {
                        insertpos++;
                    }
                    var length = Math.Max(log.Length - insertpos - 1, 0);
                    if (!log.Substring(insertpos, length).Trim().StartsWith(link.LinkName))
                    {
                        log = log.Insert(insertpos, $" {link.LinkName}");
                        link.InsertPosition = insertpos + 1;
                        extratextlength += link.LinkName.Length + 1;
                    }
                }
            }
            return log;
        }

        internal Link Target => this.FirstOrDefault(l => l.TypeIdentifier == "Target") ?? this.FirstOrDefault(l => l.Record?.EntityName == triggerentity);

        internal List<Record> LinkRecords => this
            .Where(l => l.Record != null)
            .Select(l => l.Record)
            .Distinct()
            .ToList();

        internal void MatchGuids(bool lookuprecords)
        {
            var matches = Regex.Matches(log, guidregex);
            foreach (Match m in matches)
            {
                if (!Link.TryParse(m, out var link))
                {
                    continue;
                }
                Add(link);
                var beforeguidorg = log.Substring(0, m.Index);
                var afterguidorg = log.Substring(m.Index + m.Length);
                if (lookuprecords && !link.Id.Equals(Guid.Empty))
                {
                    var beforeguid = beforeguidorg.TrimEnd(spacechars);
                    if (!string.IsNullOrWhiteSpace(beforeguid))
                    {
                        foreach (var word in wordsbetweenstableandguid)
                        {
                            if (beforeguid.ToLowerInvariant().EndsWith(word))
                            {
                                beforeguid = beforeguid.Substring(0, beforeguid.Length - word.Length).TrimEnd(spacechars);
                                if (word.Equals("context.primaryentityid"))
                                {
                                    link.TypeIdentifier = "Target";
                                }
                            }
                        }
                        if (beforeguid.ToLowerInvariant().EndsWith("id") &&
                            beforeguid.Length > 2 &&
                            !char.IsLetterOrDigit(beforeguid[beforeguid.Length - 3]))
                        {
                            beforeguid = beforeguid.Substring(0, beforeguid.Length - 2).TrimEnd(spacechars);
                        }
                        if (FindGuidTable(beforeguid, false) is string guidname1 &&
                            link.SetEntityMeta(records, guidname1, triggerentity))
                        {
                            link.EntityRelativePosition = beforeguidorg.LastIndexOf(guidname1) - m.Index;
                        }
                    }
                    if (link.EntityMeta == null)
                    {
                        var afterguid = afterguidorg.TrimStart(spacechars);
                        if (!string.IsNullOrWhiteSpace(afterguid))
                        {
                            foreach (var word in wordsbetweenstableandguid)
                            {
                                if (afterguid.ToLowerInvariant().StartsWith(word))
                                {
                                    afterguid = afterguid.Substring(word.Length).Trim(spacechars);
                                }
                            }
                            if (afterguid.Split(spacechars).First().ToLowerInvariant().EndsWith("id") &&
                                afterguid.Length > 2 &&
                                !char.IsLetterOrDigit(afterguid[afterguid.Length - 3]))
                            {
                                afterguid = afterguid.Substring(0, afterguid.Length - 2).Trim(spacechars);
                            }
                            if (FindGuidTable(afterguid, true) is string guidname2 &&
                                link.SetEntityMeta(records, guidname2, triggerentity))
                            {
                                link.EntityRelativePosition = m.Index + afterguidorg.IndexOf(guidname2);
                            }
                        }
                    }
                    link.Record = records.Get(link.EntityMeta, link.Id);
                }
            }
        }

        internal void HighlightRecords(RichTextBox richText)
        {
            foreach (var link in this)
            {
                // Yellow on the guid
                richText.SetBackground(link.GuidPosition, link.GuidLength, Color.Yellow);
                // Gray on the table identifier
                richText.SetBackground(link.GuidPosition + link.EntityRelativePosition, link.LogIdentifier?.Length ?? 0, Color.LightGray);
                // Green on the name of the record
                richText.SetBackground(link.InsertPosition, link.LinkName?.Length ?? 0, Color.LightGreen);
            }
            richText.DeselectAll();
        }

        private static string FindGuidTable(string closestlog, bool afterguid)
        {
            var tablename = "";
            if (!afterguid)
            {
                if (closestlog.ToLowerInvariant().EndsWith("initiating user"))
                {   // MS traces...
                    tablename = "Initiating User";
                }
                else if (closestlog.ToLowerInvariant().EndsWith("correlation id"))
                {   // MS traces...
                    tablename = "Correlation Id";
                }
                else if (closestlog.ToLowerInvariant().EndsWith("principal with id"))
                {
                    tablename = "Principal";
                }
                else if (closestlog.LastIndexOfAny(spacechars) is int pos && pos >= 0)
                {
                    tablename = closestlog.Substring(pos + 1).Split('.').Last().Trim();
                }
            }
            else
            {
                if (closestlog.IndexOfAny(spacechars) is int pos && pos >= 0)
                {
                    tablename = closestlog.Split(spacechars)[0].Trim(spacechars);
                }
            }
            if (closestlog.Substring(0, closestlog.Length - tablename.Length).TrimEnd(spacechars).ToLowerInvariant().Equals("in execute"))
            {   // Low-code Plugin indication
                tablename = "Target";
            }
            return !string.IsNullOrEmpty(tablename) ? tablename : null;
        }
    }

    public static class RichTextExtension
    {
        public static void SetBackground(this RichTextBox textBox, int pos, int length, Color color)
        {
            if (textBox == null || pos < 0 || length < 1 || textBox.TextLength <= pos + length)
            {
                return;
            }
            textBox.Select(pos, length);
            textBox.SelectionBackColor = color;
            textBox.DeselectAll();
        }
    }
}