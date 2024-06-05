using Cinteros.XTB.PluginTraceViewer.Const;
using Microsoft.Xrm.Sdk;
using Rappen.XRM.Helpers.Extensions;
using Rappen.XTB.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinteros.XTB.PluginTraceViewer.Controls
{
    public partial class TraceControl : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        private const string guidregex = @"([a-z0-9]{8}[-][a-z0-9]{4}[-][a-z0-9]{4}[-][a-z0-9]{4}[-][a-z0-9]{12})";
        private char[] spacechars = new[] { ' ', '\t', '\n', '\r', ':', ',', '=', '"', '\'', '(', ')' };
        private string[] wordsbetweenstableandguid = new[] { "new Guid", ", Id", "with id" };
        private string findtext = "";
        private Entity tracerecord;
        private string triggerentity;
        private PluginTraceViewer ptv;
        private string originallog;
        private Links links;

        public TraceControl(PluginTraceViewer ptv)
        {
            this.ptv = ptv;
            InitializeComponent();
            lblLoading.Dock = DockStyle.Fill;
            lblLoading.Visible = true;
            panLinks.Visible = false;
        }

        internal void SetLogText(string log, Entity tracer)
        {
            //        log = Madison1();
            textMessage.Clear();
            if (tracerecord == tracer)
            {
                return;
            }
            tracerecord = tracer;
            triggerentity = tracer[PluginTraceLog.PrimaryEntity].ToString();
            originallog = log.Replace("\r\n", "\n");
            _ = ShowMessageTextAsync(ptv.tsmiHighlightGuids.Checked, ptv.tsmiIdentifyRecords.Checked);
        }

        internal async Task ShowMessageTextAsync(bool highlightguids, bool showlinks)
        {
            panLinks.Visible = showlinks;
            picIcon.Left = ClientSize.Width - picIcon.Width - (showlinks ? 0 : 16);
            linkRecord.Text = "";
            btnShowAllRecordLinks.Enabled = false;
            btnShowAllRecordLinks.Text = $"Show records";
            textMessage.Text = originallog;
            if (string.IsNullOrWhiteSpace(originallog))
            {
                return;
            }
            if (highlightguids || showlinks)
            {
                lblLoading.Visible = showlinks;
                btnShowAllRecordLinks.Enabled = false;
                var currectentity = tracerecord;
                var log = textMessage.Text;
                links = new Links();
                await Task.Run(() => MatchGuids(links, log, currectentity, showlinks));
                if (currectentity != tracerecord || log != textMessage.Text)
                {   // This will cancel if UI is now on another trace line since this is async
                    return;
                }
                if (showlinks)
                {
                    lblLoading.Visible = false;
                    btnShowAllRecordLinks.Enabled = links.LinkRecords.Any();
                    btnShowAllRecordLinks.Text = links.LinkRecords.Any() ? $"Show {links.LinkRecords.Count()} records" : "No extra records";
                    textMessage.Text = Links.InsertRecordsInLog(log, links);
                    links.ForEach(SetRecordLink);
                    lblTrigger.Visible = !string.IsNullOrEmpty(linkRecord.Text);
                }
                HighlightRecords(links, showlinks);
            }
            textMessage.Select(0, 0);
        }

        private void MatchGuids(Links links, string log, Entity currectentity, bool lookuprecords)
        {
            foreach (Match m in Regex.Matches(log, guidregex))
            {
                if (currectentity != tracerecord)
                {   // This will cancel if UI is now on another trace line since this is async
                    return;
                }
                var logbeforeguid = log.Substring(0, m.Index);
                logbeforeguid = logbeforeguid.TrimEnd(spacechars);
                foreach (var word in wordsbetweenstableandguid)
                {
                    if (logbeforeguid.EndsWith(word))
                    {
                        logbeforeguid = logbeforeguid.Substring(0, logbeforeguid.Length - word.Length).TrimEnd(spacechars);
                    }
                }
                var guidname = "";
                if (lookuprecords)
                {
                    if (logbeforeguid.ToLowerInvariant().EndsWith("initiating user"))
                    {   // MS traces...
                        guidname = "Initiating User";
                    }
                    else if (logbeforeguid.LastIndexOfAny(spacechars) is int pos && pos >= 0)
                    {
                        guidname = logbeforeguid.Substring(pos + 1).Split('.').Last().Trim();
                    }
                    if (logbeforeguid.Substring(0, logbeforeguid.Length - guidname.Length).TrimEnd(spacechars).ToLowerInvariant().Equals("in execute"))
                    {   // Low-code Plugin indication
                        guidname = "Target";
                    }
                }
                if (Link.GetRecordLink(lookuprecords, ptv.recordlist, triggerentity, guidname, m.Value) is Link link)
                {
                    link.GuidLength = m.Length;
                    link.GuidPosition = m.Index;
                    link.LinkPosition = link.GuidPosition + link.GuidLength;
                    links.Add(link);
                }
            }
        }

        private void HighlightRecords(List<Link> links, bool showlinks)
        {
            foreach (var link in links)
            {
                if (link.IsAdded)
                {
                    // Green on the name of the record
                    textMessage.Select(link.LinkPosition + 1, link.LinkName.Length - 1);
                    textMessage.SelectionBackColor = System.Drawing.Color.LightGreen;
                    // Gray on the table identifier
                    var beforeid = textMessage.Text.Substring(0, link.LinkPosition).Trim(spacechars).LastIndexOf(link.LogIdentifier);
                    if (beforeid >= 0)
                    {
                        textMessage.Select(beforeid, link.LogIdentifier.Length);
                        textMessage.SelectionBackColor = System.Drawing.Color.LightGray;
                    }
                }
                // Yellow on the guid
                textMessage.Select(link.GuidPosition, link.GuidLength);
                textMessage.SelectionBackColor = System.Drawing.Color.Yellow;
            }
            textMessage.DeselectAll();
        }

        private void SetRecordLink(Link link)
        {
            if (link.Record == null)
            {
                return;
            }
            //LinkLabel linklabel = null;
            switch (link.TypeIdentifier)
            {
                //case "UserId":
                //    linklabel = linkUser;
                //    break;

                //case "InitUserId":
                //    linklabel = linkIniUser;
                //    break;

                case "Target":
                    var msgtable = $"{tracerecord["messagename"]} {link.Record.Metadata.ToDisplayName()} ";
                    linkRecord.Text = $"{msgtable}{link.Record.Name ?? link.Id.ToString()}";
                    linkRecord.Tag = link.Record.Url;
                    linkRecord.LinkArea = new LinkArea(msgtable.Length, linkRecord.Text.Length - msgtable.Length);
                    toolTip1.SetToolTip(linkRecord, $"Click to open this record.\n{link.Record.Url}");
                    break;
            }
            //if (linklabel != null)
            //{
            //    linklabel.Text = $"{link.Record.Metadata.ToDisplayName()}: {link.Record.Name}";
            //    linklabel.Tag = link.Record.Url;
            //    linklabel.LinkArea = new LinkArea(0, linklabel.Text.Length);
            //}
        }

        internal void Clear()
        {
            textMessage.Clear();
            panLinks.Visible = false;
        }

        private void TraceControl_KeyDown(object sender, KeyEventArgs e)
        {
            var textBox = textMessage;
            findtext = FindTextHandler.HandleFindKeyPress(e, textBox, findtext);
        }

        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UrlUtils.OpenUrl(sender, ptv.ConnectionDetail);
        }

        private void textMessage_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            UrlUtils.OpenUrl(e.LinkText, ptv.ConnectionDetail);
        }

        private void panLinks_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnShowAllRecordLinks_Click(object sender, EventArgs e)
        {
            var allrecords = new RecordLinks();
            allrecords.SetRecords(links.LinkRecords, ptv.ConnectionDetail);
            allrecords.ShowDialog();
        }

        private static string Data8()
        {
            return @"Data8:
context.MessageName = Create
context.PrimaryEntityName = contact
context.PrimaryEntityId = a00895fb-0e22-ef11-840a-7c1e520ac3f5
context.Stage = 10
context.RequestId = 23ad1353-48b4-45f8-a91f-81514e3d3d24
context.OwningExtension = new EntityReference(""sdkmessageprocessingstep"", new Guid(""376bd1ed-74b9-ee11-a569-0022482a96fe"")) { Name = ""Prevent importing duplicate contact""}
context.InputParameters[""Target""] = new Entity(""contact"", new Guid(""a00895fb-0e22-ef11-840a-7c1e520ac3f5"")) {
	[""lastname""] = ""Acosta"",
	[""telephone1""] = ""(954) 534-4384"",
	[""emailaddress1""] = ""juan.acosta@allitechgroup.com"",
	[""firstname""] = ""Juan"",
	[""mad_selectcompanyname""] = ""Alliance Technology Group"",
	[""address1_city""] = ""Pembroke Pines"",
	[""address1_stateorprovince""] = ""Florida"",
	[""address1_line1""] = ""14310 NW 11 ST Pembroke Pines, FL 33028"",
	[""address1_line2""] = null,
	[""address1_postalcode""] = ""33028"",
	[""mad_internaltf""] = false,
	[""mad_specsjointventure""] = new OptionSetValue(809760000),
	[""haschildrencode""] = new OptionSetValue(1),
	[""isbackofficecustomer""] = false,
	[""adx_profileisanonymous""] = false,
	[""mad_specssalescontact""] = true,
	[""customertypecode""] = new OptionSetValue(1),
	[""donotbulkpostalmail""] = false,
	[""msdyn_isminor""] = false,
	[""address2_addresstypecode""] = new OptionSetValue(1),
	[""msdyn_isassistantinorgchart""] = false,
	[""preferredappointmenttimecode""] = new OptionSetValue(1),
	[""donotpostalmail""] = false,
	[""adx_identity_lockoutenabled""] = false,
	[""creditonhold""] = false,
	[""msdyn_gdproptout""] = false,
	[""address2_freighttermscode""] = new OptionSetValue(1),
	[""address2_shippingmethodcode""] = new OptionSetValue(1),
	[""msdyn_orgchangestatus""] = new OptionSetValue(0),
	[""mad_referralsourcebool""] = false,
	[""adx_identity_logonenabled""] = false,
	[""territorycode""] = new OptionSetValue(1),
	[""donotsendmm""] = false,
	[""adx_identity_twofactorenabled""] = false,
	[""followemail""] = true,
	[""customersizecode""] = new OptionSetValue(1),
	[""adx_identity_mobilephoneconfirmed""] = false,
	[""preferredcontactmethodcode""] = new OptionSetValue(1),
	[""participatesinworkflow""] = false,
	[""msdyn_isminorwithparentalconsent""] = false,
	[""merged""] = false,
	[""marketingonly""] = false,
	[""donotbulkemail""] = false,
	[""donotfax""] = false,
	[""adx_profilealert""] = false,
	[""isprivate""] = false,
	[""mad_salescontact""] = true,
	[""adx_identity_locallogindisabled""] = false,
	[""donotphone""] = false,
	[""msdyn_disablewebtracking""] = false,
	[""shippingmethodcode""] = new OptionSetValue(1),
	[""adx_identity_emailaddress1confirmed""] = false,
	[""isautocreate""] = false,
	[""donotemail""] = false,
	[""educationcode""] = new OptionSetValue(1),
	[""adx_confirmremovepassword""] = false,
	[""mad_specsemailoptout""] = false,
}
context.InputParameters[""ReturnRepresentationColumnSet""] = Microsoft.Xrm.Sdk.Query.ColumnSet
context.InputParameters[""ReturnRepresentationRelationshipQueryCollection""] = Microsoft.Xrm.Sdk.RelationshipQueryCollection
context.SharedVariables[""ReturnRepresentationColumnSet""] = Microsoft.Xrm.Sdk.Query.ColumnSet
context.SharedVariables[""ReturnRepresentationRelationshipQueryCollection""] = Microsoft.Xrm.Sdk.RelationshipQueryCollection
context.SharedVariables[""IsAutoTransact""] = true
context.SharedVariables[""AcceptLang""] = ""en-US""
context.SharedVariables[""DefaultsAddedFlag""] = true

context.ParentContext is null";
        }

        private static string Madison1()
        {
            return @"Starting Timer: Madison.Dataverse.Plugin.HubSpotSyncPlugin.Execute()
BusinessUnitId: afa5f8b6-c4fa-e811-a949-000d3a1d578c
CorrelationId: 94b584f1-1612-4456-80d7-a70505fd6cae
Depth: 1
InitiatingUserId: 64f34634-c39f-ec11-b400-000d3a56ee22
IsInTransaction: True
IsolationMode: 2
MessageName: Update
Mode: 0
OperationCreatedOn: 6/4/2024 1:43:34 PM
OperationId: 32a5c12f-8cbe-444e-88f3-194be9f44217
Organization: org0f0fae4f(3cb61fa1-dd0a-44bf-ae76-6fa0257ce9f2)
OwningExtension: Madison.Dataverse.Plugin.HubSpotSyncPlugin: Post Update of mad_property (fa531d19-83cb-ee11-9078-002248280f49)
PrimaryEntityId: cf61a8b8-29fe-ec11-82e5-002248233898
PrimaryEntityName: mad_property
SecondaryEntityName: none
UserId: f8ac475e-c783-42f2-9a00-1974659d90e4
InputParameters: {
  ConcurrencyBehavior: ""Default"",
  Target: {
    mad_propertyid: ""cf61a8b8-29fe-ec11-82e5-002248233898"",
    mad_street1: ""112 Clifton Ave"",
    modifiedby: {LogicalName: ""systemuser"", Id: ""64f34634-c39f-ec11-b400-000d3a56ee22""},
    modifiedon: ""6/4/2024 1:43:34 PM"",
    modifiedonbehalfby: null
  }
}
OutputParameters: {}
PostEntityImages: {}
PreEntityImages_mad_property_cf61a8b829feec1182e5002248233898: {
  mad_city: ""Lakewood"",
  mad_state: ""NJ"",
  mad_street1: ""111 Clifton Ave"",
  mad_zip: ""08701""
}
SharedVariables: {
  AcceptLang: ""en-US,en;q=0.9"",
  IsAutoTransact: true,
  x-ms-app-name: ""sl_Operations""
}
Has Parent Context: True
Stage: 40
Starting Timer for Retrieve Multiple Request Query Expression: SELECT TOP 1 mad_securesystemsetting.*
FROM mad_securesystemsetting
WHERE
( mad_securesystemsetting.mad_name = 'hubspot.settings' )

Returned: 1
Timer Ended (  0.017 seconds)
Madison.Dataverse.Plugin.HubSpotSyncPlugin.ProcessProperty is Executing for Entity: mad_property, Message: Update
Starting Timer for Retrieve Multiple Request Query Expression: SELECT mad_specsengagementletter.mad_elnumber, mad_specsnpv.mad_el, mad_specsnpv.mad_fees, mad_specsnpv.mad_npvnumber, mad_specsnpv.mad_npvtype, mad_specsnpv.mad_property, mad_specsnpv.mad_purchaseprice, mad_specsnpv.ownerid, mad_specsnpv.statuscode
FROM mad_specsnpv
INNER JOIN mad_specsengagementletter on mad_specsnpv.mad_el = mad_specsengagementletter.mad_specsengagementletterid
WHERE
( mad_specsnpv.mad_property = 'cf61a8b8-29fe-ec11-82e5-002248233898' )

Returned: 2
Timer Ended (  0.020 seconds)
Starting Timer for Retrieve Request for mad_property with id cf61a8b8-29fe-ec11-82e5-002248233898 and Columns mad_city, mad_state, mad_street1, mad_zip
Timer Ended (  0.014 seconds)
Getting Id via Get to HubSpot Api: https://api.hubapi.com/crm/v3/objects/p44207540_specs_orders/EL-01253?idProperty=specs_order
{""id"":""13279065207"",""properties"":{""hs_createdate"":""2024-05-16T18:17:05.820Z"",""hs_lastmodifieddate"":""2024-05-16T18:17:06.654Z"",""hs_object_id"":""13279065207"",""specs_order"":""EL-01253""},""createdAt"":""2024-05-16T18:17:05.820Z"",""updatedAt"":""2024-05-16T18:17:06.654Z"",""archived"":false}
Getting Id via Get to HubSpot Api: https://api.hubapi.com/crm/v3/objects/p44207540_npvs/NPV-001116?idProperty=npv_number
{""id"":""13279659290"",""properties"":{""hs_createdate"":""2024-05-16T18:17:28.533Z"",""hs_lastmodifieddate"":""2024-06-04T13:41:08.439Z"",""hs_object_id"":""13279659290"",""npv_number"":""NPV-001116""},""createdAt"":""2024-05-16T18:17:28.533Z"",""updatedAt"":""2024-06-04T13:41:08.439Z"",""archived"":false}
Upserting {0}_npvs via Patch to HubSpot Api: https://api.hubapi.com/crm/v3/objects/p44207540_npvs/13279659290
{""id"":13279659290,""properties"":{""fees"":""125.0000"",""npv_number"":""NPV-001116"",""npv_type"":""Renovation"",""purchase_price"":""444444.0000"",""sales_rep"":""Ricki Lindenbaum"",""npv_status"":""Scheduling"",""property_address"":""112 Clifton Ave"",""city"":""Lakewood"",""state"":""NJ"",""zip"":""08701""},""associations"":[{""types"":[{""associationCategory"":""USER_DEFINED"",""associationTypeId"":61}],""to"":{""id"":""13279065207""}}]}
Getting associations via Get to HubSpot Api: https://api.hubapi.com/crm/v4/objects/p44207540_npvs/13279659290/associations/p44207540_specs_orders
{""results"":[{""toObjectId"":13279065207,""associationTypes"":[{""category"":""USER_DEFINED"",""typeId"":61,""label"":null}]}]}
Starting Timer for Retrieve Request for mad_property with id cf61a8b8-29fe-ec11-82e5-002248233898 and Columns mad_city, mad_state, mad_street1, mad_zip
Timer Ended (  0.012 seconds)
Getting Id via Get to HubSpot Api: https://api.hubapi.com/crm/v3/objects/p44207540_specs_orders/EL-01253?idProperty=specs_order
{""id"":""13279065207"",""properties"":{""hs_createdate"":""2024-05-16T18:17:05.820Z"",""hs_lastmodifieddate"":""2024-05-16T18:17:06.654Z"",""hs_object_id"":""13279065207"",""specs_order"":""EL-01253""},""createdAt"":""2024-05-16T18:17:05.820Z"",""updatedAt"":""2024-05-16T18:17:06.654Z"",""archived"":false}
Getting Id via Get to HubSpot Api: https://api.hubapi.com/crm/v3/objects/p44207540_npvs/NPV-003845?idProperty=npv_number
{""id"":""13279674548"",""properties"":{""hs_createdate"":""2024-05-16T18:17:06.537Z"",""hs_lastmodifieddate"":""2024-06-04T13:42:07.037Z"",""hs_object_id"":""13279674548"",""npv_number"":""NPV-003845""},""createdAt"":""2024-05-16T18:17:06.537Z"",""updatedAt"":""2024-06-04T13:42:07.037Z"",""archived"":false}
Upserting {0}_npvs via Patch to HubSpot Api: https://api.hubapi.com/crm/v3/objects/p44207540_npvs/13279674548
{""id"":13279674548,""properties"":{""fees"":""1000.0000"",""npv_number"":""NPV-003845"",""npv_type"":""Purchase"",""purchase_price"":""20002.0000"",""sales_rep"":""Ricki Lindenbaum"",""npv_status"":""NPV in Process"",""property_address"":""112 Clifton Ave"",""city"":""Lakewood"",""state"":""NJ"",""zip"":""08701""},""associations"":[{""types"":[{""associationCategory"":""USER_DEFINED"",""associationTypeId"":61}],""to"":{""id"":""13279065207""}}]}
Getting associations via Get to HubSpot Api: https://api.hubapi.com/crm/v4/objects/p44207540_npvs/13279674548/associations/p44207540_specs_orders
{""results"":[{""toObjectId"":13279065207,""associationTypes"":[{""category"":""USER_DEFINED"",""typeId"":61,""label"":null}]}]}
BusinessUnitId: afa5f8b6-c4fa-e811-a949-000d3a1d578c
CorrelationId: 94b584f1-1612-4456-80d7-a70505fd6cae
Depth: 1
InitiatingUserId: 64f34634-c39f-ec11-b400-000d3a56ee22
IsInTransaction: True
IsolationMode: 2
MessageName: Update
Mode: 0
OperationCreatedOn: 6/4/2024 1:43:34 PM
OperationId: 32a5c12f-8cbe-444e-88f3-194be9f44217
Organization: org0f0fae4f(3cb61fa1-dd0a-44bf-ae76-6fa0257ce9f2)
OwningExtension: Madison.Dataverse.Plugin.HubSpotSyncPlugin: Post Update of mad_property (fa531d19-83cb-ee11-9078-002248280f49)
PrimaryEntityId: cf61a8b8-29fe-ec11-82e5-002248233898
PrimaryEntityName: mad_property
SecondaryEntityName: none
UserId: f8ac475e-c783-42f2-9a00-1974659d90e4
InputParameters: {
  ConcurrencyBehavior: ""Default"",
  Target: {
    mad_propertyid: ""cf61a8b8-29fe-ec11-82e5-002248233898"",
    mad_street1: ""112 Clifton Ave"",
    modifiedby: {LogicalName: ""systemuser"", Id: ""64f34634-c39f-ec11-b400-000d3a56ee22""},
    modifiedon: ""6/4/2024 1:43:34 PM"",
    modifiedonbehalfby: null
  }
}
OutputParameters: {}
PostEntityImages: {}
PreEntityImages_mad_property_cf61a8b829feec1182e5002248233898: {
  mad_city: ""Lakewood"",
  mad_state: ""NJ"",
  mad_street1: ""111 Clifton Ave"",
  mad_zip: ""08701""
}
SharedVariables: {
  AcceptLang: ""en-US,en;q=0.9"",
  IsAutoTransact: true,
  Madison.Dataverse.Plugin.HubSpotSyncPlugin|Update|PostOperation|cf61a8b8-29fe-ec11-82e5-002248233898: 1,
  x-ms-app-name: ""sl_Operations""
}
Has Parent Context: True
Stage: 40
Timer Ended (  1.770 seconds): Madison.Dataverse.Plugin.HubSpotSyncPlugin.Execute()";
        }

        private static string Madison2()
        {
            return @"Starting Timer: Madison.Dataverse.Plugin.HubSpotSyncPlugin.Execute()
Starting Timer for Retrieve Multiple Request Query Expression: SELECT TOP 1 mad_securesystemsetting.*
FROM mad_securesystemsetting
WHERE
( mad_securesystemsetting.mad_name = 'hubspot.settings' )

Returned: 1
Timer Ended (  0.031 seconds)
Madison.Dataverse.Plugin.HubSpotSyncPlugin.ProcessProperty is Executing for Entity: mad_property, Message: Update
Starting Timer for Retrieve Multiple Request Query Expression: SELECT mad_specsengagementletter.mad_elnumber, mad_specsnpv.mad_el, mad_specsnpv.mad_fees, mad_specsnpv.mad_npvnumber, mad_specsnpv.mad_npvtype, mad_specsnpv.mad_property, mad_specsnpv.mad_purchaseprice, mad_specsnpv.ownerid, mad_specsnpv.statuscode
FROM mad_specsnpv
INNER JOIN mad_specsengagementletter on mad_specsnpv.mad_el = mad_specsengagementletter.mad_specsengagementletterid
WHERE
( mad_specsnpv.mad_property = 'cf61a8b8-29fe-ec11-82e5-002248233898' )

Returned: 2
Timer Ended (  0.073 seconds)
Starting Timer for Retrieve Request for mad_property with id cf61a8b8-29fe-ec11-82e5-002248233898 and Columns mad_city, mad_state, mad_street1, mad_zip
Timer Ended (  0.024 seconds)
Starting Timer for Retrieve Multiple Request Query Expression: SELECT TOP 1 mad_securesystemsetting.*
FROM mad_securesystemsetting
WHERE
( mad_securesystemsetting.mad_name = 'hubspot.settings' )";
        }
    }
}