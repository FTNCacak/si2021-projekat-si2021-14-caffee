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
    public partial class EditItem : Form
    {
        public EditItem()
        {
            InitializeComponent();
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            //updating database
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
