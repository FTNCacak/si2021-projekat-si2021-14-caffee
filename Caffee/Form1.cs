using CaffeBusiness;
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
        private readonly BillBusiness billBusiness = new BillBusiness();
        private readonly TableBusiness tableBusiness = new TableBusiness();

        ToolTip tableToolTip = new ToolTip();
        public MainWindow()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
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
            Linija koda iznad ovog komentara se potom moze obrisati*/

            if(tableBusiness.getAllTables().Count > 0)
            {
                foreach(Table table in tableBusiness.getAllTables())
                {
                    TableButton tb = new TableButton();
                    tb.id = table.Id;
                    tb.Location = new Point(table.position_w, table.position_h);
                    tableToolTip.SetToolTip(tb, "Drag to move.\nRight-click to remove.");
                    panelFloor.Controls.Add(tb);
                    
                }
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            foreach (Table table in tableBusiness.getAllTables())
            {
                tableBusiness.updateTable(table.Id,table.position_w,table.position_h);

            }
            this.Close(); //ovo da pogledam jos jednom da vidim da li se ovako gasi aplikacija
            //application.exit je -----da promenim na kraju
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
                pictureBox_accountPicture.BackgroundImage = Properties.Resources.owner;
            }
            else
            {
                label_accountRole.Text = "Waiter";
                button_dailyRecap.Enabled = false;
                pictureBox_accountPicture.BackgroundImage = Properties.Resources.waiter;
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
            tb.Location = new Point(panelFloor.Width / 2, panelFloor.Height / 2);
            Table table = new Table();
            table.Occupied = false;
            table.position_h = panelFloor.Height / 2;
            table.position_w= panelFloor.Width / 2;
            tableBusiness.insertTable(table);
            tb.id = tableBusiness.getAllTables().Last().Id;
            tableToolTip.SetToolTip(tb, "Drag to move.\nRight-click to remove.");
            panelFloor.Controls.Add(tb);

        }

        private void button_menu_Click(object sender, EventArgs e)
        {
            MenuSettings ms = new MenuSettings();
            ms.StartPosition = FormStartPosition.Manual;
            int dPosX = (Screen.PrimaryScreen.Bounds.Width / 2) - (ms.Size.Width / 2);
            int dposY = (Screen.PrimaryScreen.Bounds.Height / 2) - (ms.Size.Height / 2);
            ms.Location = new Point(dPosX, dposY);
            ms.ShowDialog(); //ShowDialog()se gasi sa Dispose()               
        }
    }
}
