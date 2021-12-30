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
            InitializeColumns();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitializeColumns()
        {
            /*dataGridView_menuItems.ColumnCount = 2;
            dataGridView_menuItems.Columns[0].Name = "Item name";
            dataGridView_menuItems.Columns[1].Name = "Price";
            dataGridView_menuItems.Columns[1].FillWeight = 20;*/

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
            //temporary test data for design p
        }

        private void dataGridView_menuItems_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
            e.CellStyle.SelectionBackColor = Color.FromArgb(255, 230, 204, 178);
            e.CellStyle.SelectionForeColor = Color.FromArgb(255, 99, 65, 44);
        }
    }
}
