using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group8_Homework6
{
    interface IPreferencesDialog
    {
        event EventHandler OK;
        event EventHandler Apply;
        event EventHandler Cancel;

        Color color { get; set; }
        Font font { get; set; }
    }
}
