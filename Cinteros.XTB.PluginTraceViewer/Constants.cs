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
        internal const string B64_IMAGE_LARGE = "iVBORw0KGgoAAAANSUhEUgAAAFAAAABQCAYAAACOEfKtAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAAYdEVYdFNvZnR3YXJlAHBhaW50Lm5ldCA0LjAuNWWFMmUAAAPJSURBVHhe7Zw5i1NRGIYnKsO4pBhHbKK4dDZiExgG41ZZ+QOsVRSmCSIWFsMIgp1VXEaxMGBpof6BcSsFR0jnGBX9AeOKaK7vG3JkknxJ7rm5yznnngeeZibLvQ9Zv3NvJjwezwAK8EJHjyaMdw8GHX1EDXrjKa9D/s8zhEHxlHehjziAbfAxlMKt10cUYLyXUAom+RBuhR6gG0/5COY+YhFGiad8DnMbcR98B6UwOuYy4n74CUpBovgK7oC5IO54yg9wL3Sa4/ArlALEodMRGe8XlHY8ThnxIHSKtOIpv8Mj0AlOwd9Q2tEkdSLiWfgHSjuYhlZHnIctKO1YmjLiGWgVpsRTclvOQ/Mpl8uXS6VSCwaG2ZqbmzM+4vza2lorMJQWmJmZuYPtNHIc1n7aImBnc82kWCzyKb0EjYm4EV6B7dc8SwLSp3ALzBTG6xrBWxSQPoOZRdwM+9YvLAtIM4k4cBBqYUD6Fm6HqTB0imxpQMohxB6YKBxaDh3BWxyQJhqRI/iRg1DLA1JGrMBYCRWPOhCQ8vtzbBEPwI9QuqM+dQKurq4G1Wo1VScnJ8XtFowl4lH4E0p3IKoTsNFoiLdhkIx4GkZCOx51LKDyHNTiJPwBpRsbqqMBaeiIHPlINxBKhwPSkRHHikcdD0g5DhO5BqUraJmDgLQvIv8gXVDbnASkbNYeQlQ7f4jFHAWkddg+sokjHekC2uYoYBP+/94cW8ScBGSrvqPB+HzmWoF0hdDmIODQASwXWsZ6Q3E84DIcOb1mxBsw0sK4wwEfQC5jhIYfqrUjOhrwNoyEdkQHA96CY8HvfxzrSDfep07AZrMZVCqV1JydnQ0KhYK43YJ/4SUYCxxthYqoEzALQk6kGU97hDUKHmc3MqIDARmPxzUmAiN+gdIdt7U8IA+APwEThUfBc+VK2gCbAzLeYZgKAyNaGjDVeIpdkKdZdW2MhQE/w0MwEziE6IpoWcD3cDfMlK6IFgV8AzOPp2DE+9CWgBwKTEGj2ACXTA84PT1tZDzFVK1WW1lcXAxMtF6vLy8sLBgbT8GPOCtQvdaYotGPvF763p0z1qp4ClMi3oSboJUw4hMo7VgaMp71vzHDHeCP5Ug7mKROxFOkHZFTZGfiKdKIyFneRehcPAV37CqMtOI3wkSmyKYy9mF0PeYqniKuiN+gMz8wocu4ERkv9nM6bOMYDL1sus5cP/J6Cb1s2pHnrfh4PYSNmMpJgbbCs6KGRfTxQsBxmHRqmY+nQW/E13An9GigIr6AnOp4IsBHnY/n8QxgYuIfcGnV4Ve77pMAAAAASUVORK5CYII=";
        
        /// <summary>
        /// Encoded small icon for plugins
        /// </summary>
        internal const string B64_IMAGE_SMALL = "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAIAAAD8GO2jAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAACxEAAAsRAX9kX5EAAAAHdElNRQfeCwMQBidu8/idAAAAGHRFWHRTb2Z0d2FyZQBwYWludC5uZXQgNC4wLjVlhTJlAAAB0ElEQVRIS6WTS6oCMRBFA6KCQxUcOnQ3KuKftwqHbw+C6xBfuwnBiSNnijhyE/7flZSxOh+T7j6j7pDK6U7dEs8kHI/HyWRyv9/pPYAEgsPhUKvVhBDj8fh6vdKqj1DBfr+vVqs4XRLuCBLsdrtKpUJnvxmNRrfbjXa48QtwerlcplPjDIdDbz88AtyM+e2cwWDweDxot41vAnSV37uLfr9PBTacAiRSZiaEXq9HZQZ2AU6fzWZ/ScB+az8sApl31NB7GJ1Ox5pdXaDynkKAKtMRE/C8pxMAbT4+Ai3vXHA6nX59NBoNqozPBwnMvHPBZrOh1WDUfLwE1rxnFAA5H8KV9+wCgPkQaEiz2aQFRnZBLpebz+evK7pcLu12m5bfZBTk8/nFYoFaavL5fNYcXLDdbus+SqUSVQpRKBSiKJK1n5hq/8EFIag5KBaLy+WSVrkAYAhbrZbcl06Ab+eng5gAoOfSkUKAe1c3o9AFAAOCXCUVdLtd2VUNi0AynU5/krBer6kyjlPgmg8TmXcqM3AKgHU+NFTeXXwTAHM+ODzvLjwC4PoPLe8u/ALA50Ni5t1FkACo+QDWvLsIFQA5H8jM965qJBBIVqsVPYXwfP4DfpspS0RmunsAAAAASUVORK5CYII=";
        
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