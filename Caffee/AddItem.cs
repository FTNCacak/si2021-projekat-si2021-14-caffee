using CaffeBusiness;
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
    public partial class AddItem : Form
    {
        private readonly ItemBusiness itemBusiness = new ItemBusiness();
        public AddItem()
        {
            InitializeComponent();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            item.Name = textBoxItemName.Text;
            item.Price = decimal.Parse(textBoxItemPrice.Text);
            itemBusiness.insertItem(item);
        }
    }
}
