using Caffee.Models;
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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            //Window starts maximized, not resizable and showing taskbar
            int w = Screen.PrimaryScreen.WorkingArea.Width;
            int h = Screen.PrimaryScreen.WorkingArea.Height;
            this.WindowState = FormWindowState.Normal;
            this.Location = new Point(0, 0);
            this.Size =  new Size(w, h);

            //Loading account related data
            LoadAccountData();

            //Side panel settings
            HideSideMenuContent();
            panel_sideMenu.Size = new Size(38, panel_sideMenu.Height);
            /*TO DO: Na kraju projekta da rucno vratim meni na 38px sirinu zbog glitcha na loadovanju stranice.
            Liniju koda iznad ovog komentara se potom moze obrisati*/
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button_hideMenu_Click(object sender, EventArgs e)
        {
            panel_sideMenu.Size = new Size(38, panel_sideMenu.Height);
            button_showMenu.Visible = true;
            button_hideMenu.Visible = false;
            HideSideMenuContent();
        }

        private void button_showMenu_Click(object sender, EventArgs e)
        {
            panel_sideMenu.Size = new Size(216, panel_sideMenu.Height);
            button_showMenu.Visible = false;
            button_hideMenu.Visible = true;
            ShowSideMenuContent();
        }

        private void ShowSideMenuContent()
        {
            button_addTable.Visible = true;
            button_menu.Visible = true;
            button_dailyRecap.Visible = true;
            button_logout.Visible = true;
            pictureBox_accountPicture.Visible = true;
            label_accountUsername.Visible = true;
            label_accountRole.Visible = true;
            panel_accountPanel.BackColor = Color.FromArgb(255, 176, 137, 104);
        }

        private void HideSideMenuContent()
        {
            button_addTable.Visible = false;
            button_menu.Visible = false;
            button_dailyRecap.Visible = false;
            button_logout.Visible = false;
            pictureBox_accountPicture.Visible = false;
            label_accountUsername.Visible = false;
            label_accountRole.Visible = false;
            panel_accountPanel.BackColor = panel_sideMenu.BackColor;

        }

        private void SetAccountDetails(bool isOwner, string username)
        {
            label_accountUsername.Text = username;

            if (isOwner == true)
            {
                label_accountRole.Text = "Owner";
                button_dailyRecap.Enabled = true;
                pictureBox_accountPicture.Image = Properties.Resources.owner;
            }
            else
            {
                label_accountRole.Text = "Waiter";
                button_dailyRecap.Enabled = false;
                pictureBox_accountPicture.Image = Properties.Resources.waiter;
            }
        }

        private void LoadAccountData() //funkciju napisati nakon izrade login forme
        {
            //ucitavanje podataka o ulogovanom korisniku
            //pozivanje funkcije setaccountdetails sa prosledjenim podacima
        }

        private void button_addTable_Click(object sender, EventArgs e)
        {
            TableButton tb = new TableButton();
        }
    }
}
