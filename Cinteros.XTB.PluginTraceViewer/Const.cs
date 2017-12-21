// *********************************************************************
// Created by: Latebound Constant Generator 1.2017.12.901 for XrmToolBox
// Author    : Jonas Rapp http://twitter.com/rappen
// Repo      : https://github.com/rappen/LateboundConstantGenerator
// Source Org: https://jonassandbox.crm4.dynamics.com/
// Filename  : C:\Dev\Git\XrmToolBox.PluginTraceViewer\Cinteros.XTB.PluginTraceViewer\Const.cs
// Created   : 2017-12-22 00:08:19
// *********************************************************************

namespace Cinteros.XTB.PluginTraceViewer.Const
{
    /// <summary>OwnershipType: OrganizationOwned, IntroducedVersion: 5.0.0.0</summary>
    public static class Organization
    {
        public const string EntityName = "organization";
        /// <summary>Type: String, RequiredLevel: SystemRequired, MaxLength: 160, Format: Text</summary>
        public const string PrimaryName = "name";
        /// <summary>Type: Picklist, RequiredLevel: SystemRequired, OptionSetType: Picklist, DefaultFormValue: 0</summary>
        public const string PluginTraceLogsetting = "plugintracelogsetting";
        public enum PluginTraceLogsetting_OptionSet
        {
            Off = 0,
            Exception = 1,
            All = 2
        }
    }

    /// <summary>DisplayName: Plug-in Trace Log, OwnershipType: OrganizationOwned, IntroducedVersion: 7.1.0.0</summary>
    public static class PluginTraceLog
    {
        public const string EntityName = "plugintracelog";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired</summary>
        public const string PrimaryKey = "plugintracelogid";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 1024, Format: Text</summary>
        public const string PrimaryName = "typename";
        /// <summary>Type: Memo, RequiredLevel: None, MaxLength: 1073741823</summary>
        public const string Configuration = "configuration";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: 0, MaxValue: 2147483647</summary>
        public const string PerformanceConstructorDuration = "performanceconstructorduration";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string PerformanceConstructorStarttime = "performanceconstructorstarttime";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: None</summary>
        public const string CorrelationId = "correlationid";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: systemuser</summary>
        public const string CreatedBy = "createdby";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string CreatedOn = "createdon";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: 0, MaxValue: 2147483647</summary>
        public const string Depth = "depth";
        /// <summary>Type: Memo, RequiredLevel: None, MaxLength: 1073741823</summary>
        public const string ExceptionDetails = "exceptiondetails";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: 0, MaxValue: 2147483647</summary>
        public const string PerformanceExecutionDuration = "performanceexecutionduration";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string PerformanceExecutionStarttime = "performanceexecutionstarttime";
        /// <summary>Type: Memo, RequiredLevel: None, MaxLength: 1073741823</summary>
        public const string MessageBlock = "messageblock";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 1024, Format: Text</summary>
        public const string MessageName = "messagename";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Mode, OptionSetType: Picklist, DefaultFormValue: 1</summary>
        public const string Mode = "mode";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Operation Type, OptionSetType: Picklist, DefaultFormValue: 0</summary>
        public const string OperationType = "operationtype";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: None</summary>
        public const string OrganizationId = "organizationid";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: None</summary>
        public const string PersistenceKey = "persistencekey";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: None</summary>
        public const string PluginStepId = "pluginstepid";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 1000, Format: Text</summary>
        public const string PrimaryEntity = "primaryentity";
        /// <summary>Type: Memo, RequiredLevel: None, MaxLength: 1073741823</summary>
        public const string Profile = "profile";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: None</summary>
        public const string RequestId = "requestid";
        /// <summary>Type: Memo, RequiredLevel: None, MaxLength: 1073741823</summary>
        public const string SecureConfiguration = "secureconfiguration";
        /// <summary>Type: Boolean, RequiredLevel: SystemRequired, True: 1, False: 0, DefaultValue: False</summary>
        public const string IsSystemCreated = "issystemcreated";
        public enum Mode_OptionSet
        {
            Synchronous = 0,
            Asynchronous = 1
        }
        public enum OperationType_OptionSet
        {
            Unknown = 0,
            PlugIn = 1,
            WorkflowActivity = 2
        }
    }

    /// <summary>DisplayName: Plug-in Type, OwnershipType: OrganizationOwned, IntroducedVersion: 5.0.0.0</summary>
    public static class PluginType
    {
        public const string EntityName = "plugintype";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired</summary>
        public const string PrimaryKey = "plugintypeid";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 256, Format: Text</summary>
        public const string PrimaryName = "name";
    }

    /// <summary>DisplayName: Plug-in Type Statistic, OwnershipType: OrganizationOwned, IntroducedVersion: 5.0.0.0</summary>
    public static class PluginTypeStatistic
    {
        public const string EntityName = "plugintypestatistic";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired</summary>
        public const string PrimaryKey = "plugintypestatisticid";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: systemuser</summary>
        public const string CreatedBy = "createdby";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: systemuser</summary>
        public const string CreatedOnBehalfBy = "createdonbehalfby";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string CreatedOn = "createdon";
        /// <summary>Type: Integer, RequiredLevel: SystemRequired, MinValue: 0, MaxValue: 2147483647</summary>
        public const string ExecuteCount = "executecount";
        /// <summary>Type: Integer, RequiredLevel: SystemRequired, MinValue: 0, MaxValue: 2147483647</summary>
        public const string FailureCount = "failurecount";
        /// <summary>Type: Integer, RequiredLevel: SystemRequired, MinValue: 0, MaxValue: 100</summary>
        public const string FailurePercent = "failurepercent";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: systemuser</summary>
        public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: systemuser</summary>
        public const string ModifiedBy = "modifiedby";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string ModifiedOn = "modifiedon";
        /// <summary>Type: Integer, RequiredLevel: SystemRequired, MinValue: 0, MaxValue: 2147483647</summary>
        public const string CrashCount = "crashcount";
        /// <summary>Type: Lookup, RequiredLevel: SystemRequired, Targets: organization</summary>
        public const string OrganizationId = "organizationid";
        /// <summary>Type: Integer, RequiredLevel: SystemRequired, MinValue: 0, MaxValue: 100</summary>
        public const string CrashcontributionPercent = "crashcontributionpercent";
        /// <summary>Type: Integer, RequiredLevel: SystemRequired, MinValue: 0, MaxValue: 100</summary>
        public const string CrashPercent = "crashpercent";
        /// <summary>Type: Lookup, RequiredLevel: SystemRequired, Targets: plugintype</summary>
        public const string PluginTypeId = "plugintypeid";
        /// <summary>Type: Integer, RequiredLevel: SystemRequired, MinValue: 0, MaxValue: 100</summary>
        public const string TerminatecpucontributionPercent = "terminatecpucontributionpercent";
        /// <summary>Type: Integer, RequiredLevel: SystemRequired, MinValue: 0, MaxValue: 100</summary>
        public const string TerminatehandlescontributionPercent = "terminatehandlescontributionpercent";
        /// <summary>Type: Integer, RequiredLevel: SystemRequired, MinValue: 0, MaxValue: 100</summary>
        public const string TerminatememorycontributionPercent = "terminatememorycontributionpercent";
        /// <summary>Type: Integer, RequiredLevel: SystemRequired, MinValue: 0, MaxValue: 100</summary>
        public const string TerminateothercontributionPercent = "terminateothercontributionpercent";
        /// <summary>Type: Integer, RequiredLevel: SystemRequired, MinValue: 0, MaxValue: 2147483647</summary>
        public const string Averageexecutetimeinmilliseconds = "averageexecutetimeinmilliseconds";
    }

    /// <summary>DisplayName: Sdk Message Processing Step, OwnershipType: OrganizationOwned, IntroducedVersion: 5.0.0.0</summary>
    public static class SdkMessageProcessingStep
    {
        public const string EntityName = "sdkmessageprocessingstep";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired</summary>
        public const string PrimaryKey = "sdkmessageprocessingstepid";
        /// <summary>Type: String, RequiredLevel: SystemRequired, MaxLength: 256, Format: Text</summary>
        public const string PrimaryName = "name";
        /// <summary>Type: Integer, RequiredLevel: SystemRequired, MinValue: -2147483648, MaxValue: 2147483647</summary>
        public const string Rank = "rank";
        /// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Stage, OptionSetType: Picklist, DefaultFormValue: 10</summary>
        public const string Stage = "stage";
        public enum Stage_OptionSet
        {
            InitialPreOperationForInternalUseonly = 5,
            PreValidation = 10,
            InternalPreOperationBeforeExternalPluginSForInternalUseonly = 15,
            PreOperation = 20,
            InternalPreOperationAfterExternalPluginSForInternalUseonly = 25,
            MainOperationForInternalUseonly = 30,
            InternalPostOperationBeforeExternalPluginSForInternalUseonly = 35,
            PostOperation = 40,
            InternalPostOperationAfterExternalPluginSForInternalUseonly = 45,
            PostOperationDeprecated = 50,
            FinalPostOperationForInternalUseonly = 55
        }
    }
}
