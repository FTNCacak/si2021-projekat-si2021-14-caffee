using CaffeBusiness;
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
        private readonly ItemBusiness itemBusiness = new ItemBusiness();
        private readonly OrderItemBusiness orderItemBusiness = new OrderItemBusiness();
        private int idTable;
        private int billNumber;
        public TableMenu(int idTable,int billNumber)
        {
            this.idTable = idTable; 
            InitializeComponent();
            this.billNumber = billNumber;   
        }

        private void TableMenu_Load(object sender, EventArgs e)
        {
            
            foreach(Item item in itemBusiness.getAllItems())
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
            string comboItem=comboBox_Article.Text; 
            int ammount = Convert.ToInt32(numericUpDown_Amount.Value);
            numericUpDown_Amount.Value = 1;
            comboBox_Article.SelectedIndex = -1;
            int itemId = itemBusiness.GetIdOfItemName(comboItem);
            decimal itemPrice = itemBusiness.GetPriceOfItem(comboItem);
            if(itemId != 0)
            {
                OrderItem orderItem = new OrderItem(billNumber, itemId, ammount); 
                orderItemBusiness.insertOrderItem(orderItem);
            }

            
        }
    }
}
