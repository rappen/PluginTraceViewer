namespace Cinteros.XTB.PluginTraceViewer.Utils
{
    /// <summary>
    /// Structure holding constants
    /// </summary>
    internal struct Constants
    {
        #region Internal Fields

        /// <summary>
        /// Encoded large icon for plugins
        /// </summary>
        internal const string B64_IMAGE_LARGE = "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";

        /// <summary>
        /// Encoded small icon for plugins
        /// </summary>
        internal const string B64_IMAGE_SMALL = "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";

        internal const int U_HEADER_MAINWIDTH = 200;

        /// <summary>
        /// Text for solution that is not available
        /// </summary>
        internal const string U_ITEM_NA = "N/A";

        /// <summary>
        /// Default solution unique name
        /// </summary>
        internal const string U_SOLUTION_DEFAULT = "Default";

        #endregion Internal Fields

        #region Internal Structs

        /// <summary>
        /// Structure holding CRM related constants
        /// </summary>
        internal struct Crm
        {
            #region Internal Structs

            /// <summary>
            /// Structure holding CRM Attributes related constants
            /// </summary>
            internal struct Attributes
            {
                #region Internal Fields

                internal const string CULTURE = "culture";
                internal const string EVENT_HANDLER = "eventhandler";
                internal const string FRIENDLY_NAME = "friendlyname";
                internal const string IS_HIDDEN = "ishidden";
                internal const string IS_MANAGED = "ismanaged";
                internal const string IS_VISIBLE = "isvisible";
                internal const string ISOLATION_MODE = "isolationmode";
                internal const string NAME = "name";
                internal const string PLUGIN_TYPE_ID = "plugintypeid";
                internal const string PUBLIC_KEY_TOKEN = "publickeytoken";
                internal const string SOLUTION_ID = "solutionid";
                internal const string STATE_CODE = "statecode";
                internal const string STATUS_CODE = "statuscode";
                internal const string UNIQUE_NAME = "uniquename";
                internal const string PRIMARY_OBJECT_TYPE_CODE = "primaryobjecttypecode";
                internal const string VERSION = "version";

                #endregion Internal Fields
            }

            /// <summary>
            /// Structure holding CRM Entities related constantns
            /// </summary>
            internal struct Entities
            {
                #region Internal Fields

                /// <summary>
                /// Name of the 'pluginassembly' entity
                /// </summary>
                internal const string PLUGIN_ASSEMBLY = "pluginassembly";

                /// <summary>
                /// Name of the 'plugintype' entity
                /// </summary>
                internal const string PLUGIN_TYPE = "plugintype";

                /// <summary>
                /// Name of the 'sdkmessageprocessingstep' entity
                /// </summary>
                internal const string PROCESSING_STEP = "sdkmessageprocessingstep";

                /// <summary>
                /// Name of the 'sdkmessage' entity
                /// </summary>
                internal const string MESSAGE = "sdkmessage";

                /// <summary>
                /// Name of the 'sdkmessagefilter' entity
                /// </summary>
                internal const string MESSAGE_FILTER = "sdkmessagefilter";

                /// <summary>
                /// Name of the 'solution' entity
                /// </summary>
                internal const string SOLUTION = "solution";

                #endregion Internal Fields
            }

            #endregion Internal Structs
        }

        /// <summary>
        /// Structure holding UI related constants
        /// </summary>
        internal struct UI
        {
            #region Internal Fields

            /// <summary>
            /// Name of the plugin toolstrip
            /// </summary>
            internal const string MENU = "tsMenu";

            #endregion Internal Fields

            #region Internal Structs

            /// <summary>
            /// Structure holding UI Buttons related constants
            /// </summary>
            internal struct Buttons
            {
                #region Internal Fields

                /// <summary>
                /// Name of toolstrip's Back button
                /// </summary>
                internal const string BACK = "tsbBack";

                /// <summary>
                /// Name of toolstrip's Compare button
                /// </summary>
                internal const string COMPARE = "tsbCompare";

                /// <summary>
                /// Name of toolstrip's Open drop down button
                /// </summary>
                internal const string OPEN = "tsddOpen";

                internal const string OPEN_CURRENT_CONNECTION = "tsmiCurrentConnection";

                internal const string OPEN_REFERENCE_FILE = "tsmiReferenceFile";

                /// <summary>
                /// Name of toolstrip's Save button
                /// </summary>
                internal const string SAVE = "tsbSave";

                #endregion Internal Fields
            }

            /// <summary>
            /// Structure holding UI Labels related constants
            /// </summary>
            internal struct Labels
            {
                #region Internal Fields

                /// <summary>
                /// Text for solutions group
                /// </summary>
                internal const string ASSEMBLIES = "Assemblies";

                /// <summary>
                /// Text for solutions group
                /// </summary>
                internal const string SOLUTIONS = "Solutions";

                #endregion Internal Fields
            }

            #endregion Internal Structs
        }

        /// <summary>
        /// Structure holding XML related constants
        /// </summary>
        internal struct Xml
        {
            #region Internal Fields

            internal const string ASSEMBLIES = "assemblies";
            internal const string ASSEMBLY = "assembly";
            internal const string FRIENDLY_NAME = "friendly-name";
            internal const string SOLUTION = "solution";
            internal const string SOLUTIONS = "solutions";
            internal const string STEP = "step";
            internal const string STEPS = "steps";
            internal const string UNIQUE_NAME = "unique-name";
            internal const string VERSION = "version";
            internal const string PLUGIN = "plugin";
            internal const string PLUGINS = "plugins";
            internal const string ID = "id";
            internal const string IMAGE = "image";

            #endregion Internal Fields
        }

        #endregion Internal Structs
    }
}