namespace Cinteros.XTB.PluginTraceViewer
{
    using System.ComponentModel.Composition;
    using Utils;
    using XrmToolBox.Extensibility;
    using XrmToolBox.Extensibility.Interfaces;

    [Export(typeof(IXrmToolBoxPlugin)),
    ExportMetadata("Name", "Plugin Trace Viewer ALPHA"),
    ExportMetadata("Description", "Investigate the Plug-in Trace Log"),
    ExportMetadata("SmallImageBase64", Constants.B64_IMAGE_SMALL), 
    ExportMetadata("BigImageBase64", Constants.B64_IMAGE_LARGE), 
    ExportMetadata("BackgroundColor", "#ffffff"), // Use a HTML color name
    ExportMetadata("PrimaryFontColor", "#000000"), // Or an hexadecimal code
    ExportMetadata("SecondaryFontColor", "Blue")]
    public class PluginTraceViewerPlugin : PluginBase
    {
        #region Public Methods

        public override IXrmToolBoxPluginControl GetControl()
        {
            return new PluginTraceViewer();
        }

        #endregion Public Methods
    }
}