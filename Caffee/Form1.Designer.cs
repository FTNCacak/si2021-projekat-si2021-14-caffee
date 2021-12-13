
namespace Caffee
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panel_Header = new System.Windows.Forms.Panel();
            this.label_title = new System.Windows.Forms.Label();
            this.pictureBox_titlebar_logo = new System.Windows.Forms.PictureBox();
            this.button_minimize = new System.Windows.Forms.Button();
            this.button_windowed = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel_sideMenu = new System.Windows.Forms.Panel();
            this.button_addTable = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_menu = new System.Windows.Forms.Button();
            this.button_dailyRecap = new System.Windows.Forms.Button();
            this.button_logout = new System.Windows.Forms.Button();
            this.button_hideMenu = new System.Windows.Forms.Button();
            this.button_showMenu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_titlebar_logo)).BeginInit();
            this.panel_sideMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Header
            // 
            this.panel_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(65)))), ((int)(((byte)(44)))));
            this.panel_Header.Controls.Add(this.label_title);
            this.panel_Header.Controls.Add(this.pictureBox_titlebar_logo);
            this.panel_Header.Controls.Add(this.button_minimize);
            this.panel_Header.Controls.Add(this.button_windowed);
            this.panel_Header.Controls.Add(this.button_close);
            this.panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Header.Location = new System.Drawing.Point(0, 0);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(1206, 32);
            this.panel_Header.TabIndex = 0;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.label_title.Location = new System.Drawing.Point(40, 6);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(85, 20);
            this.label_title.TabIndex = 4;
            this.label_title.Text = "MyCaffee";
            // 
            // pictureBox_titlebar_logo
            // 
            this.pictureBox_titlebar_logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_titlebar_logo.BackgroundImage")));
            this.pictureBox_titlebar_logo.Location = new System.Drawing.Point(6, 0);
            this.pictureBox_titlebar_logo.Name = "pictureBox_titlebar_logo";
            this.pictureBox_titlebar_logo.Size = new System.Drawing.Size(32, 32);
            this.pictureBox_titlebar_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_titlebar_logo.TabIndex = 1;
            this.pictureBox_titlebar_logo.TabStop = false;
            // 
            // button_minimize
            // 
            this.button_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_minimize.BackgroundImage")));
            this.button_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_minimize.FlatAppearance.BorderSize = 0;
            this.button_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_minimize.Font = new System.Drawing.Font("Microsoft Tai Le", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_minimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.button_minimize.Location = new System.Drawing.Point(1068, 0);
            this.button_minimize.Name = "button_minimize";
            this.button_minimize.Size = new System.Drawing.Size(46, 32);
            this.button_minimize.TabIndex = 3;
            this.toolTip1.SetToolTip(this.button_minimize, "Minimize");
            this.button_minimize.UseVisualStyleBackColor = true;
            this.button_minimize.Click += new System.EventHandler(this.button_minimize_Click);
            // 
            // button_windowed
            // 
            this.button_windowed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_windowed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_windowed.BackgroundImage")));
            this.button_windowed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_windowed.FlatAppearance.BorderSize = 0;
            this.button_windowed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_windowed.Font = new System.Drawing.Font("Microsoft Tai Le", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_windowed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.button_windowed.Location = new System.Drawing.Point(1114, 0);
            this.button_windowed.Name = "button_windowed";
            this.button_windowed.Size = new System.Drawing.Size(46, 32);
            this.button_windowed.TabIndex = 2;
            this.toolTip1.SetToolTip(this.button_windowed, "Restore Down");
            this.button_windowed.UseVisualStyleBackColor = true;
            // 
            // button_close
            // 
            this.button_close.AccessibleDescription = "";
            this.button_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_close.BackgroundImage")));
            this.button_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Font = new System.Drawing.Font("Microsoft Tai Le", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.button_close.Location = new System.Drawing.Point(1160, 0);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(46, 32);
            this.button_close.TabIndex = 1;
            this.toolTip1.SetToolTip(this.button_close, "Close");
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // panel_sideMenu
            // 
            this.panel_sideMenu.AutoScroll = true;
            this.panel_sideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(102)))), ((int)(((byte)(68)))));
            this.panel_sideMenu.Controls.Add(this.button_logout);
            this.panel_sideMenu.Controls.Add(this.button_dailyRecap);
            this.panel_sideMenu.Controls.Add(this.button_menu);
            this.panel_sideMenu.Controls.Add(this.button_addTable);
            this.panel_sideMenu.Controls.Add(this.panel1);
            this.panel_sideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_sideMenu.Location = new System.Drawing.Point(0, 32);
            this.panel_sideMenu.Name = "panel_sideMenu";
            this.panel_sideMenu.Size = new System.Drawing.Size(216, 652);
            this.panel_sideMenu.TabIndex = 1;
            // 
            // button_addTable
            // 
            this.button_addTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_addTable.FlatAppearance.BorderSize = 0;
            this.button_addTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.button_addTable.Location = new System.Drawing.Point(0, 140);
            this.button_addTable.Name = "button_addTable";
            this.button_addTable.Size = new System.Drawing.Size(216, 39);
            this.button_addTable.TabIndex = 0;
            this.button_addTable.Text = "ADD TABLE";
            this.button_addTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_addTable.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_showMenu);
            this.panel1.Controls.Add(this.button_hideMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 140);
            this.panel1.TabIndex = 0;
            // 
            // button_menu
            // 
            this.button_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_menu.FlatAppearance.BorderSize = 0;
            this.button_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_menu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.button_menu.Location = new System.Drawing.Point(0, 179);
            this.button_menu.Name = "button_menu";
            this.button_menu.Size = new System.Drawing.Size(216, 39);
            this.button_menu.TabIndex = 1;
            this.button_menu.Text = "MENU";
            this.button_menu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_menu.UseVisualStyleBackColor = true;
            // 
            // button_dailyRecap
            // 
            this.button_dailyRecap.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_dailyRecap.FlatAppearance.BorderSize = 0;
            this.button_dailyRecap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_dailyRecap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dailyRecap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.button_dailyRecap.Location = new System.Drawing.Point(0, 218);
            this.button_dailyRecap.Name = "button_dailyRecap";
            this.button_dailyRecap.Size = new System.Drawing.Size(216, 39);
            this.button_dailyRecap.TabIndex = 2;
            this.button_dailyRecap.Text = "DAILY REPORT";
            this.button_dailyRecap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_dailyRecap.UseVisualStyleBackColor = true;
            // 
            // button_logout
            // 
            this.button_logout.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_logout.FlatAppearance.BorderSize = 0;
            this.button_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.button_logout.Location = new System.Drawing.Point(0, 257);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(216, 39);
            this.button_logout.TabIndex = 3;
            this.button_logout.Text = "LOG OUT";
            this.button_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_logout.UseVisualStyleBackColor = true;
            // 
            // button_hideMenu
            // 
            this.button_hideMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_hideMenu.BackgroundImage")));
            this.button_hideMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_hideMenu.FlatAppearance.BorderSize = 0;
            this.button_hideMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_hideMenu.Location = new System.Drawing.Point(173, 0);
            this.button_hideMenu.Name = "button_hideMenu";
            this.button_hideMenu.Size = new System.Drawing.Size(38, 38);
            this.button_hideMenu.TabIndex = 0;
            this.button_hideMenu.UseVisualStyleBackColor = true;
            this.button_hideMenu.Click += new System.EventHandler(this.button_hideMenu_Click);
            // 
            // button_showMenu
            // 
            this.button_showMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_showMenu.BackgroundImage")));
            this.button_showMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_showMenu.FlatAppearance.BorderSize = 0;
            this.button_showMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_showMenu.Location = new System.Drawing.Point(0, 0);
            this.button_showMenu.Name = "button_showMenu";
            this.button_showMenu.Size = new System.Drawing.Size(38, 38);
            this.button_showMenu.TabIndex = 1;
            this.button_showMenu.UseVisualStyleBackColor = true;
            this.button_showMenu.Click += new System.EventHandler(this.button_showMenu_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(216, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(990, 652);
            this.panel2.TabIndex = 2;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 684);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_sideMenu);
            this.Controls.Add(this.panel_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.Text = "MyCaffee";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panel_Header.ResumeLayout(false);
            this.panel_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_titlebar_logo)).EndInit();
            this.panel_sideMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Header;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_windowed;
        private System.Windows.Forms.Button button_minimize;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox_titlebar_logo;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Panel panel_sideMenu;
        private System.Windows.Forms.Button button_addTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Button button_dailyRecap;
        private System.Windows.Forms.Button button_menu;
        private System.Windows.Forms.Button button_hideMenu;
        private System.Windows.Forms.Button button_showMenu;
        private System.Windows.Forms.Panel panel2;
    }
}

