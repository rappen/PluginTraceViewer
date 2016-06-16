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
        internal const string B64_IMAGE_LARGE = "iVBORw0KGgoAAAANSUhEUgAAAFAAAABQCAIAAAABc2X6AAAACXBIWXMAAAsTAAALEwEAmpwYAAAE4UlEQVR4nO3V6W/TZhzAcf5Bl5ZyiLaom2CdQBMbsG6ABuMcGtteINiYoNIk5hxtUnqsd5Ne2EmcuM3R3LVDkrZJnKtpjjaO7efZCxc3QLXBtGnSwxN9X0S/Pq79SR47h0iC+qA69L9fAQZjMAZjMAZjMAZ/MGEw6mEw6mEw6mEw6mEw6mEw6mEw6mEw6mEw6mEw6mEw6mEw6h0AHjvvHux2kgRlPGqbvOSZvbo6c9k30sOSLXsL9G30xAXP7JXVmcu+0bPLusO0dqyulZ686F28G7Je8w+cdGjz4U/YqV6v2vjnbnU42O2c/sqnb6Wbz248Zp/4wj3V65246BnocGhHqU1e8qiXMXyGnb8VXLgdHOlZ1o7tP2Gf+nJv5dBp17uCZVHxm9d1h+lSogabXmn3Vv8JO0lQqZWt5nmBqz7/yKkCirGqNm/U5MW7IZKgLN/4gQK0eTm1q8J2iiKEMDC4oZ2a+YVr7Mjqsvp2Y+FuEL7+EquSrpUOjWzu/0MAeYuga6H0rXRVqGsrAYA+Y/I9wP3H7UAGq8akqZMxdTEv7oeBArz6JElQYlXirYKpkzF1MtZrfmlX5mYFkqA4iyBWpKler66VNp9iUitbYlkytNvYvhhQwMiny+oh6jdP/RCRRSX4fKO+3dC30SRB/XFuBSiAmxWGe1hTJ2PqYPRttHpIfVuKTqTV4ezVVQihl0wYj9oNR2zOX3kI4dK9kLmLgRCu/PZSveDIWEqRQP9x+/uBXU94bV5K1JL2ggoOjWxq8w1XschXSYKq5ercTEabW675IYTTX/vYvpgiA+Ox18696SombfnhMyxQwMLtIElQbF8MAGjqcLx9SbulRnBo74x+07q0I+uP2PZuohZqpyBGJ9Mq2P5gTZ07H/MQQHMX88/BBa6yzhwATtD5rXhN30pLu3LzLhr7bAVCuPhdiO2LQQALXDUfreSjlYU7QfMpRpHB0r0QSVC5UDlB5UmCCgxuSLvygTdeM5ibydSy9ea/Fvhq0p5XwczPXOJFbsNZbNTkjK/03lv63cG6FlqsSsGh/Rty4oIHQjh/K6huaa8+4X4Wdz+Lj593u57wEML4Uo63CFvxmlxXBk46fIakIoHmR+CB4Mh4eqcoak9QkqBKyVp8KaeCHQ/XirGqLCqOR9wbe+pfBpMElQ2Vc+Gy7tWlsE9jEMCh0663t3Q+WilwlfBYKjyWioyngAIcD9cW7gQhhPM3A38Ndj7mgAJHz+49nAe7nUpD8fye0Lb0SA9bL0vcTKb5Q/lPwEvfhyGAGV8pYN7gLYIsKklbniSoN8Cj55YBgHM39mFpT0nwb+vb6FyoLItKyr0VX8q9XMypD7M3wAMdjp2CWMvVw6Op0PBmObUrVqTnHzub72HrdT+QAfs09k5gblZ4cT9saLfxVsF63a/NV/vX2b4YSVDRqQz9U0Sbu57E/KZ19f38rWDSls9HK2lPyf0sbmi3kQQ1922AtwqGV4+ZuRsBziI0//zO3Qzwc1njMZuh3eZ4xK1NZ2LzWX4uq62JjKepH/fPOHTGFRlPZYPlXKi8Np1Rv+3+4/bYfHbmyqq6xv5gjbcK5lPOvwejHQajHgajHgajHgajHgajHgajHgajHgajHgajHgajHgajHgajHgajHgajHgajHgajHgajHgaj3p/lnd74gNCgJgAAAABJRU5ErkJggg==";

        /// <summary>
        /// Encoded small icon for plugins
        /// </summary>
        internal const string B64_IMAGE_SMALL = "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAIAAAD8GO2jAAAACXBIWXMAAAsTAAALEwEAmpwYAAABlElEQVRIie3SO0vDYBQGYP9gUpvWVqGDgouOLjqITmrFwUVcKiryJV9SRYolVoNW2n6XVNOqtZqLIekFk1508B84FESdXESRwOGF8y4PHM4QYNCPzlAABEAABMDfAQSOABZJo6oQxoBBYozCKAEM4lm0nygDFvEhLMUp5IgQxjyLAIOEMBajRIrTQQ85kh5VAYMgR6QY/QqYsqdu2HrmqVHsny/UW/TZyHqFZd0+61Z3XP3I0zNP1V1Xma2Zsn+928jN3NhKp7RqVLbd3sMrWjPcQq+ebpN1q01fbkGzuuN+BbSUk52uFpNGZdstb9oHifJdum0d+4BBVs63cn4Nts7m64+nnSbqa1vO0VQFMIgfxkbWyy/eF5Z0wCLr2LeVjq10iknjG4DYcvLd8qZtyp4p+4BBWsoprug1oamlnMcTv5Q0BsDhxJVz0b3Za6gbtin7WspR5mqfAClGxSjhQxhyRIwSGCE8i8QRKoRxZlLjQ3hw1kHywxhGCIyQ9Jj6Xkpxejh++XH9Z28aAAEQAAHwq8AbCBEE0qWf5IoAAAAASUVORK5CYII=";

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