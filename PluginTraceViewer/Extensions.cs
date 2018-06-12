using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public static bool Contains(this EntityCollection entities, Guid id)
        {
            return entities.Entities.Any(e => e.Id.Equals(id));
        }

        public static void Remove(this EntityCollection entities, Guid id)
        {
            var i = 0;
            while (i < entities.Entities.Count)
            {
                if (entities.Entities[i].Id.Equals(id))
                {
                    entities.Entities.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
        }
    }
}
