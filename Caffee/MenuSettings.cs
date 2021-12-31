using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caffee
{
    public partial class MenuSettings : Form
    {
        public MenuSettings()
        {
            InitializeComponent();
            InitializeColumns(); // <--- test funkcija
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void InitializeColumns()
        {
            //temporary test data for design purpose
            string[] row = new string[] { "Kokakola 0.33l", "75.00" };
            dataGridView_menuItems.Rows.Add(row);
            row = new string[] { "Lav pivo 1l", "100.00" };
            dataGridView_menuItems.Rows.Add(row);
            row = new string[] { "Domaca kafa", "50.00" };
            dataGridView_menuItems.Rows.Add(row);
            row = new string[] { "Lavita sok", "60.00" };
            dataGridView_menuItems.Rows.Add(row);
            row = new string[] { "Kisela voda", "30.00" };
            dataGridView_menuItems.Rows.Add(row);
            //temporary test data for design purpose
        }

        private void dataGridView_menuItems_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
            e.CellStyle.SelectionBackColor = Color.FromArgb(255, 230, 204, 178);
            e.CellStyle.SelectionForeColor = Color.FromArgb(255, 99, 65, 44);
        }

        private void buttonDeleteItem_Click(object sender, EventArgs e)
        {
            using (DeleteItemConfirm confirmDelete = new DeleteItemConfirm())
            {
                confirmDelete.StartPosition = FormStartPosition.Manual;
                int dPosX = (Screen.PrimaryScreen.Bounds.Width / 2) - (confirmDelete.Size.Width / 2);
                int dposY = (Screen.PrimaryScreen.Bounds.Height / 2) - (confirmDelete.Size.Height / 2);
                confirmDelete.Location = new Point(dPosX, dposY);
                if (confirmDelete.ShowDialog()==System.Windows.Forms.DialogResult.OK)
                {
                    //obrisati artikal iz baze i iz liste
                }
            }
                       
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            using (AddItem addItem = new AddItem())
            {
                addItem.StartPosition = FormStartPosition.Manual;
                int dPosX = (Screen.PrimaryScreen.Bounds.Width / 2) - (addItem.Size.Width / 2);
                int dposY = (Screen.PrimaryScreen.Bounds.Height / 2) - (addItem.Size.Height / 2);
                addItem.Location = new Point(dPosX, dposY);
                if (addItem.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //refresh list
                    // ovo je samo test ---> InitializeColumns();
                }

            }
            
            
        }

        private void buttonEditItem_Click(object sender, EventArgs e)
        {
            using (EditItem editItem = new EditItem())
            {
                editItem.StartPosition = FormStartPosition.Manual;
                int dPosX = (Screen.PrimaryScreen.Bounds.Width / 2) - (editItem.Size.Width / 2);
                int dposY = (Screen.PrimaryScreen.Bounds.Height / 2) - (editItem.Size.Height / 2);
                editItem.Location = new Point(dPosX, dposY);
                if (editItem.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //refresh list
                }

            }
        }
    }
}
