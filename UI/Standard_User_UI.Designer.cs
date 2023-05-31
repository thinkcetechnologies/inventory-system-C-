namespace ThinkCE_Store_Management_System.UI
{
    partial class Standard_User_UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Standard_User_UI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.stockMenuBtn = new FontAwesome.Sharp.IconButton();
            this.salesBtn = new FontAwesome.Sharp.IconButton();
            this.transactionMenuBtn = new FontAwesome.Sharp.IconButton();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.userName = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.synTxt = new System.Windows.Forms.Label();
            this.syncBtn = new FontAwesome.Sharp.IconButton();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.openFormTitle = new System.Windows.Forms.Label();
            this.childFormPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScrollMargin = new System.Drawing.Size(1, 0);
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.stockMenuBtn);
            this.panel1.Controls.Add(this.salesBtn);
            this.panel1.Controls.Add(this.transactionMenuBtn);
            this.panel1.Controls.Add(this.guna2GradientPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 572);
            this.panel1.TabIndex = 3;
            // 
            // stockMenuBtn
            // 
            this.stockMenuBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.stockMenuBtn.FlatAppearance.BorderSize = 2;
            this.stockMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockMenuBtn.ForeColor = System.Drawing.Color.White;
            this.stockMenuBtn.IconChar = FontAwesome.Sharp.IconChar.ShoppingBasket;
            this.stockMenuBtn.IconColor = System.Drawing.Color.White;
            this.stockMenuBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.stockMenuBtn.IconSize = 24;
            this.stockMenuBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stockMenuBtn.Location = new System.Drawing.Point(43, 103);
            this.stockMenuBtn.Name = "stockMenuBtn";
            this.stockMenuBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.stockMenuBtn.Size = new System.Drawing.Size(180, 36);
            this.stockMenuBtn.TabIndex = 18;
            this.stockMenuBtn.Text = "     Stock";
            this.stockMenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stockMenuBtn.UseVisualStyleBackColor = true;
            this.stockMenuBtn.Click += new System.EventHandler(this.stockMenuBtn_Click);
            // 
            // salesBtn
            // 
            this.salesBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.salesBtn.FlatAppearance.BorderSize = 2;
            this.salesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesBtn.ForeColor = System.Drawing.Color.White;
            this.salesBtn.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.salesBtn.IconColor = System.Drawing.Color.White;
            this.salesBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.salesBtn.IconSize = 24;
            this.salesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salesBtn.Location = new System.Drawing.Point(43, 162);
            this.salesBtn.Name = "salesBtn";
            this.salesBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.salesBtn.Size = new System.Drawing.Size(180, 36);
            this.salesBtn.TabIndex = 15;
            this.salesBtn.Text = "     Sales";
            this.salesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salesBtn.UseVisualStyleBackColor = true;
            this.salesBtn.Click += new System.EventHandler(this.salesBtn_Click);
            // 
            // transactionMenuBtn
            // 
            this.transactionMenuBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.transactionMenuBtn.FlatAppearance.BorderSize = 2;
            this.transactionMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transactionMenuBtn.ForeColor = System.Drawing.Color.White;
            this.transactionMenuBtn.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.transactionMenuBtn.IconColor = System.Drawing.Color.White;
            this.transactionMenuBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.transactionMenuBtn.IconSize = 24;
            this.transactionMenuBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transactionMenuBtn.Location = new System.Drawing.Point(43, 217);
            this.transactionMenuBtn.Name = "transactionMenuBtn";
            this.transactionMenuBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.transactionMenuBtn.Size = new System.Drawing.Size(180, 38);
            this.transactionMenuBtn.TabIndex = 12;
            this.transactionMenuBtn.Text = "     Transactions";
            this.transactionMenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transactionMenuBtn.UseVisualStyleBackColor = true;
            this.transactionMenuBtn.Click += new System.EventHandler(this.transactionMenuBtn_Click);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.guna2PictureBox2);
            this.guna2GradientPanel1.Controls.Add(this.userName);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(26)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(26)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(194, 63);
            this.guna2GradientPanel1.TabIndex = 9;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2PictureBox2.Image = global::ThinkCE_Store_Management_System.Properties.Resources.worker100;
            this.guna2PictureBox2.Location = new System.Drawing.Point(-27, -15);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(101, 71);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 3;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.BackColor = System.Drawing.Color.Transparent;
            this.userName.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.ForeColor = System.Drawing.Color.White;
            this.userName.Location = new System.Drawing.Point(80, 3);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(67, 25);
            this.userName.TabIndex = 13;
            this.userName.Text = "Afari";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.guna2Panel2.BorderColor = System.Drawing.Color.Teal;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.synTxt);
            this.guna2Panel2.Controls.Add(this.syncBtn);
            this.guna2Panel2.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel2.Controls.Add(this.openFormTitle);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(194, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(857, 35);
            this.guna2Panel2.TabIndex = 7;
            // 
            // synTxt
            // 
            this.synTxt.AutoSize = true;
            this.synTxt.BackColor = System.Drawing.Color.Transparent;
            this.synTxt.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.synTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.synTxt.Location = new System.Drawing.Point(579, 8);
            this.synTxt.Name = "synTxt";
            this.synTxt.Size = new System.Drawing.Size(54, 23);
            this.synTxt.TabIndex = 6;
            this.synTxt.Text = "Afari";
            // 
            // syncBtn
            // 
            this.syncBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.syncBtn.BackColor = System.Drawing.Color.White;
            this.syncBtn.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.syncBtn.IconColor = System.Drawing.Color.Black;
            this.syncBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.syncBtn.IconSize = 20;
            this.syncBtn.Location = new System.Drawing.Point(776, 6);
            this.syncBtn.Name = "syncBtn";
            this.syncBtn.Size = new System.Drawing.Size(33, 26);
            this.syncBtn.TabIndex = 5;
            this.syncBtn.UseVisualStyleBackColor = false;
            this.syncBtn.Click += new System.EventHandler(this.syncBtn_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guna2PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2PictureBox1.Image = global::ThinkCE_Store_Management_System.Properties.Resources.logout100;
            this.guna2PictureBox1.Location = new System.Drawing.Point(815, 7);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(30, 24);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // openFormTitle
            // 
            this.openFormTitle.AutoSize = true;
            this.openFormTitle.BackColor = System.Drawing.Color.Transparent;
            this.openFormTitle.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.openFormTitle.Location = new System.Drawing.Point(18, 9);
            this.openFormTitle.Name = "openFormTitle";
            this.openFormTitle.Size = new System.Drawing.Size(54, 23);
            this.openFormTitle.TabIndex = 4;
            this.openFormTitle.Text = "Afari";
            // 
            // childFormPanel
            // 
            this.childFormPanel.BackColor = System.Drawing.Color.White;
            this.childFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childFormPanel.Location = new System.Drawing.Point(194, 35);
            this.childFormPanel.Name = "childFormPanel";
            this.childFormPanel.Size = new System.Drawing.Size(857, 537);
            this.childFormPanel.TabIndex = 8;
            // 
            // Standard_User_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 572);
            this.Controls.Add(this.childFormPanel);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Standard_User_UI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Person Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Standard_User_UI_FormClosed);
            this.Load += new System.EventHandler(this.Standard_User_UI_Load);
            this.panel1.ResumeLayout(false);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton stockMenuBtn;
        private FontAwesome.Sharp.IconButton salesBtn;
        private FontAwesome.Sharp.IconButton transactionMenuBtn;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Label userName;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label synTxt;
        private FontAwesome.Sharp.IconButton syncBtn;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label openFormTitle;
        private System.Windows.Forms.Panel childFormPanel;
    }
}