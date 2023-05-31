namespace ThinkCE_Store_Management_System.UI.Auth
{
    partial class Main_Users_Auth_UI
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.addUserMenuBtn = new Guna.UI2.WinForms.Guna2Button();
            this.detailsUserMenuBtn = new Guna.UI2.WinForms.Guna2Button();
            this.childFormPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.sqLiteCommandBuilder1 = new System.Data.SQLite.SQLiteCommandBuilder();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.guna2Panel1.Controls.Add(this.addUserMenuBtn);
            this.guna2Panel1.Controls.Add(this.detailsUserMenuBtn);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1000, 61);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // addUserMenuBtn
            // 
            this.addUserMenuBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addUserMenuBtn.BackColor = System.Drawing.Color.Transparent;
            this.addUserMenuBtn.BorderColor = System.Drawing.Color.Navy;
            this.addUserMenuBtn.BorderRadius = 15;
            this.addUserMenuBtn.BorderThickness = 1;
            this.addUserMenuBtn.CheckedState.Parent = this.addUserMenuBtn;
            this.addUserMenuBtn.CustomImages.Parent = this.addUserMenuBtn;
            this.addUserMenuBtn.FillColor = System.Drawing.Color.Transparent;
            this.addUserMenuBtn.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserMenuBtn.ForeColor = System.Drawing.Color.Navy;
            this.addUserMenuBtn.HoverState.Parent = this.addUserMenuBtn;
            this.addUserMenuBtn.Location = new System.Drawing.Point(802, 27);
            this.addUserMenuBtn.Name = "addUserMenuBtn";
            this.addUserMenuBtn.ShadowDecoration.Parent = this.addUserMenuBtn;
            this.addUserMenuBtn.Size = new System.Drawing.Size(90, 45);
            this.addUserMenuBtn.TabIndex = 1;
            this.addUserMenuBtn.Text = "Add";
            this.addUserMenuBtn.Click += new System.EventHandler(this.addUserMenuBtn_Click);
            // 
            // detailsUserMenuBtn
            // 
            this.detailsUserMenuBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.detailsUserMenuBtn.BackColor = System.Drawing.Color.Transparent;
            this.detailsUserMenuBtn.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.detailsUserMenuBtn.BorderRadius = 15;
            this.detailsUserMenuBtn.BorderThickness = 1;
            this.detailsUserMenuBtn.CheckedState.Parent = this.detailsUserMenuBtn;
            this.detailsUserMenuBtn.CustomImages.Parent = this.detailsUserMenuBtn;
            this.detailsUserMenuBtn.FillColor = System.Drawing.Color.Transparent;
            this.detailsUserMenuBtn.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsUserMenuBtn.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.detailsUserMenuBtn.HoverState.Parent = this.detailsUserMenuBtn;
            this.detailsUserMenuBtn.Location = new System.Drawing.Point(898, 27);
            this.detailsUserMenuBtn.Name = "detailsUserMenuBtn";
            this.detailsUserMenuBtn.ShadowDecoration.Parent = this.detailsUserMenuBtn;
            this.detailsUserMenuBtn.Size = new System.Drawing.Size(90, 45);
            this.detailsUserMenuBtn.TabIndex = 0;
            this.detailsUserMenuBtn.Text = "Details";
            this.detailsUserMenuBtn.Click += new System.EventHandler(this.detailsUserMenuBtn_Click);
            // 
            // childFormPanel
            // 
            this.childFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childFormPanel.Location = new System.Drawing.Point(0, 61);
            this.childFormPanel.Name = "childFormPanel";
            this.childFormPanel.ShadowDecoration.Parent = this.childFormPanel;
            this.childFormPanel.Size = new System.Drawing.Size(1000, 467);
            this.childFormPanel.TabIndex = 1;
            this.childFormPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.childFormPanel_Paint);
            // 
            // sqLiteCommandBuilder1
            // 
            this.sqLiteCommandBuilder1.DataAdapter = null;
            this.sqLiteCommandBuilder1.QuoteSuffix = "]";
            // 
            // Main_Users_Auth_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 528);
            this.Controls.Add(this.childFormPanel);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main_Users_Auth_UI";
            this.Text = "Main_Users_Auth_UI";
            this.Load += new System.EventHandler(this.Main_Users_Auth_UI_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button detailsUserMenuBtn;
        private Guna.UI2.WinForms.Guna2Button addUserMenuBtn;
        private Guna.UI2.WinForms.Guna2Panel childFormPanel;
        private System.Data.SQLite.SQLiteCommandBuilder sqLiteCommandBuilder1;
    }
}