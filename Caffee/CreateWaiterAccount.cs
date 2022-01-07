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
    public partial class CreateWaiterAccount : Form
    {
        public CreateWaiterAccount()
        {
            InitializeComponent();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonCreateOwnerAcc_Click(object sender, EventArgs e)
        {
            //upisivanje u fajl za konobare
            //prikazivanje infoboxa da je uspesno kreiran konobar i pitanje da li zelimo da dodamo jos (yes no dialog)
            //yes --> ciscenje textboxova i dodavanje jos jednog konobara
            //no --> prelazak na login formu
            //ciscenje texboxova
            string Passwordpattern = "@^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,20}$";
            string Userpattern = "@^[a-zA-Z0-9]([._-](?![._-])|[a-zA-Z0-9]){4,20}[a-zA-Z0-9]$";

            Match match = Regex.Match(Userpattern, textBoxUserName.Text);
            if (match.Success && textBoxUserName.Text != string.Empty)
            {

            }
            match = Regex.Match(Passwordpattern, textBoxPassword.Text);
            if (match.Success && textBoxUserName.Text != string.Empty)
            {

            }
            match = Regex.Match(Passwordpattern, textBoxConfirmPassword.Text);
            if (match.Success && textBoxUserName.Text != string.Empty && textBoxPassword.Text == textBoxConfirmPassword.Text)
            {

            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            //gasenje ove forme i prelazak na login formu
            var lgn = new Login();
            lgn.Closed += (s, args) => this.Close();
            this.Hide();
            lgn.Show();
        }
    }
}
