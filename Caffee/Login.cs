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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //provera unetih podataka
            //ako je konobar ide se u glavni prozor
            //ako je vlasnik ide se na sledecu formu(ovo ispod)
            var cw = new ChooseWindow();
            cw.Closed += (s, args) => this.Close();
            this.Hide();
            cw.Show();
        }
    }
}
