using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Cinteros.XTB.PluginTraceViewer
{
    public class Link
    {
        public Guid Id;
        public string Entity;
        public Record Record;
        public string LogIdentifier;
        public string TypeIdentifier;
        public int GuidPosition = -1;
        public int GuidLength = 0;
        public int EntityRelativePosition = 0;
        public int InsertPosition = -1;
        public bool IsInserted;

        private Link()
        { }

        internal static bool TryParse(Match m, out Link link)
        {
            if (Guid.TryParse(m.Value, out var guid))
            {
                link = new Link();
                link.GuidLength = m.Length;
                link.GuidPosition = m.Index;
                //        link.LinkPosition = link.GuidPosition + link.GuidLength;
                link.Id = guid;
                //        link.EntityFoundAfterGuid = true;
                return true;
            }
            link = null;
            return false;
        }

        internal void IdentifyRecord(RecordList recordlist, string guidrelated, string triggerentity)
        {
            LogIdentifier = guidrelated;
            switch (guidrelated.ToLowerInvariant())
            {
                case "target":
                case "record":
                case "id":
                case "primaryentityid":
                    TypeIdentifier = "Target";
                    Entity = triggerentity;
                    break;

                case "user":
                case "userid":
                case "principal":
                    TypeIdentifier = "UserId";
                    Entity = "systemuser";
                    break;

                case "inituserid":
                case "inituserappid":
                case "initiating user":
                case "initiatinguserid":
                    TypeIdentifier = "InitUserId";
                    Entity = "systemuser";
                    break;

                case "userazureadid":
                    Entity = "systemuser";
                    break;

                case "businessunitid":
                case "objectbusinessunitid":
                    Entity = "businessunit";
                    break;

                case "environment":
                case "environmentid":
                case "organization":
                    Entity = null;
                    TypeIdentifier = "EnvironmentId";
                    Record = new Record
                    {
                        Id = Id,
                        Name = "Environment",
                        Url = $"https://admin.powerplatform.microsoft.com/environments/environment/{Id}/hub"
                    };
                    return;

                default:
                    Entity = guidrelated;
                    if (Entity.ToLowerInvariant().StartsWith("object") && Entity.ToLowerInvariant().EndsWith("id"))
                    {
                        Entity = Entity.Substring(6, Entity.Length - 8);
                    }
                    if (Entity.ToLowerInvariant().EndsWith("id"))
                    {
                        Entity = Entity.Substring(0, Entity.Length - 2);
                    }
                    break;
            }
            Record = recordlist.Get(Entity, Id);
        }

        public string LinkName => Record?.Name;

        public override string ToString() => $"{LogIdentifier} {Id} {LinkName}";
    }

    public class Links : List<Link>
    {
        private const string guidregex = @"([a-z0-9]{8}[-][a-z0-9]{4}[-][a-z0-9]{4}[-][a-z0-9]{4}[-][a-z0-9]{12})";
        private static char[] spacechars = { ' ', '\t', '\n', '\r', ':', '.', ',', '=', '"', '\'', '(', ')' };
        private static char[] separators = { ';', ':', '(', ')', '[', ']', '{', '}', '<', '>', '/', '|', '^', '"', '\'', '\\', '/', '`' };
        private static string[] wordsbetweenstableandguid = { "new Guid", ", Id", "with id", "of entity" };
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
                    link.IsInserted = true;
                }
            }
            return log;
        }

        internal Link Target => this.FirstOrDefault(l => l.TypeIdentifier == "Target") ?? this.FirstOrDefault(l => l.Record?.EntityName == triggerentity);

        internal List<Record> LinkRecords => this
            .Where(l => l.Record != null)
            .Where(l => l.Id != Target?.Id)
            .Select(l => l.Record)
            .Distinct()
            .ToList();

        internal void MatchGuids(bool lookuprecords)
        {
            foreach (Match m in Regex.Matches(log, guidregex))
            {
                //if (currectentity != tracerecord)
                //{   // This will cancel if UI is now on another trace line since this is async
                //    return;
                //}
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
                            if (beforeguid.EndsWith(word))
                            {
                                beforeguid = beforeguid.Substring(0, beforeguid.Length - word.Length).TrimEnd(spacechars);
                            }
                        }
                        if (beforeguid.ToLowerInvariant().EndsWith("id"))
                        {
                            if (beforeguid.Length > 2 && !char.IsLetterOrDigit(beforeguid[beforeguid.Length - 3]))
                            {
                                beforeguid = beforeguid.Substring(0, beforeguid.Length - 2).TrimEnd(spacechars);
                            }
                        }
                        if (FindGuidTable(beforeguid, false) is string guidname1)
                        {
                            link.EntityRelativePosition = beforeguidorg.LastIndexOf(guidname1) - m.Index;
                            link.IdentifyRecord(records, guidname1, triggerentity);
                        }
                    }
                    if (link.Record == null)
                    {
                        var afterguid = afterguidorg.TrimStart(spacechars);
                        if (!string.IsNullOrWhiteSpace(afterguid))
                        {
                            foreach (var word in wordsbetweenstableandguid)
                            {
                                if (afterguid.StartsWith(word))
                                {
                                    afterguid = afterguid.Substring(word.Length).Trim(spacechars);
                                }
                            }
                            if (afterguid.Split(spacechars).First().ToLowerInvariant().EndsWith("id"))
                            {
                                if (afterguid.Length > 2 && !char.IsLetterOrDigit(afterguid[afterguid.Length - 3]))
                                {
                                    afterguid = afterguid.Substring(0, afterguid.Length - 2).Trim(spacechars);
                                }
                            }
                            if (FindGuidTable(afterguid, true) is string guidname2)
                            {
                                link.EntityRelativePosition = m.Index + afterguidorg.IndexOf(guidname2);
                                link.IdentifyRecord(records, guidname2, triggerentity);
                            }
                        }
                    }
                }
            }
        }

        internal void HighlightRecords(RichTextBox richText)
        {
            foreach (var link in this)
            {
                // Yellow on the guid
                richText.Select(link.GuidPosition, link.GuidLength);
                richText.SelectionBackColor = System.Drawing.Color.Yellow;
                if (link.EntityRelativePosition != 0)
                {
                    // Gray on the table identifier
                    richText.Select(link.GuidPosition + link.EntityRelativePosition, link.LogIdentifier.Length);
                    richText.SelectionBackColor = System.Drawing.Color.LightGray;
                }
                if (link.IsInserted)
                {
                    // Green on the name of the record
                    richText.Select(link.InsertPosition, link.LinkName.Length);
                    richText.SelectionBackColor = System.Drawing.Color.LightGreen;
                }
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
                else if (closestlog.ToLowerInvariant().EndsWith("corrolation id"))
                {   // MS traces...
                    tablename = "Corrolation Id";
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
                if (closestlog.ToLowerInvariant().StartsWith("initiating user"))
                {   // MS traces...
                    tablename = "Initiating User";
                }
                else if (closestlog.ToLowerInvariant().StartsWith("corrolation id"))
                {   // MS traces...
                    tablename = "Corrolation Id";
                }
                else if (closestlog.ToLowerInvariant().StartsWith("principal with id"))
                {
                    tablename = "Principal";
                }
                else if (closestlog.IndexOfAny(spacechars) is int pos && pos >= 0)
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
}