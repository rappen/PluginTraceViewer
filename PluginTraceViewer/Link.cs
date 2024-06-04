using System;
using System.Collections.Generic;

namespace Cinteros.XTB.PluginTraceViewer
{
    public class Link
    {
        public Record Record;
        public Guid Id;
        public string LogIdentifier;
        public string TypeIdentifier;
        public int OriginalPosition;
        public int CurrentlyPosition;
        public string AddedString;
        public int AddedLength;
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
                    link.TypeIdentifier = "InitUserId";
                    table = "systemuser";
                    break;

                case "userazureadid":
                    table = "systemuser";
                    break;

                case "target":
                case "record":
                case "id":
                    link.TypeIdentifier = "Target";
                    table = entity;
                    break;

                case "environment":
                case "environmentid":
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
            return link;
        }
    }

    public class Links : List<Link>
    {
        internal static string InsertRecordsInLog(string log, List<Link> links)
        {
            var extratextlength = 0;
            foreach (var link in links)
            {
                link.AddedString = $" {link.Record?.Name}";
                link.CurrentlyPosition = link.OriginalPosition + extratextlength;
                var length = log.Length - link.CurrentlyPosition - 1;
                if (length > 0 &&
                    !string.IsNullOrWhiteSpace(link.Record?.Name) &&
                    !log.Substring(link.CurrentlyPosition, length).Trim().StartsWith(link.Record?.Name))
                {
                    link.AddedLength = link.AddedString.Length;
                    log = log.Insert(link.CurrentlyPosition, link.AddedString);
                    extratextlength += link.AddedLength;
                    link.IsAdded = true;
                }
            }
            return log;
        }
    }
}