namespace ThinkCE_Store_Management_System.UI.Reports
{
    partial class Stock_Reports
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
            Guna.UI2.WinForms.Guna2Button viewBtn;
            Guna.UI2.WinForms.Guna2Button deliverBtn;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock_Reports));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.minQty = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.cheapItem = new Guna.UI2.WinForms.Guna2RadioButton();
            this.shortage = new Guna.UI2.WinForms.Guna2RadioButton();
            this.mostExpensive = new Guna.UI2.WinForms.Guna2RadioButton();
            this.mostQuantize = new Guna.UI2.WinForms.Guna2RadioButton();
            this.mostPurchaseItem = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.tEntry = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.productNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.toDTP = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fromDTP = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.yearCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateDTP = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.monthCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.stockDetailDataGridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.printBtn = new FontAwesome.Sharp.IconButton();
            this.reloadBtn = new FontAwesome.Sharp.IconButton();
            viewBtn = new Guna.UI2.WinForms.Guna2Button();
            deliverBtn = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minQty)).BeginInit();
            this.guna2Panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockDetailDataGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // viewBtn
            // 
            viewBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            viewBtn.BackColor = System.Drawing.Color.Transparent;
            viewBtn.BorderColor = System.Drawing.Color.White;
            viewBtn.BorderRadius = 10;
            viewBtn.BorderThickness = 2;
            viewBtn.FillColor = System.Drawing.Color.Transparent;
            viewBtn.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            viewBtn.ForeColor = System.Drawing.Color.White;
            viewBtn.Location = new System.Drawing.Point(1106, 9);
            viewBtn.Name = "viewBtn";
            viewBtn.Size = new System.Drawing.Size(65, 27);
            viewBtn.TabIndex = 43;
            viewBtn.Text = "View";
            // 
            // deliverBtn
            // 
            deliverBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            deliverBtn.BackColor = System.Drawing.Color.Transparent;
            deliverBtn.BorderColor = System.Drawing.Color.Cyan;
            deliverBtn.BorderRadius = 10;
            deliverBtn.BorderThickness = 2;
            deliverBtn.FillColor = System.Drawing.Color.Transparent;
            deliverBtn.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            deliverBtn.ForeColor = System.Drawing.Color.Cyan;
            deliverBtn.Location = new System.Drawing.Point(1109, 118);
            deliverBtn.Name = "deliverBtn";
            deliverBtn.Size = new System.Drawing.Size(65, 27);
            deliverBtn.TabIndex = 42;
            deliverBtn.Text = "Get";
            deliverBtn.Click += new System.EventHandler(this.deliverBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.guna2Panel1);
            this.groupBox1.Controls.Add(viewBtn);
            this.groupBox1.Controls.Add(this.guna2Panel5);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(deliverBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.productNameTextBox);
            this.groupBox1.Controls.Add(this.toDTP);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.fromDTP);
            this.groupBox1.Controls.Add(this.yearCB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateDTP);
            this.groupBox1.Controls.Add(this.monthCB);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Cyan;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1186, 149);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FILTER REPORT DETAILS";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Teal;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.label12);
            this.guna2Panel1.Controls.Add(this.minQty);
            this.guna2Panel1.Controls.Add(this.cheapItem);
            this.guna2Panel1.Controls.Add(this.shortage);
            this.guna2Panel1.Controls.Add(this.mostExpensive);
            this.guna2Panel1.Controls.Add(this.mostQuantize);
            this.guna2Panel1.Controls.Add(this.mostPurchaseItem);
            this.guna2Panel1.Location = new System.Drawing.Point(310, 22);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(363, 121);
            this.guna2Panel1.TabIndex = 47;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(189, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 16);
            this.label12.TabIndex = 48;
            this.label12.Text = "Enter Quantity";
            // 
            // minQty
            // 
            this.minQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minQty.BackColor = System.Drawing.Color.Transparent;
            this.minQty.BorderColor = System.Drawing.Color.Navy;
            this.minQty.BorderRadius = 6;
            this.minQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.minQty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.minQty.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.minQty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.minQty.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.minQty.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.minQty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.minQty.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.minQty.Location = new System.Drawing.Point(192, 62);
            this.minQty.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.minQty.Name = "minQty";
            this.minQty.Size = new System.Drawing.Size(71, 24);
            this.minQty.TabIndex = 28;
            this.minQty.ValueChanged += new System.EventHandler(this.minQty_ValueChanged);
            // 
            // cheapItem
            // 
            this.cheapItem.AutoSize = true;
            this.cheapItem.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cheapItem.CheckedState.BorderThickness = 0;
            this.cheapItem.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cheapItem.CheckedState.InnerColor = System.Drawing.Color.White;
            this.cheapItem.CheckedState.InnerOffset = -4;
            this.cheapItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cheapItem.ForeColor = System.Drawing.Color.White;
            this.cheapItem.Location = new System.Drawing.Point(192, 11);
            this.cheapItem.Name = "cheapItem";
            this.cheapItem.Size = new System.Drawing.Size(113, 19);
            this.cheapItem.TabIndex = 6;
            this.cheapItem.Text = "CHEAPEST ITEM";
            this.cheapItem.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cheapItem.UncheckedState.BorderThickness = 2;
            this.cheapItem.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.cheapItem.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.cheapItem.CheckedChanged += new System.EventHandler(this.cheapItem_CheckedChanged);
            // 
            // shortage
            // 
            this.shortage.AutoSize = true;
            this.shortage.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.shortage.CheckedState.BorderThickness = 0;
            this.shortage.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.shortage.CheckedState.InnerColor = System.Drawing.Color.White;
            this.shortage.CheckedState.InnerOffset = -4;
            this.shortage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shortage.ForeColor = System.Drawing.Color.White;
            this.shortage.Location = new System.Drawing.Point(13, 67);
            this.shortage.Name = "shortage";
            this.shortage.Size = new System.Drawing.Size(118, 19);
            this.shortage.TabIndex = 5;
            this.shortage.Text = "SHORTAGE ITEM";
            this.shortage.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.shortage.UncheckedState.BorderThickness = 2;
            this.shortage.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.shortage.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.shortage.CheckedChanged += new System.EventHandler(this.shortage_CheckedChanged);
            // 
            // mostExpensive
            // 
            this.mostExpensive.AutoSize = true;
            this.mostExpensive.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mostExpensive.CheckedState.BorderThickness = 0;
            this.mostExpensive.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mostExpensive.CheckedState.InnerColor = System.Drawing.Color.White;
            this.mostExpensive.CheckedState.InnerOffset = -4;
            this.mostExpensive.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostExpensive.ForeColor = System.Drawing.Color.White;
            this.mostExpensive.Location = new System.Drawing.Point(13, 95);
            this.mostExpensive.Name = "mostExpensive";
            this.mostExpensive.Size = new System.Drawing.Size(154, 19);
            this.mostExpensive.TabIndex = 4;
            this.mostExpensive.Text = "MOST EXPENSIVE ITEM";
            this.mostExpensive.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.mostExpensive.UncheckedState.BorderThickness = 2;
            this.mostExpensive.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.mostExpensive.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.mostExpensive.CheckedChanged += new System.EventHandler(this.mostExpensive_CheckedChanged);
            // 
            // mostQuantize
            // 
            this.mostQuantize.AutoSize = true;
            this.mostQuantize.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mostQuantize.CheckedState.BorderThickness = 0;
            this.mostQuantize.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mostQuantize.CheckedState.InnerColor = System.Drawing.Color.White;
            this.mostQuantize.CheckedState.InnerOffset = -4;
            this.mostQuantize.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostQuantize.ForeColor = System.Drawing.Color.White;
            this.mostQuantize.Location = new System.Drawing.Point(13, 39);
            this.mostQuantize.Name = "mostQuantize";
            this.mostQuantize.Size = new System.Drawing.Size(152, 19);
            this.mostQuantize.TabIndex = 3;
            this.mostQuantize.Text = "MOST QUANTIZE ITEM";
            this.mostQuantize.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.mostQuantize.UncheckedState.BorderThickness = 2;
            this.mostQuantize.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.mostQuantize.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.mostQuantize.CheckedChanged += new System.EventHandler(this.mostQuantize_CheckedChanged);
            // 
            // mostPurchaseItem
            // 
            this.mostPurchaseItem.AutoSize = true;
            this.mostPurchaseItem.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mostPurchaseItem.CheckedState.BorderThickness = 0;
            this.mostPurchaseItem.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mostPurchaseItem.CheckedState.InnerColor = System.Drawing.Color.White;
            this.mostPurchaseItem.CheckedState.InnerOffset = -4;
            this.mostPurchaseItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostPurchaseItem.ForeColor = System.Drawing.Color.White;
            this.mostPurchaseItem.Location = new System.Drawing.Point(13, 10);
            this.mostPurchaseItem.Name = "mostPurchaseItem";
            this.mostPurchaseItem.Size = new System.Drawing.Size(154, 19);
            this.mostPurchaseItem.TabIndex = 2;
            this.mostPurchaseItem.Text = "MOST PURCHASE ITEM";
            this.mostPurchaseItem.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.mostPurchaseItem.UncheckedState.BorderThickness = 2;
            this.mostPurchaseItem.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.mostPurchaseItem.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.mostPurchaseItem.CheckedChanged += new System.EventHandler(this.mostPurchaseItem_CheckedChanged);
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BorderColor = System.Drawing.Color.Teal;
            this.guna2Panel5.BorderThickness = 2;
            this.guna2Panel5.Controls.Add(this.tEntry);
            this.guna2Panel5.Controls.Add(this.label8);
            this.guna2Panel5.Location = new System.Drawing.Point(12, 23);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(277, 121);
            this.guna2Panel5.TabIndex = 4;
            // 
            // tEntry
            // 
            this.tEntry.AutoSize = true;
            this.tEntry.BackColor = System.Drawing.Color.Transparent;
            this.tEntry.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tEntry.ForeColor = System.Drawing.Color.White;
            this.tEntry.Location = new System.Drawing.Point(186, 6);
            this.tEntry.Name = "tEntry";
            this.tEntry.Size = new System.Drawing.Size(14, 16);
            this.tEntry.TabIndex = 43;
            this.tEntry.Text = "?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(13, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "Total Number Of Entry";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(702, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Year";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(872, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Period";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.productNameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.productNameTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.productNameTextBox.BorderRadius = 5;
            this.productNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.productNameTextBox.DefaultText = "";
            this.productNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.productNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.productNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.productNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.productNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.productNameTextBox.Location = new System.Drawing.Point(767, 118);
            this.productNameTextBox.Margin = new System.Windows.Forms.Padding(22, 13, 22, 13);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.PasswordChar = '\0';
            this.productNameTextBox.PlaceholderText = "";
            this.productNameTextBox.SelectedText = "";
            this.productNameTextBox.Size = new System.Drawing.Size(152, 26);
            this.productNameTextBox.TabIndex = 24;
            // 
            // toDTP
            // 
            this.toDTP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toDTP.BorderRadius = 5;
            this.toDTP.Checked = true;
            this.toDTP.FillColor = System.Drawing.Color.Teal;
            this.toDTP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toDTP.ForeColor = System.Drawing.Color.White;
            this.toDTP.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.toDTP.Location = new System.Drawing.Point(934, 92);
            this.toDTP.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.toDTP.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.toDTP.Name = "toDTP";
            this.toDTP.Size = new System.Drawing.Size(240, 27);
            this.toDTP.TabIndex = 27;
            this.toDTP.Value = new System.DateTime(2022, 2, 6, 14, 27, 0, 907);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(934, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "To";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(702, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Product";
            // 
            // fromDTP
            // 
            this.fromDTP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fromDTP.BorderRadius = 5;
            this.fromDTP.Checked = true;
            this.fromDTP.FillColor = System.Drawing.Color.Teal;
            this.fromDTP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fromDTP.ForeColor = System.Drawing.Color.White;
            this.fromDTP.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.fromDTP.Location = new System.Drawing.Point(934, 34);
            this.fromDTP.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.fromDTP.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.fromDTP.Name = "fromDTP";
            this.fromDTP.Size = new System.Drawing.Size(240, 27);
            this.fromDTP.TabIndex = 25;
            this.fromDTP.Value = new System.DateTime(2022, 2, 6, 14, 27, 0, 907);
            // 
            // yearCB
            // 
            this.yearCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.yearCB.Animated = true;
            this.yearCB.BackColor = System.Drawing.Color.Transparent;
            this.yearCB.BorderColor = System.Drawing.Color.Teal;
            this.yearCB.BorderRadius = 5;
            this.yearCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.yearCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.yearCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.yearCB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.yearCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.yearCB.ItemHeight = 20;
            this.yearCB.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035",
            "2036",
            "2037",
            "2038",
            "2039",
            "2040"});
            this.yearCB.Location = new System.Drawing.Point(767, 10);
            this.yearCB.Name = "yearCB";
            this.yearCB.Size = new System.Drawing.Size(99, 26);
            this.yearCB.TabIndex = 29;
            this.yearCB.SelectedIndexChanged += new System.EventHandler(this.yearCB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(702, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(934, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "From";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(702, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Month";
            // 
            // dateDTP
            // 
            this.dateDTP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateDTP.BorderRadius = 5;
            this.dateDTP.Checked = true;
            this.dateDTP.FillColor = System.Drawing.Color.Teal;
            this.dateDTP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateDTP.ForeColor = System.Drawing.Color.White;
            this.dateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateDTP.Location = new System.Drawing.Point(767, 83);
            this.dateDTP.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateDTP.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateDTP.Name = "dateDTP";
            this.dateDTP.Size = new System.Drawing.Size(152, 27);
            this.dateDTP.TabIndex = 31;
            this.dateDTP.Value = new System.DateTime(2022, 2, 6, 14, 27, 0, 907);
            this.dateDTP.ValueChanged += new System.EventHandler(this.dateDTP_ValueChanged);
            // 
            // monthCB
            // 
            this.monthCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCB.Animated = true;
            this.monthCB.BackColor = System.Drawing.Color.Transparent;
            this.monthCB.BorderColor = System.Drawing.Color.Teal;
            this.monthCB.BorderRadius = 5;
            this.monthCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.monthCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.monthCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.monthCB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.monthCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.monthCB.ItemHeight = 20;
            this.monthCB.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.monthCB.Location = new System.Drawing.Point(767, 40);
            this.monthCB.Name = "monthCB";
            this.monthCB.Size = new System.Drawing.Size(99, 26);
            this.monthCB.TabIndex = 30;
            this.monthCB.SelectedIndexChanged += new System.EventHandler(this.monthCB_SelectedIndexChanged);
            // 
            // stockDetailDataGridview
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.stockDetailDataGridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.stockDetailDataGridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stockDetailDataGridview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.stockDetailDataGridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stockDetailDataGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.stockDetailDataGridview.ColumnHeadersHeight = 70;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.stockDetailDataGridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.stockDetailDataGridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.stockDetailDataGridview.Location = new System.Drawing.Point(12, 160);
            this.stockDetailDataGridview.Name = "stockDetailDataGridview";
            this.stockDetailDataGridview.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stockDetailDataGridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.stockDetailDataGridview.RowHeadersVisible = false;
            this.stockDetailDataGridview.RowTemplate.DividerHeight = 1;
            this.stockDetailDataGridview.RowTemplate.Height = 40;
            this.stockDetailDataGridview.RowTemplate.ReadOnly = true;
            this.stockDetailDataGridview.Size = new System.Drawing.Size(1159, 415);
            this.stockDetailDataGridview.TabIndex = 45;
            this.stockDetailDataGridview.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea;
            this.stockDetailDataGridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.stockDetailDataGridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.stockDetailDataGridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.stockDetailDataGridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.stockDetailDataGridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.stockDetailDataGridview.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.stockDetailDataGridview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.stockDetailDataGridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.stockDetailDataGridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.stockDetailDataGridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.stockDetailDataGridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.stockDetailDataGridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.stockDetailDataGridview.ThemeStyle.HeaderStyle.Height = 70;
            this.stockDetailDataGridview.ThemeStyle.ReadOnly = true;
            this.stockDetailDataGridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.stockDetailDataGridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.stockDetailDataGridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockDetailDataGridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.stockDetailDataGridview.ThemeStyle.RowsStyle.Height = 40;
            this.stockDetailDataGridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.stockDetailDataGridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // printBtn
            // 
            this.printBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.printBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printBtn.ForeColor = System.Drawing.Color.Teal;
            this.printBtn.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.printBtn.IconColor = System.Drawing.Color.Teal;
            this.printBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.printBtn.IconSize = 40;
            this.printBtn.Location = new System.Drawing.Point(1036, 581);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(58, 35);
            this.printBtn.TabIndex = 47;
            this.printBtn.UseVisualStyleBackColor = true;
            // 
            // reloadBtn
            // 
            this.reloadBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.reloadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reloadBtn.ForeColor = System.Drawing.Color.Teal;
            this.reloadBtn.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.reloadBtn.IconColor = System.Drawing.Color.Teal;
            this.reloadBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.reloadBtn.IconSize = 40;
            this.reloadBtn.Location = new System.Drawing.Point(1100, 581);
            this.reloadBtn.Name = "reloadBtn";
            this.reloadBtn.Size = new System.Drawing.Size(58, 35);
            this.reloadBtn.TabIndex = 46;
            this.reloadBtn.UseVisualStyleBackColor = true;
            // 
            // Stock_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1186, 618);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.reloadBtn);
            this.Controls.Add(this.stockDetailDataGridview);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Stock_Reports";
            this.Text = "STOCK REPORT DETAILS";
            this.Load += new System.EventHandler(this.Stock_Reports_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minQty)).EndInit();
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockDetailDataGridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private System.Windows.Forms.Label tEntry;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox productNameTextBox;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox yearCB;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateDTP;
        private Guna.UI2.WinForms.Guna2DateTimePicker toDTP;
        private Guna.UI2.WinForms.Guna2ComboBox monthCB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker fromDTP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton printBtn;
        private FontAwesome.Sharp.IconButton reloadBtn;
        private Guna.UI2.WinForms.Guna2DataGridView stockDetailDataGridview;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2RadioButton mostQuantize;
        private Guna.UI2.WinForms.Guna2RadioButton mostPurchaseItem;
        private Guna.UI2.WinForms.Guna2RadioButton shortage;
        private Guna.UI2.WinForms.Guna2RadioButton mostExpensive;
        private Guna.UI2.WinForms.Guna2RadioButton cheapItem;
        private Guna.UI2.WinForms.Guna2NumericUpDown minQty;
        private System.Windows.Forms.Label label12;
    }
}