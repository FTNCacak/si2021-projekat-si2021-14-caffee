using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;

namespace Caffee
{
    class TableButton : Button
    {
        private int posXStart;
        private int posYStart;
        private int posXEnd;
        private int posYEnd;

        

        public TableButton()
        {
            int table_dimension = (int)(85 * Screen.PrimaryScreen.Bounds.Height) / 768;
            this.Text = "";
            this.Name = "table";
            this.Size = new Size(table_dimension,table_dimension);
            this.BackgroundImage = Properties.Resources.table_picture;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 0, 0);
            this.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 0, 0);
            this.MouseDown += button1_MouseDown;
            this.MouseUp += button1_MouseUp;
            ControlExtension.Draggable(this, true);                  
        }

        public void ShowOrders()
        {
            TableMenu tm = new TableMenu();
            tm.StartPosition = FormStartPosition.Manual;
            int dPosX = (Screen.PrimaryScreen.Bounds.Width / 2) - (tm.Size.Width / 2);
            int dPosY = (Screen.PrimaryScreen.Bounds.Height / 2) - (tm.Size.Height / 2);
            tm.Location = new Point(dPosX, dPosY);
            tm.ShowDialog();
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            posXStart = this.Location.X;
            posYStart = this.Location.Y;
        }


        private void button1_MouseUp(object sender, MouseEventArgs e)
        {//u ovoj funkciji negde se poziva cuvanje pozicije u bp
            posXEnd = this.Location.X;
            posYEnd = this.Location.Y;

            if ((posXStart == posXEnd) && (posYStart == posYEnd))
            {
                ShowOrders();
            }
            //Console.WriteLine("StartX: {0}, StartY: {1}\nEndX: {2}, EndY: {3}\n\n", posXStart, posYStart, posXEnd, posYEnd);
        }
    }
}
