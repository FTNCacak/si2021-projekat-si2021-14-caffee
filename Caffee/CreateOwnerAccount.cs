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
    public partial class CreateOwnerAccount : Form
    {
        public CreateOwnerAccount()
        {
            InitializeComponent();
            //proveravanje da li vec postoji vlasnicki nalog
            //ako ne postoji, nista se ne desava,ova forma se normalno pokrece
            //ako postoji, otvara se sledeca forma za login 
            //ova forma se inace otvara samo jednom i to po instalaciji programa
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonCreateOwnerAcc_Click(object sender, EventArgs e)
        {
            //validiraju se textboxovi
            //login informacije se upisuju u eksterni fajl
            //obavestenje da je uspesno kreiran nalog za vlasnika
            //prelazi se na sledecu formu (ovo ispod)
            var cwa = new CreateWaiterAccount();
            cwa.Closed += (s, args) => this.Close();
            this.Hide();
            cwa.Show();
        }
    }
}
