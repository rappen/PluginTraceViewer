using System;
using System.Collections.Generic;

namespace Cinteros.XTB.PluginTraceViewer
{
    public class Link
    {
        public Record Record;
        public string LogIdentifier;
        public string TypeIdentifier;
        public int OriginalPosition;
        public string AddedString;
        public int AddedPosition;
        public int Length;
        public bool IsAdded;

        internal static Link GetRecordLink(RecordList recordlist, string entity, string guidname, string id)
        {
            if (!Guid.TryParse(id, out var guid))
            {
                return null;
            }
            var link = new Link();
            link.LogIdentifier = guidname;
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
            if (recordlist.Get(table, guid) is Record record)
            {
                link.Record = record;
                return link;
            }
            return null;
        }
    }

    public class Links : List<Link>
    {
        internal static string InsertRecordsInLog(string log, List<Link> links)
        {
            var extratextlength = 0;
            foreach (var link in links)
            {
                link.AddedString = $" {link.Record.Name}";
                link.AddedPosition = link.OriginalPosition + extratextlength;
                var length = log.Length - link.AddedPosition - 1;
                if (length > 0 && !log.Substring(link.AddedPosition, length).Trim().StartsWith(link.Record.Name))
                {
                    link.Length = link.AddedString.Length;
                    log = log.Insert(link.AddedPosition, link.AddedString);
                    extratextlength += link.Length;
                    link.IsAdded = true;
                }
            }
            return log;
        }
    }
}