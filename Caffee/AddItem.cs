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

            //OVDE SE VRSI UNOS U BAZU PODATAKA

            //TESTNI KOD
            /*string itnm = textBoxItemName.Text;
            decimal itpc = Convert.ToDecimal(textBoxItemPrice.Text);
            Console.WriteLine("Naziv artikla: " + itnm + "\nCena artikla: " + itpc);*/
        }
    }
}
