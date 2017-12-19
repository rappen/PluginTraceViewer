using System.Collections.Generic;
using System.Windows.Forms;

namespace Cinteros.XTB.PluginTraceViewer
{
    public static class Extensions
    {
        public static List<T> AllChildren<T>(this Control control) where T : Control
        {
            var result = new List<T>();
            if (control is T)
            {
                result.Add((T)control);
            }
            foreach (Control child in control.Controls)
            {
                result.AddRange(child.AllChildren<T>());
            }
            return result;
        }
    }
}
