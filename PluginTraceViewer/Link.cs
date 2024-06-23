using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

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
        public int EntityRelativePosition = -1;
        public int InsertPosition = -1;
        public string LinkName;
        public bool IsInserted;

        private Link()
        { }

        public static bool TryParse(Match m, out Link link)
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

        public override string ToString() => $"{LogIdentifier} {Id} {LinkName}";
    }

    public class Links : List<Link>
    {
        private static char[] separators = { ';', ':', '(', ')', '[', ']', '{', '}', '<', '>', '/', '|', '^', '"', '\'', '\\', '/', '`' };

        private string triggerentity;

        public Links(string triggerentity)
        {
            this.triggerentity = triggerentity;
        }

        internal static string InsertRecordsInLog(string log, List<Link> links)
        {
            var extratextlength = 0;
            foreach (var link in links)
            {
                link.LinkName = $" {link.Record?.Name}";
                link.GuidPosition += extratextlength;
                var insertpos = link.GuidPosition + link.GuidLength;
                var length = Math.Max(log.Length - insertpos - 1, 0);
                if (length >= 0 && !string.IsNullOrWhiteSpace(link.Record?.Name))
                {
                    if (!log.Substring(insertpos, length).Trim().StartsWith(link.Record?.Name))
                    {
                        while (insertpos < log.Length && separators.Contains(log[insertpos]))
                        {
                            insertpos++;
                        }
                        log = log.Insert(insertpos, link.LinkName);
                        extratextlength += link.LinkName.Length;
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
    }
}