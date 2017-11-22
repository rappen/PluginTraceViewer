namespace Cinteros.XTB.PluginTraceViewer
{
    using System.ComponentModel.Composition;
    using Utils;
    using XrmToolBox.Extensibility;
    using XrmToolBox.Extensibility.Interfaces;

    [Export(typeof(IXrmToolBoxPlugin)),
    ExportMetadata("Name", "Plugin Trace Viewer"),
    ExportMetadata("Description", "Investigate the Plug-in Trace Log with easy filtering and display possibilities"),
    ExportMetadata("SmallImageBase64", Constants.B64_IMAGE_SMALL), 
    ExportMetadata("BigImageBase64", Constants.B64_IMAGE_LARGE), 
    ExportMetadata("BackgroundColor", "#f8f8ff"),
    ExportMetadata("PrimaryFontColor", "#00319C"),
    ExportMetadata("SecondaryFontColor", "#9439B5")]
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