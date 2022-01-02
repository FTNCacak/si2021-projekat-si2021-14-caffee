using CaffeeData;
using CaffeeData.Models;
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
    public partial class TableMenu : Form
    {
        private readonly ItemRepository itemRepository = new ItemRepository();
        public TableMenu()
        {
            InitializeComponent();
        }

        private void TableMenu_Load(object sender, EventArgs e)
        {
            
            foreach(Item item in itemRepository.GetAllItems())
            {
                comboBox_Article.Items.Add(item.Name);
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button_AddToOrder_Click(object sender, EventArgs e)
        {
            
        }
    }
}
