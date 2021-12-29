
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableMenu));
            this.header_Panel = new System.Windows.Forms.Panel();
            this.label_title = new System.Windows.Forms.Label();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.label_Total_Price = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_Article = new System.Windows.Forms.ComboBox();
            this.label_article = new System.Windows.Forms.Label();
            this.label_articleQuantity = new System.Windows.Forms.Label();
            this.numericUpDown_Amount = new System.Windows.Forms.NumericUpDown();
            this.button_AddToOrder = new System.Windows.Forms.Button();
            this.button_Charge = new System.Windows.Forms.Button();
            this.pictureBox_titlebar_logo = new System.Windows.Forms.PictureBox();
            this.button_close = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.header_Panel.SuspendLayout();
            this.panel_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_titlebar_logo)).BeginInit();
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
            this.header_Panel.Size = new System.Drawing.Size(634, 32);
            this.header_Panel.TabIndex = 0;
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
            this.panel_Main.Controls.Add(this.button_Charge);
            this.panel_Main.Controls.Add(this.groupBox1);
            this.panel_Main.Controls.Add(this.label_Total_Price);
            this.panel_Main.Controls.Add(this.dataGridView1);
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(0, 32);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(634, 376);
            this.panel_Main.TabIndex = 1;
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
            this.toolTip1.SetToolTip(this.label_Total_Price, "Total price of the order.");
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(610, 186);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_AddToOrder);
            this.groupBox1.Controls.Add(this.numericUpDown_Amount);
            this.groupBox1.Controls.Add(this.label_articleQuantity);
            this.groupBox1.Controls.Add(this.label_article);
            this.groupBox1.Controls.Add(this.comboBox_Article);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(65)))), ((int)(((byte)(44)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 247);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 74);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADD NEW ARTICLE TO ORDER";
            // 
            // comboBox_Article
            // 
            this.comboBox_Article.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.comboBox_Article.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Article.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(65)))), ((int)(((byte)(44)))));
            this.comboBox_Article.FormattingEnabled = true;
            this.comboBox_Article.Location = new System.Drawing.Point(77, 32);
            this.comboBox_Article.Name = "comboBox_Article";
            this.comboBox_Article.Size = new System.Drawing.Size(153, 28);
            this.comboBox_Article.TabIndex = 0;
            this.toolTip1.SetToolTip(this.comboBox_Article, "Name of article");
            // 
            // label_article
            // 
            this.label_article.AutoSize = true;
            this.label_article.Location = new System.Drawing.Point(6, 35);
            this.label_article.Name = "label_article";
            this.label_article.Size = new System.Drawing.Size(65, 20);
            this.label_article.TabIndex = 1;
            this.label_article.Text = "Article:";
            // 
            // label_articleQuantity
            // 
            this.label_articleQuantity.AutoSize = true;
            this.label_articleQuantity.Location = new System.Drawing.Point(253, 35);
            this.label_articleQuantity.Name = "label_articleQuantity";
            this.label_articleQuantity.Size = new System.Drawing.Size(76, 20);
            this.label_articleQuantity.TabIndex = 2;
            this.label_articleQuantity.Text = "Amount:";
            // 
            // numericUpDown_Amount
            // 
            this.numericUpDown_Amount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.numericUpDown_Amount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(65)))), ((int)(((byte)(44)))));
            this.numericUpDown_Amount.Location = new System.Drawing.Point(335, 33);
            this.numericUpDown_Amount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Amount.Name = "numericUpDown_Amount";
            this.numericUpDown_Amount.Size = new System.Drawing.Size(67, 26);
            this.numericUpDown_Amount.TabIndex = 3;
            this.toolTip1.SetToolTip(this.numericUpDown_Amount, "Quantity of article");
            this.numericUpDown_Amount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_AddToOrder
            // 
            this.button_AddToOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(102)))), ((int)(((byte)(68)))));
            this.button_AddToOrder.FlatAppearance.BorderSize = 0;
            this.button_AddToOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddToOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.button_AddToOrder.Location = new System.Drawing.Point(429, 28);
            this.button_AddToOrder.Name = "button_AddToOrder";
            this.button_AddToOrder.Size = new System.Drawing.Size(170, 35);
            this.button_AddToOrder.TabIndex = 4;
            this.button_AddToOrder.Text = "ADD TO ORDER";
            this.toolTip1.SetToolTip(this.button_AddToOrder, "Add item to order list.");
            this.button_AddToOrder.UseVisualStyleBackColor = false;
            // 
            // button_Charge
            // 
            this.button_Charge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(102)))), ((int)(((byte)(68)))));
            this.button_Charge.FlatAppearance.BorderSize = 0;
            this.button_Charge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Charge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Charge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.button_Charge.Location = new System.Drawing.Point(441, 329);
            this.button_Charge.Name = "button_Charge";
            this.button_Charge.Size = new System.Drawing.Size(170, 35);
            this.button_Charge.TabIndex = 5;
            this.button_Charge.Text = "CHARGE";
            this.toolTip1.SetToolTip(this.button_Charge, "Bill customers.");
            this.button_Charge.UseVisualStyleBackColor = false;
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
            this.button_close.Location = new System.Drawing.Point(588, 0);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(46, 32);
            this.button_close.TabIndex = 2;
            this.toolTip1.SetToolTip(this.button_close, "Close");
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // TableMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 408);
            this.Controls.Add(this.panel_Main);
            this.Controls.Add(this.header_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TableMenu";
            this.Text = "Order Menu";
            this.Load += new System.EventHandler(this.TableMenu_Load);
            this.header_Panel.ResumeLayout(false);
            this.header_Panel.PerformLayout();
            this.panel_Main.ResumeLayout(false);
            this.panel_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_titlebar_logo)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_AddToOrder;
        private System.Windows.Forms.NumericUpDown numericUpDown_Amount;
        private System.Windows.Forms.Label label_articleQuantity;
        private System.Windows.Forms.Label label_article;
        private System.Windows.Forms.ComboBox comboBox_Article;
        private System.Windows.Forms.Button button_Charge;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}