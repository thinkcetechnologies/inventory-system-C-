namespace ThinkCE_Store_Management_System.UI.Reports
{
    partial class Transaction_Report_Details_UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaction_Report_Details_UI));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.tSalesPrice = new System.Windows.Forms.Label();
            this.tUnitPrice = new System.Windows.Forms.Label();
            this.tQty = new System.Windows.Forms.Label();
            this.tEntry = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.yearCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateDTP = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.toDTP = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.monthCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fromDTP = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.transDetailDataGridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.reloadBtn = new FontAwesome.Sharp.IconButton();
            this.printBtn = new FontAwesome.Sharp.IconButton();
            this.dgvToPrint = new System.Windows.Forms.DataGridView();
            viewBtn = new Guna.UI2.WinForms.Guna2Button();
            deliverBtn = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transDetailDataGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToPrint)).BeginInit();
            this.SuspendLayout();
            // 
            // viewBtn
            // 
            viewBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            viewBtn.BackColor = System.Drawing.Color.Transparent;
            viewBtn.BorderColor = System.Drawing.Color.White;
            viewBtn.BorderRadius = 10;
            viewBtn.BorderThickness = 2;
            viewBtn.CheckedState.Parent = viewBtn;
            viewBtn.CustomImages.Parent = viewBtn;
            viewBtn.FillColor = System.Drawing.Color.Transparent;
            viewBtn.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            viewBtn.ForeColor = System.Drawing.Color.White;
            viewBtn.HoverState.Parent = viewBtn;
            viewBtn.Location = new System.Drawing.Point(1088, 122);
            viewBtn.Name = "viewBtn";
            viewBtn.ShadowDecoration.Parent = viewBtn;
            viewBtn.Size = new System.Drawing.Size(65, 27);
            viewBtn.TabIndex = 43;
            viewBtn.Text = "View";
            // 
            // deliverBtn
            // 
            deliverBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            deliverBtn.BackColor = System.Drawing.Color.Transparent;
            deliverBtn.BorderColor = System.Drawing.Color.Navy;
            deliverBtn.BorderRadius = 10;
            deliverBtn.BorderThickness = 2;
            deliverBtn.CheckedState.Parent = deliverBtn;
            deliverBtn.CustomImages.Parent = deliverBtn;
            deliverBtn.FillColor = System.Drawing.Color.Transparent;
            deliverBtn.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            deliverBtn.ForeColor = System.Drawing.Color.Navy;
            deliverBtn.HoverState.Parent = deliverBtn;
            deliverBtn.Location = new System.Drawing.Point(1088, 9);
            deliverBtn.Name = "deliverBtn";
            deliverBtn.ShadowDecoration.Parent = deliverBtn;
            deliverBtn.Size = new System.Drawing.Size(65, 27);
            deliverBtn.TabIndex = 42;
            deliverBtn.Text = "Get";
            deliverBtn.Click += new System.EventHandler(this.deliverBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(viewBtn);
            this.groupBox1.Controls.Add(this.guna2Panel5);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(deliverBtn);
            this.groupBox1.Controls.Add(this.yearCB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateDTP);
            this.groupBox1.Controls.Add(this.toDTP);
            this.groupBox1.Controls.Add(this.monthCB);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.fromDTP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1165, 149);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FILTER REPORT DETAILS";
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2Panel5.BorderColor = System.Drawing.Color.Teal;
            this.guna2Panel5.BorderThickness = 2;
            this.guna2Panel5.Controls.Add(this.tSalesPrice);
            this.guna2Panel5.Controls.Add(this.tUnitPrice);
            this.guna2Panel5.Controls.Add(this.tQty);
            this.guna2Panel5.Controls.Add(this.tEntry);
            this.guna2Panel5.Controls.Add(this.label11);
            this.guna2Panel5.Controls.Add(this.label10);
            this.guna2Panel5.Controls.Add(this.label9);
            this.guna2Panel5.Controls.Add(this.label8);
            this.guna2Panel5.Location = new System.Drawing.Point(482, 7);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.ShadowDecoration.Parent = this.guna2Panel5;
            this.guna2Panel5.Size = new System.Drawing.Size(336, 142);
            this.guna2Panel5.TabIndex = 4;
            // 
            // tSalesPrice
            // 
            this.tSalesPrice.AutoSize = true;
            this.tSalesPrice.BackColor = System.Drawing.Color.Transparent;
            this.tSalesPrice.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSalesPrice.ForeColor = System.Drawing.Color.Navy;
            this.tSalesPrice.Location = new System.Drawing.Point(225, 116);
            this.tSalesPrice.Name = "tSalesPrice";
            this.tSalesPrice.Size = new System.Drawing.Size(37, 16);
            this.tSalesPrice.TabIndex = 46;
            this.tSalesPrice.Text = "Year";
            // 
            // tUnitPrice
            // 
            this.tUnitPrice.AutoSize = true;
            this.tUnitPrice.BackColor = System.Drawing.Color.Transparent;
            this.tUnitPrice.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tUnitPrice.ForeColor = System.Drawing.Color.Navy;
            this.tUnitPrice.Location = new System.Drawing.Point(225, 84);
            this.tUnitPrice.Name = "tUnitPrice";
            this.tUnitPrice.Size = new System.Drawing.Size(37, 16);
            this.tUnitPrice.TabIndex = 45;
            this.tUnitPrice.Text = "Year";
            // 
            // tQty
            // 
            this.tQty.AutoSize = true;
            this.tQty.BackColor = System.Drawing.Color.Transparent;
            this.tQty.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tQty.ForeColor = System.Drawing.Color.Navy;
            this.tQty.Location = new System.Drawing.Point(225, 51);
            this.tQty.Name = "tQty";
            this.tQty.Size = new System.Drawing.Size(37, 16);
            this.tQty.TabIndex = 44;
            this.tQty.Text = "Year";
            // 
            // tEntry
            // 
            this.tEntry.AutoSize = true;
            this.tEntry.BackColor = System.Drawing.Color.Transparent;
            this.tEntry.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tEntry.ForeColor = System.Drawing.Color.Navy;
            this.tEntry.Location = new System.Drawing.Point(225, 21);
            this.tEntry.Name = "tEntry";
            this.tEntry.Size = new System.Drawing.Size(37, 16);
            this.tEntry.TabIndex = 43;
            this.tEntry.Text = "Year";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(9, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(168, 16);
            this.label11.TabIndex = 35;
            this.label11.Text = "Total Quntity Of Products";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(9, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 16);
            this.label10.TabIndex = 34;
            this.label10.Text = "Total Unit Price";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(9, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 16);
            this.label9.TabIndex = 33;
            this.label9.Text = "Total Sales Price";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(9, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "Total Number Of Entry";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(12, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Year";
            // 
            // yearCB
            // 
            this.yearCB.Animated = true;
            this.yearCB.BackColor = System.Drawing.Color.Transparent;
            this.yearCB.BorderColor = System.Drawing.Color.Teal;
            this.yearCB.BorderRadius = 5;
            this.yearCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.yearCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.yearCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.yearCB.FocusedState.Parent = this.yearCB;
            this.yearCB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.yearCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.yearCB.HoverState.Parent = this.yearCB;
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
            this.yearCB.ItemsAppearance.Parent = this.yearCB;
            this.yearCB.Location = new System.Drawing.Point(60, 34);
            this.yearCB.Name = "yearCB";
            this.yearCB.ShadowDecoration.Parent = this.yearCB;
            this.yearCB.Size = new System.Drawing.Size(99, 26);
            this.yearCB.TabIndex = 29;
            this.yearCB.SelectedValueChanged += new System.EventHandler(this.yearCB_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(851, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Period";
            // 
            // dateDTP
            // 
            this.dateDTP.BorderRadius = 5;
            this.dateDTP.CheckedState.Parent = this.dateDTP;
            this.dateDTP.FillColor = System.Drawing.Color.Silver;
            this.dateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateDTP.HoverState.Parent = this.dateDTP;
            this.dateDTP.Location = new System.Drawing.Point(226, 34);
            this.dateDTP.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateDTP.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateDTP.Name = "dateDTP";
            this.dateDTP.ShadowDecoration.Parent = this.dateDTP;
            this.dateDTP.Size = new System.Drawing.Size(230, 27);
            this.dateDTP.TabIndex = 31;
            this.dateDTP.Value = new System.DateTime(2022, 2, 6, 14, 27, 0, 907);
            this.dateDTP.ValueChanged += new System.EventHandler(this.dateDTP_ValueChanged);
            // 
            // toDTP
            // 
            this.toDTP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toDTP.BorderRadius = 5;
            this.toDTP.CheckedState.Parent = this.toDTP;
            this.toDTP.FillColor = System.Drawing.Color.Silver;
            this.toDTP.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.toDTP.HoverState.Parent = this.toDTP;
            this.toDTP.Location = new System.Drawing.Point(913, 92);
            this.toDTP.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.toDTP.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.toDTP.Name = "toDTP";
            this.toDTP.ShadowDecoration.Parent = this.toDTP;
            this.toDTP.Size = new System.Drawing.Size(240, 27);
            this.toDTP.TabIndex = 27;
            this.toDTP.Value = new System.DateTime(2022, 2, 6, 14, 27, 0, 907);
            // 
            // monthCB
            // 
            this.monthCB.Animated = true;
            this.monthCB.BackColor = System.Drawing.Color.Transparent;
            this.monthCB.BorderColor = System.Drawing.Color.Teal;
            this.monthCB.BorderRadius = 5;
            this.monthCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.monthCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.monthCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.monthCB.FocusedState.Parent = this.monthCB;
            this.monthCB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.monthCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.monthCB.HoverState.Parent = this.monthCB;
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
            this.monthCB.ItemsAppearance.Parent = this.monthCB;
            this.monthCB.Location = new System.Drawing.Point(60, 92);
            this.monthCB.Name = "monthCB";
            this.monthCB.ShadowDecoration.Parent = this.monthCB;
            this.monthCB.Size = new System.Drawing.Size(99, 26);
            this.monthCB.TabIndex = 30;
            this.monthCB.SelectedValueChanged += new System.EventHandler(this.monthCB_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(913, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(6, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Month";
            // 
            // fromDTP
            // 
            this.fromDTP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fromDTP.BorderRadius = 5;
            this.fromDTP.CheckedState.Parent = this.fromDTP;
            this.fromDTP.FillColor = System.Drawing.Color.Silver;
            this.fromDTP.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.fromDTP.HoverState.Parent = this.fromDTP;
            this.fromDTP.Location = new System.Drawing.Point(913, 34);
            this.fromDTP.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.fromDTP.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.fromDTP.Name = "fromDTP";
            this.fromDTP.ShadowDecoration.Parent = this.fromDTP;
            this.fromDTP.Size = new System.Drawing.Size(240, 27);
            this.fromDTP.TabIndex = 25;
            this.fromDTP.Value = new System.DateTime(2022, 2, 6, 14, 27, 0, 907);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(174, 39);
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
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(913, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "From";
            // 
            // transDetailDataGridview
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.transDetailDataGridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.transDetailDataGridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transDetailDataGridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.transDetailDataGridview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.transDetailDataGridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.transDetailDataGridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transDetailDataGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.transDetailDataGridview.ColumnHeadersHeight = 70;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.transDetailDataGridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.transDetailDataGridview.EnableHeadersVisualStyles = false;
            this.transDetailDataGridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.transDetailDataGridview.Location = new System.Drawing.Point(9, 155);
            this.transDetailDataGridview.Name = "transDetailDataGridview";
            this.transDetailDataGridview.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transDetailDataGridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.transDetailDataGridview.RowHeadersVisible = false;
            this.transDetailDataGridview.RowTemplate.DividerHeight = 1;
            this.transDetailDataGridview.RowTemplate.Height = 40;
            this.transDetailDataGridview.RowTemplate.ReadOnly = true;
            this.transDetailDataGridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.transDetailDataGridview.Size = new System.Drawing.Size(1144, 414);
            this.transDetailDataGridview.TabIndex = 38;
            this.transDetailDataGridview.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea;
            this.transDetailDataGridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.transDetailDataGridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.transDetailDataGridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.transDetailDataGridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.transDetailDataGridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.transDetailDataGridview.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.transDetailDataGridview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.transDetailDataGridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.transDetailDataGridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.transDetailDataGridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.transDetailDataGridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.transDetailDataGridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.transDetailDataGridview.ThemeStyle.HeaderStyle.Height = 70;
            this.transDetailDataGridview.ThemeStyle.ReadOnly = true;
            this.transDetailDataGridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.transDetailDataGridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.transDetailDataGridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transDetailDataGridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.transDetailDataGridview.ThemeStyle.RowsStyle.Height = 40;
            this.transDetailDataGridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.transDetailDataGridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
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
            this.reloadBtn.Location = new System.Drawing.Point(1095, 575);
            this.reloadBtn.Name = "reloadBtn";
            this.reloadBtn.Size = new System.Drawing.Size(58, 40);
            this.reloadBtn.TabIndex = 39;
            this.reloadBtn.UseVisualStyleBackColor = true;
            this.reloadBtn.Click += new System.EventHandler(this.reloadBtn_Click);
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
            this.printBtn.Location = new System.Drawing.Point(1031, 575);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(58, 40);
            this.printBtn.TabIndex = 40;
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // dgvToPrint
            // 
            this.dgvToPrint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvToPrint.Location = new System.Drawing.Point(356, 339);
            this.dgvToPrint.Name = "dgvToPrint";
            this.dgvToPrint.Size = new System.Drawing.Size(240, 150);
            this.dgvToPrint.TabIndex = 41;
            this.dgvToPrint.Visible = false;
            // 
            // Transaction_Report_Details_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 620);
            this.Controls.Add(this.dgvToPrint);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.reloadBtn);
            this.Controls.Add(this.transDetailDataGridview);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Transaction_Report_Details_UI";
            this.Text = "Transaction Report Details";
            this.Load += new System.EventHandler(this.Transaction_Report_Details_UI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transDetailDataGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToPrint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private System.Windows.Forms.Label tSalesPrice;
        private System.Windows.Forms.Label tUnitPrice;
        private System.Windows.Forms.Label tQty;
        private System.Windows.Forms.Label tEntry;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
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
        private Guna.UI2.WinForms.Guna2DataGridView transDetailDataGridview;
        private FontAwesome.Sharp.IconButton reloadBtn;
        private FontAwesome.Sharp.IconButton printBtn;
        private System.Windows.Forms.DataGridView dgvToPrint;
    }
}