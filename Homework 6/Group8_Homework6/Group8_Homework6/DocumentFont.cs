using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Group8_Homework6
{
    [Serializable]
    class DocumentFont
    {
        public DocumentFont()
        {
            this.Text = "";
            this.Color = Color.Black;
            this.Font = new Font("Arial", 12);
        }
        public string Text { get; set; }
        public Color Color { get; set; }
        public Font Font { get; set; }
    }
}
