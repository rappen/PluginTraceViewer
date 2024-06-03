﻿using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;
using Rappen.XRM.Helpers.Extensions;
using Rappen.XTB.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public override string ToString()
        {
            return $"{EntityName}/{Metadata?.LogicalName}/{Name}/{Id}";
        }
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

        public Record Get(string entity, Guid guid)
        {
            if (string.IsNullOrWhiteSpace(entity) || guid.Equals(Guid.Empty))
            {
                return null;
            }
            if (Records.FirstOrDefault(r => r.EntityName == entity && r.Id.Equals(guid)) is Record record)
            {
                return record;
            }
            return Add(entity, guid);
        }

        private Record Add(string entityName, Guid id)
        {
            if (string.IsNullOrWhiteSpace(entityName) ||
                id.Equals(Guid.Empty) ||
                thrashlist.Contains($"{entityName}:{id}"))
            {
                return null;
            }
            if (service.GetEntity(entityName) is EntityMetadata meta)
            {
                try
                {
                    var record = new Record();
                    record.Metadata = meta;
                    record.Entity = service.Retrieve(entityName, id, new ColumnSet(meta.PrimaryNameAttribute));
                    record.Url = new EntityReference(entityName, id).GetEntityUrl(conndet);
                    record.Name = record.Entity.GetAttributeValue<string>(meta.PrimaryNameAttribute);
                    record.EntityName = entityName;
                    record.Id = id;
                    Records.Add(record);
                    return record;
                }
                catch
                {
                    if (!thrashlist.Contains($"{entityName}:{id}"))
                    {
                        thrashlist.Add($"{entityName}:{id}");
                    }
                }
            }
            return null;
        }
    }
}