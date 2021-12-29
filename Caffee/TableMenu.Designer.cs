
namespace Caffee
{
    partial class TableMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableMenu));
            this.header_Panel = new System.Windows.Forms.Panel();
            this.button_close = new System.Windows.Forms.Button();
            this.pictureBox_titlebar_logo = new System.Windows.Forms.PictureBox();
            this.label_title = new System.Windows.Forms.Label();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_Total_Price = new System.Windows.Forms.Label();
            this.header_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_titlebar_logo)).BeginInit();
            this.panel_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // header_Panel
            // 
            this.header_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(65)))), ((int)(((byte)(44)))));
            this.header_Panel.Controls.Add(this.label_title);
            this.header_Panel.Controls.Add(this.pictureBox_titlebar_logo);
            this.header_Panel.Controls.Add(this.button_close);
            this.header_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_Panel.Location = new System.Drawing.Point(0, 0);
            this.header_Panel.Name = "header_Panel";
            this.header_Panel.Size = new System.Drawing.Size(690, 32);
            this.header_Panel.TabIndex = 0;
            // 
            // button_close
            // 
            this.button_close.AccessibleDescription = "";
            this.button_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_close.BackgroundImage")));
            this.button_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Font = new System.Drawing.Font("Microsoft Tai Le", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.button_close.Location = new System.Drawing.Point(644, 0);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(46, 32);
            this.button_close.TabIndex = 2;
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // pictureBox_titlebar_logo
            // 
            this.pictureBox_titlebar_logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_titlebar_logo.BackgroundImage")));
            this.pictureBox_titlebar_logo.Location = new System.Drawing.Point(6, 0);
            this.pictureBox_titlebar_logo.Name = "pictureBox_titlebar_logo";
            this.pictureBox_titlebar_logo.Size = new System.Drawing.Size(32, 32);
            this.pictureBox_titlebar_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_titlebar_logo.TabIndex = 3;
            this.pictureBox_titlebar_logo.TabStop = false;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.label_title.Location = new System.Drawing.Point(40, 6);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(63, 20);
            this.label_title.TabIndex = 5;
            this.label_title.Text = "Orders";
            // 
            // panel_Main
            // 
            this.panel_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(184)))), ((int)(((byte)(146)))));
            this.panel_Main.Controls.Add(this.label_Total_Price);
            this.panel_Main.Controls.Add(this.dataGridView1);
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(0, 32);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(690, 368);
            this.panel_Main.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(666, 186);
            this.dataGridView1.TabIndex = 0;
            // 
            // label_Total_Price
            // 
            this.label_Total_Price.AutoSize = true;
            this.label_Total_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Total_Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(65)))), ((int)(((byte)(44)))));
            this.label_Total_Price.Location = new System.Drawing.Point(8, 210);
            this.label_Total_Price.Name = "label_Total_Price";
            this.label_Total_Price.Size = new System.Drawing.Size(201, 20);
            this.label_Total_Price.TabIndex = 1;
            this.label_Total_Price.Text = "Total price: 736.00 RSD";
            // 
            // TableMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 400);
            this.Controls.Add(this.panel_Main);
            this.Controls.Add(this.header_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TableMenu";
            this.Text = "Order Menu";
            this.Load += new System.EventHandler(this.TableMenu_Load);
            this.header_Panel.ResumeLayout(false);
            this.header_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_titlebar_logo)).EndInit();
            this.panel_Main.ResumeLayout(false);
            this.panel_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header_Panel;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.PictureBox pictureBox_titlebar_logo;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_Total_Price;
    }
}