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

            //Side panel settings
            HideSideMenuButtons();
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
            HideSideMenuButtons();
        }

        private void button_showMenu_Click(object sender, EventArgs e)
        {
            panel_sideMenu.Size = new Size(216, panel_sideMenu.Height);
            button_showMenu.Visible = false;
            button_hideMenu.Visible = true;
            ShowSideMenuButtons();
        }

        private void ShowSideMenuButtons()
        {
            button_addTable.Visible = true;
            button_menu.Visible = true;
            button_dailyRecap.Visible = true;
            button_logout.Visible = true;
        }

        private void HideSideMenuButtons()
        {
            button_addTable.Visible = false;
            button_menu.Visible = false;
            button_dailyRecap.Visible = false;
            button_logout.Visible = false;
        }
    }
}
