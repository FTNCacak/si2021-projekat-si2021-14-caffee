using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Caffee
{
    class TableButton : Button
    {
        public TableButton()
        {
            this.Text = "";
            this.Name = "table";
            this.Size = new Size(75, 75);
            this.BackColor = Color.FromArgb(255, 156, 102, 68);
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            ControlExtension.Draggable(this, true);
            //kontrole za mouse up
            
        }
    }
}
