﻿using CaffeBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace Caffee
{
    public partial class EditItem : Form
    {
        private string ItemName;
        private decimal Price;
        private int Id;
        private readonly ItemBusiness itemBusiness = new ItemBusiness();
        public EditItem(string ItemName, decimal Prices,int Id)
        {
            this.ItemName = ItemName; 
            Price = Prices;
            this.Id = Id;
            InitializeComponent();

        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            string Itemnamepattern = "@^[a-zA-Z]([a-zA-Z0-9]){3,20}$";
            Match match = Regex.Match(Itemnamepattern, textBoxItemName.Text);
            if (match.Success && Convert.ToDecimal(textBoxItemPrice.Text) > 0)
            {
                itemBusiness.updatePrice(Id, Price = Convert.ToDecimal(textBoxItemPrice.Text), ItemName = textBoxItemName.Text);
            }
            
            
            
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditLoad(object sender, EventArgs e)
        {
            textBoxItemName.Text = this.ItemName;
            textBoxItemPrice.Text = this.Price.ToString();
        }
    }
}
