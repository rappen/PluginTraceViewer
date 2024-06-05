using System;
using System.Collections.Generic;
using System.Linq;

namespace Cinteros.XTB.PluginTraceViewer
{
    public class Link
    {
        public Record Record;
        public Guid Id;
        public string LogIdentifier;
        public string TypeIdentifier;
        public int GuidPosition;
        public int GuidLength;
        public int LinkPosition;
        public string LinkName;
        public bool IsAdded;

        internal static Link GetRecordLink(bool lookuprecord, RecordList recordlist, string entity, string guidname, string id)
        {
            if (!Guid.TryParse(id, out var guid))
            {
                return null;
            }
            var link = new Link
            {
                LogIdentifier = guidname,
                Id = guid
            };
            string table;
            switch (guidname.ToLowerInvariant())
            {
                case "user":
                case "userid":
                    link.TypeIdentifier = "UserId";
                    table = "systemuser";
                    break;

                case "inituserid":
                case "inituserappid":
                case "initiating user":
                case "initiatinguserid":
                    link.TypeIdentifier = "InitUserId";
                    table = "systemuser";
                    break;

                case "userazureadid":
                    table = "systemuser";
                    break;

                case "businessunitid":
                    table = "businessunit";
                    break;

                case "target":
                case "record":
                case "id":
                case "primaryentityid":
                    link.TypeIdentifier = "Target";
                    table = entity;
                    break;

                case "environment":
                case "environmentid":
                case "organization":
                    table = null;
                    link.TypeIdentifier = "EnvironmentId";
                    link.Record = new Record
                    {
                        Id = guid,
                        Name = "Environment",
                        Url = $"https://admin.powerplatform.microsoft.com/environments/environment/{guid}/hub"
                    };
                    return link;

                default:
                    table = guidname;
                    break;
            }
            if (lookuprecord && recordlist.Get(table, guid) is Record record)
            {
                link.Record = record;
            }
            //else
            //{
            //    link.Record = new Record
            //    {
            //        EntityName = table,
            //        Id = guid,
            //        Name = $"Unfound table {table}"
            //    };
            //}
            return link;
        }

        public override string ToString() => $"{LogIdentifier} {Id} {LinkName}";
    }

    public class Links : List<Link>
    {
        private static char[] separators = { ';', ':', '(', ')', '[', ']', '{', '}', '<', '>', '/', '|', '^', '"', '\'', '\\', '/', '`' };

        internal static string InsertRecordsInLog(string log, List<Link> links)
        {
            var extratextlength = 0;
            foreach (var link in links)
            {
                link.LinkName = $" {link.Record?.Name}";
                link.GuidPosition += extratextlength;
                link.LinkPosition += extratextlength;
                var length = Math.Max(log.Length - link.LinkPosition - 1, 0);
                if (length >= 0 && !string.IsNullOrWhiteSpace(link.Record?.Name))
                {
                    if (!log.Substring(link.LinkPosition, length).Trim().StartsWith(link.Record?.Name))
                    {
                        while (link.LinkPosition < log.Length && separators.Contains(log[link.LinkPosition]))
                        {
                            link.LinkPosition++;
                        }
                        log = log.Insert(link.LinkPosition, link.LinkName);
                        extratextlength += link.LinkName.Length;
                    }
                    link.IsAdded = true;
                }
            }
            return log;
        }

        internal Link Target => this.FirstOrDefault(l => l.TypeIdentifier == "Target");

        internal List<Record> LinkRecords => this
            .Where(l => l.Record != null)
            .Where(l => l.Id != Target?.Id)
            .Select(l => l.Record)
            .Distinct()
            .ToList();
    }
}