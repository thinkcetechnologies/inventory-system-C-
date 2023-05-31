namespace ThinkCE_Store_Management_System.UI.Products
{
    partial class Products_Dashboard_UI
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
            this.addProductBtn = new Guna.UI2.WinForms.Guna2Button();
            this.detailsProductsMenuBtn = new Guna.UI2.WinForms.Guna2Button();
            this.childFormPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.lableTxt = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.guna2Panel1.Controls.Add(this.lableTxt);
            this.guna2Panel1.Controls.Add(this.addProductBtn);
            this.guna2Panel1.Controls.Add(this.detailsProductsMenuBtn);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(997, 61);
            this.guna2Panel1.TabIndex = 1;
            // 
            // addProductBtn
            // 
            this.addProductBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addProductBtn.BackColor = System.Drawing.Color.Transparent;
            this.addProductBtn.BorderColor = System.Drawing.Color.Navy;
            this.addProductBtn.BorderRadius = 15;
            this.addProductBtn.BorderThickness = 1;
            this.addProductBtn.CheckedState.Parent = this.addProductBtn;
            this.addProductBtn.CustomImages.Parent = this.addProductBtn;
            this.addProductBtn.FillColor = System.Drawing.Color.Transparent;
            this.addProductBtn.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductBtn.ForeColor = System.Drawing.Color.Navy;
            this.addProductBtn.HoverState.Parent = this.addProductBtn;
            this.addProductBtn.Location = new System.Drawing.Point(799, 27);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.ShadowDecoration.Parent = this.addProductBtn;
            this.addProductBtn.Size = new System.Drawing.Size(90, 45);
            this.addProductBtn.TabIndex = 2;
            this.addProductBtn.Text = "Add";
            this.addProductBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // detailsProductsMenuBtn
            // 
            this.detailsProductsMenuBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.detailsProductsMenuBtn.BackColor = System.Drawing.Color.Transparent;
            this.detailsProductsMenuBtn.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.detailsProductsMenuBtn.BorderRadius = 15;
            this.detailsProductsMenuBtn.BorderThickness = 1;
            this.detailsProductsMenuBtn.CheckedState.Parent = this.detailsProductsMenuBtn;
            this.detailsProductsMenuBtn.CustomImages.Parent = this.detailsProductsMenuBtn;
            this.detailsProductsMenuBtn.FillColor = System.Drawing.Color.Transparent;
            this.detailsProductsMenuBtn.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsProductsMenuBtn.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.detailsProductsMenuBtn.HoverState.Parent = this.detailsProductsMenuBtn;
            this.detailsProductsMenuBtn.Location = new System.Drawing.Point(895, 27);
            this.detailsProductsMenuBtn.Name = "detailsProductsMenuBtn";
            this.detailsProductsMenuBtn.ShadowDecoration.Parent = this.detailsProductsMenuBtn;
            this.detailsProductsMenuBtn.Size = new System.Drawing.Size(90, 45);
            this.detailsProductsMenuBtn.TabIndex = 0;
            this.detailsProductsMenuBtn.Text = "Details";
            this.detailsProductsMenuBtn.Click += new System.EventHandler(this.detailsProductsMenuBtn_Click);
            // 
            // childFormPanel
            // 
            this.childFormPanel.BackColor = System.Drawing.Color.White;
            this.childFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childFormPanel.Location = new System.Drawing.Point(0, 61);
            this.childFormPanel.Name = "childFormPanel";
            this.childFormPanel.ShadowDecoration.Parent = this.childFormPanel;
            this.childFormPanel.Size = new System.Drawing.Size(997, 409);
            this.childFormPanel.TabIndex = 2;
            // 
            // lableTxt
            // 
            this.lableTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lableTxt.AutoSize = true;
            this.lableTxt.BackColor = System.Drawing.Color.Transparent;
            this.lableTxt.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableTxt.ForeColor = System.Drawing.Color.Navy;
            this.lableTxt.Location = new System.Drawing.Point(116, 27);
            this.lableTxt.Name = "lableTxt";
            this.lableTxt.Size = new System.Drawing.Size(107, 23);
            this.lableTxt.TabIndex = 21;
            this.lableTxt.Text = "Cost Price";
            // 
            // Products_Dashboard_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 470);
            this.Controls.Add(this.childFormPanel);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Products_Dashboard_UI";
            this.Text = "Products_Dashboard_UI";
            this.Load += new System.EventHandler(this.Products_Dashboard_UI_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button detailsProductsMenuBtn;
        private Guna.UI2.WinForms.Guna2Panel childFormPanel;
        private Guna.UI2.WinForms.Guna2Button addProductBtn;
        private System.Windows.Forms.Label lableTxt;
    }
}