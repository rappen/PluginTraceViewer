using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;
using Rappen.XRM.Helpers.Extensions;
using Rappen.XTB.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace Cinteros.XTB.PluginTraceViewer
{
    public class Record
    {
        public string EntityName;
        public Guid Id;
        public string Name;
        public string Url;
        public Entity Entity;
        public EntityMetadata Metadata;

        public Record()
        { }

        public Record(string entityName, Guid id, string name, string url, Entity entity)
        {
            EntityName = entityName;
            Id = id;
            Name = name;
            Url = url;
            Entity = entity;
        }

        public override string ToString() => $"{EntityName}/{Name}/{Id}";
    }

    public class RecordList
    {
        public List<Record> Records { get; private set; }
        private List<string> thrashlist;
        private ConnectionDetail conndet;
        private IOrganizationService service;

        public RecordList(ConnectionDetail conndet, IOrganizationService service)
        {
            Records = new List<Record>();
            thrashlist = new List<string>();
            this.conndet = conndet;
            this.service = service;
        }

        public Record Get(EntityMetadata entity, Guid guid)
        {
            if (entity == null || guid.Equals(Guid.Empty))
            {
                return null;
            }
            if (Records.FirstOrDefault(r => r.EntityName == entity.LogicalName && r.Id.Equals(guid)) is Record record)
            {
                return record;
            }
            return Add(entity, guid);
        }

        public EntityMetadata GetEntityMetadata(string entity)
        {
            if (string.IsNullOrWhiteSpace(entity) ||
                thrashlist.Contains($"EntityName:{entity}"))
            {
                return null;
            }
            return service.GetEntity(entity);
        }

        private Record Add(EntityMetadata entity, Guid id)
        {
            if (entity == null ||
                id.Equals(Guid.Empty) ||
                thrashlist.Contains($"EntityName:{entity.LogicalName}") ||
                thrashlist.Contains($"{entity.LogicalName}:{id}"))
            {
                return null;
            }
            try
            {
                var record = new Record();
                record.Metadata = entity;
                record.EntityName = entity.LogicalName;
                record.Id = id;
                record.Entity = service.Retrieve(entity.LogicalName, id, new ColumnSet(entity.PrimaryNameAttribute));
                record.Name = record.Entity?.GetAttributeValue<string>(entity.PrimaryNameAttribute);
                record.Url = new EntityReference(entity.LogicalName, id).GetEntityUrl(conndet);
                if (record.Entity == null || string.IsNullOrWhiteSpace(record.Name))
                {
                    thrashlist.Add($"{entity.LogicalName}:{id}");
                    return null;
                }
                Records.Add(record);
                return record;
            }
            catch (FaultException<OrganizationServiceFault> ex)
            {
                if (ex.Detail.ErrorCode == -2147220969 ||
                    ex.Detail.ErrorCode == -2147219456)
                {
                    if (!thrashlist.Contains($"{entity.LogicalName}:{id}"))
                    {
                        thrashlist.Add($"{entity.LogicalName}:{id}");
                    }
                }
            }
            return null;
        }
    }
}