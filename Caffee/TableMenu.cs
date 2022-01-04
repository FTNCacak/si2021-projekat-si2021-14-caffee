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
using System.IO;
namespace Caffee
{
    public partial class TableMenu : Form
    {
        private readonly ItemBusiness itemBusiness = new ItemBusiness();
        private readonly BillBusiness billBusiness = new BillBusiness();    
        private readonly OrderItemBusiness orderItemBusiness = new OrderItemBusiness();
        private readonly TableBusiness tableBusiness = new TableBusiness(); 
        private int idTable;
        public TableMenu(int idTable)
        {
            this.idTable = idTable; 
            InitializeComponent();
              
        }

        private void TableMenu_Load(object sender, EventArgs e)
        {
            dataGridViewOrders.ColumnCount = 2;
            dataGridViewOrders.Columns[0].Name = "Item name";
            dataGridViewOrders.Columns[1].Name = "Ammount"; 
            foreach (Item item in itemBusiness.getAllItems())
            {
                comboBox_Article.Items.Add(item.Name);
            }
            List<string> all = new List<string>();
            all = File.ReadAllLines(@"C:\Users\pajo\Desktop\Astali\" + "Sto" + this.idTable + ".txt").ToList();

            foreach (string item in all)
            {
                string[] items = item.Split('+');
                dataGridViewOrders.Rows.Add(items[0], items[1]);
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
            
            using(StreamWriter streamWriter = new StreamWriter(@"C:\Users\pajo\Desktop\Astali\" + "Sto" + this.idTable + ".txt",append:true))
            {
                streamWriter.WriteLine(comboItem+"+"+ammount);
            }
            dataGridViewOrders.Rows.Add(comboItem,ammount);
            

            //bool occupied = false;

            //foreach (Table table in tableBusiness.getAllTables())
            //{
            //    if(table.Id == idTable)
            //    {
            //        occupied = table.Occupied;
            //    }
            //}

            //if (occupied == false)
            //{
            //    Bill bill = new Bill(idTable);
            //    billBusiness.insertBill(bill);
            //    IfTableExitsBillId =  bill.Id = billBusiness.getAllBills().Last().Id;
            //    OrderItem orderItem = new OrderItem(bill.Id, itemBusiness.GetIdOfItemName(comboItem), ammount);
            //    orderItemBusiness.insertOrderItem(orderItem);
            //}
            //else
            //{
            //    OrderItem orderItem = new OrderItem(IfTableExitsBillId, itemBusiness.GetIdOfItemName(comboItem), ammount);
            //    orderItemBusiness.insertOrderItem(orderItem);
            //}


            //Bill bill = new Bill(idTable);
            //billBusiness.insertBill(bill);
            //bill.Id=billBusiness.getAllBills().Last().Id;
            //OrderItem orderItem = new OrderItem(bill.Id,itemBusiness.GetIdOfItemName(comboItem),ammount);
            //Console.WriteLine(bill.Id+" "+ itemBusiness.GetIdOfItemName(comboItem) + " " + ammount);
            //orderItemBusiness.insertOrderItem(orderItem);



        }

        private void button_Charge_Click(object sender, EventArgs e)
        {
            
        }
    }
}
