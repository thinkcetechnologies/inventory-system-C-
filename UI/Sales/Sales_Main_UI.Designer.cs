namespace ThinkCE_Store_Management_System.UI.Sales
{
    partial class Sales_Main_UI
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
            Guna.UI2.WinForms.Guna2Button deliverBtn;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales_Main_UI));
            this.productsDetailDataGridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cartDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.salesDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.recievedAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.changeAmount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.totalAmount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.camCBX = new Guna.UI2.WinForms.Guna2ComboBox();
            this.barcodePic = new FontAwesome.Sharp.IconPictureBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.searchSearchDetailTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.barcodeTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.addQuantity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.add = new FontAwesome.Sharp.IconButton();
            this.salesReceiptPrinter = new System.Drawing.Printing.PrintDocument();
            this.salesPrintPreview = new System.Windows.Forms.PrintPreviewDialog();
            deliverBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.productsDetailDataGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGridView)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changeAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // deliverBtn
            // 
            deliverBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            deliverBtn.BorderRadius = 10;
            deliverBtn.CheckedState.Parent = deliverBtn;
            deliverBtn.CustomImages.Parent = deliverBtn;
            deliverBtn.FillColor = System.Drawing.Color.Navy;
            deliverBtn.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            deliverBtn.ForeColor = System.Drawing.Color.White;
            deliverBtn.HoverState.Parent = deliverBtn;
            deliverBtn.Location = new System.Drawing.Point(343, 92);
            deliverBtn.Name = "deliverBtn";
            deliverBtn.ShadowDecoration.Parent = deliverBtn;
            deliverBtn.Size = new System.Drawing.Size(106, 35);
            deliverBtn.TabIndex = 41;
            deliverBtn.Text = "Deliver";
            deliverBtn.Click += new System.EventHandler(this.deliverBtn_Click);
            // 
            // productsDetailDataGridview
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.productsDetailDataGridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.productsDetailDataGridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productsDetailDataGridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsDetailDataGridview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.productsDetailDataGridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productsDetailDataGridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productsDetailDataGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.productsDetailDataGridview.ColumnHeadersHeight = 70;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productsDetailDataGridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.productsDetailDataGridview.EnableHeadersVisualStyles = false;
            this.productsDetailDataGridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.productsDetailDataGridview.Location = new System.Drawing.Point(12, 60);
            this.productsDetailDataGridview.Name = "productsDetailDataGridview";
            this.productsDetailDataGridview.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productsDetailDataGridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.productsDetailDataGridview.RowHeadersVisible = false;
            this.productsDetailDataGridview.RowTemplate.DividerHeight = 1;
            this.productsDetailDataGridview.RowTemplate.Height = 40;
            this.productsDetailDataGridview.RowTemplate.ReadOnly = true;
            this.productsDetailDataGridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsDetailDataGridview.Size = new System.Drawing.Size(387, 339);
            this.productsDetailDataGridview.TabIndex = 36;
            this.productsDetailDataGridview.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea;
            this.productsDetailDataGridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.productsDetailDataGridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.productsDetailDataGridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.productsDetailDataGridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.productsDetailDataGridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.productsDetailDataGridview.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.productsDetailDataGridview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.productsDetailDataGridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.productsDetailDataGridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.productsDetailDataGridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.productsDetailDataGridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.productsDetailDataGridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.productsDetailDataGridview.ThemeStyle.HeaderStyle.Height = 70;
            this.productsDetailDataGridview.ThemeStyle.ReadOnly = true;
            this.productsDetailDataGridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.productsDetailDataGridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.productsDetailDataGridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsDetailDataGridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.productsDetailDataGridview.ThemeStyle.RowsStyle.Height = 40;
            this.productsDetailDataGridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.productsDetailDataGridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.productsDetailDataGridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsDetailDataGridview_CellClick);
            // 
            // cartDataGridView
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.cartDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.cartDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.cartDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cartDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cartDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cartDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.cartDataGridView.ColumnHeadersHeight = 70;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cartDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.cartDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.cartDataGridView.EnableHeadersVisualStyles = false;
            this.cartDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.cartDataGridView.Location = new System.Drawing.Point(419, 60);
            this.cartDataGridView.Name = "cartDataGridView";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cartDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.cartDataGridView.RowHeadersVisible = false;
            this.cartDataGridView.RowHeadersWidth = 60;
            this.cartDataGridView.RowTemplate.DividerHeight = 1;
            this.cartDataGridView.RowTemplate.Height = 70;
            this.cartDataGridView.RowTemplate.ReadOnly = true;
            this.cartDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cartDataGridView.Size = new System.Drawing.Size(522, 339);
            this.cartDataGridView.TabIndex = 37;
            this.cartDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Teal;
            this.cartDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.cartDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.cartDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.cartDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.cartDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.cartDataGridView.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cartDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.cartDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.cartDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.cartDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cartDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.cartDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.cartDataGridView.ThemeStyle.HeaderStyle.Height = 70;
            this.cartDataGridView.ThemeStyle.ReadOnly = false;
            this.cartDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.cartDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.cartDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.cartDataGridView.ThemeStyle.RowsStyle.Height = 70;
            this.cartDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            this.cartDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.cartDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cartDataGridView_CellClick);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.Teal;
            this.guna2Panel1.Controls.Add(this.salesDate);
            this.guna2Panel1.Controls.Add(this.recievedAmount);
            this.guna2Panel1.Controls.Add(deliverBtn);
            this.guna2Panel1.Controls.Add(this.changeAmount);
            this.guna2Panel1.Controls.Add(this.totalAmount);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel4);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel1.Location = new System.Drawing.Point(475, 409);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(466, 130);
            this.guna2Panel1.TabIndex = 38;
            // 
            // salesDate
            // 
            this.salesDate.BorderRadius = 10;
            this.salesDate.CheckedState.Parent = this.salesDate;
            this.salesDate.FillColor = System.Drawing.Color.White;
            this.salesDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesDate.ForeColor = System.Drawing.SystemColors.GrayText;
            this.salesDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.salesDate.HoverState.Parent = this.salesDate;
            this.salesDate.Location = new System.Drawing.Point(20, 84);
            this.salesDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.salesDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.salesDate.Name = "salesDate";
            this.salesDate.ShadowDecoration.Parent = this.salesDate;
            this.salesDate.Size = new System.Drawing.Size(277, 35);
            this.salesDate.TabIndex = 45;
            this.salesDate.Value = new System.DateTime(2022, 2, 5, 10, 46, 55, 82);
            // 
            // recievedAmount
            // 
            this.recievedAmount.Animated = true;
            this.recievedAmount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.recievedAmount.BorderRadius = 10;
            this.recievedAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.recievedAmount.DefaultText = "";
            this.recievedAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.recievedAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.recievedAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.recievedAmount.DisabledState.Parent = this.recievedAmount;
            this.recievedAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.recievedAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.recievedAmount.FocusedState.Parent = this.recievedAmount;
            this.recievedAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.recievedAmount.HoverState.Parent = this.recievedAmount;
            this.recievedAmount.Location = new System.Drawing.Point(20, 51);
            this.recievedAmount.Name = "recievedAmount";
            this.recievedAmount.PasswordChar = '\0';
            this.recievedAmount.PlaceholderText = "";
            this.recievedAmount.SelectedText = "";
            this.recievedAmount.ShadowDecoration.Parent = this.recievedAmount;
            this.recievedAmount.Size = new System.Drawing.Size(127, 27);
            this.recievedAmount.TabIndex = 44;
            this.recievedAmount.TextChanged += new System.EventHandler(this.recievedAmount_TextChanged);
            // 
            // changeAmount
            // 
            this.changeAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changeAmount.BackColor = System.Drawing.Color.Transparent;
            this.changeAmount.BorderColor = System.Drawing.Color.Navy;
            this.changeAmount.BorderRadius = 6;
            this.changeAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.changeAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.changeAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.changeAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.changeAmount.DisabledState.Parent = this.changeAmount;
            this.changeAmount.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.changeAmount.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.changeAmount.Enabled = false;
            this.changeAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.changeAmount.FocusedState.Parent = this.changeAmount;
            this.changeAmount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.changeAmount.Location = new System.Drawing.Point(343, 47);
            this.changeAmount.Maximum = new decimal(new int[] {
            -402653184,
            -1613725636,
            54210108,
            0});
            this.changeAmount.Name = "changeAmount";
            this.changeAmount.ShadowDecoration.Parent = this.changeAmount;
            this.changeAmount.Size = new System.Drawing.Size(106, 31);
            this.changeAmount.TabIndex = 29;
            // 
            // totalAmount
            // 
            this.totalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalAmount.BackColor = System.Drawing.Color.Transparent;
            this.totalAmount.BorderColor = System.Drawing.Color.Navy;
            this.totalAmount.BorderRadius = 6;
            this.totalAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.totalAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.totalAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.totalAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totalAmount.DisabledState.Parent = this.totalAmount;
            this.totalAmount.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.totalAmount.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.totalAmount.Enabled = false;
            this.totalAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalAmount.FocusedState.Parent = this.totalAmount;
            this.totalAmount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.totalAmount.Location = new System.Drawing.Point(170, 47);
            this.totalAmount.Maximum = new decimal(new int[] {
            -402653184,
            -1613725636,
            54210108,
            0});
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.ShadowDecoration.Parent = this.totalAmount;
            this.totalAmount.Size = new System.Drawing.Size(127, 31);
            this.totalAmount.TabIndex = 28;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(354, 19);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(55, 22);
            this.guna2HtmlLabel4.TabIndex = 2;
            this.guna2HtmlLabel4.Text = "Change";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(185, 19);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(77, 22);
            this.guna2HtmlLabel3.TabIndex = 1;
            this.guna2HtmlLabel3.Text = "Total Price";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(20, 19);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(127, 22);
            this.guna2HtmlLabel2.TabIndex = 0;
            this.guna2HtmlLabel2.Text = "Recieved Amount";
            // 
            // camCBX
            // 
            this.camCBX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.camCBX.BackColor = System.Drawing.Color.Transparent;
            this.camCBX.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.camCBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.camCBX.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.camCBX.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.camCBX.FocusedState.Parent = this.camCBX;
            this.camCBX.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.camCBX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.camCBX.HoverState.Parent = this.camCBX;
            this.camCBX.ItemHeight = 30;
            this.camCBX.ItemsAppearance.Parent = this.camCBX;
            this.camCBX.Location = new System.Drawing.Point(232, 492);
            this.camCBX.Name = "camCBX";
            this.camCBX.ShadowDecoration.Parent = this.camCBX;
            this.camCBX.Size = new System.Drawing.Size(207, 36);
            this.camCBX.TabIndex = 40;
            // 
            // barcodePic
            // 
            this.barcodePic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.barcodePic.BackColor = System.Drawing.Color.White;
            this.barcodePic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.barcodePic.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.barcodePic.IconChar = FontAwesome.Sharp.IconChar.Qrcode;
            this.barcodePic.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.barcodePic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.barcodePic.IconSize = 123;
            this.barcodePic.Location = new System.Drawing.Point(12, 405);
            this.barcodePic.Name = "barcodePic";
            this.barcodePic.Size = new System.Drawing.Size(214, 123);
            this.barcodePic.TabIndex = 39;
            this.barcodePic.TabStop = false;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(619, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(60, 27);
            this.guna2HtmlLabel1.TabIndex = 42;
            this.guna2HtmlLabel1.Text = "Search";
            // 
            // searchSearchDetailTextBox
            // 
            this.searchSearchDetailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchSearchDetailTextBox.Animated = true;
            this.searchSearchDetailTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.searchSearchDetailTextBox.BorderRadius = 10;
            this.searchSearchDetailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchSearchDetailTextBox.DefaultText = "";
            this.searchSearchDetailTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchSearchDetailTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchSearchDetailTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchSearchDetailTextBox.DisabledState.Parent = this.searchSearchDetailTextBox;
            this.searchSearchDetailTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchSearchDetailTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchSearchDetailTextBox.FocusedState.Parent = this.searchSearchDetailTextBox;
            this.searchSearchDetailTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchSearchDetailTextBox.HoverState.Parent = this.searchSearchDetailTextBox;
            this.searchSearchDetailTextBox.Location = new System.Drawing.Point(697, 12);
            this.searchSearchDetailTextBox.Name = "searchSearchDetailTextBox";
            this.searchSearchDetailTextBox.PasswordChar = '\0';
            this.searchSearchDetailTextBox.PlaceholderText = "";
            this.searchSearchDetailTextBox.SelectedText = "";
            this.searchSearchDetailTextBox.ShadowDecoration.Parent = this.searchSearchDetailTextBox;
            this.searchSearchDetailTextBox.Size = new System.Drawing.Size(244, 27);
            this.searchSearchDetailTextBox.TabIndex = 41;
            this.searchSearchDetailTextBox.TextChanged += new System.EventHandler(this.searchSearchDetailTextBox_TextChanged);
            // 
            // barcodeTxt
            // 
            this.barcodeTxt.Animated = true;
            this.barcodeTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.barcodeTxt.BorderRadius = 10;
            this.barcodeTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.barcodeTxt.DefaultText = "";
            this.barcodeTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.barcodeTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.barcodeTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.barcodeTxt.DisabledState.Parent = this.barcodeTxt;
            this.barcodeTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.barcodeTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.barcodeTxt.FocusedState.Parent = this.barcodeTxt;
            this.barcodeTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.barcodeTxt.HoverState.Parent = this.barcodeTxt;
            this.barcodeTxt.Location = new System.Drawing.Point(12, 12);
            this.barcodeTxt.Name = "barcodeTxt";
            this.barcodeTxt.PasswordChar = '\0';
            this.barcodeTxt.PlaceholderText = "";
            this.barcodeTxt.SelectedText = "";
            this.barcodeTxt.ShadowDecoration.Parent = this.barcodeTxt;
            this.barcodeTxt.Size = new System.Drawing.Size(244, 27);
            this.barcodeTxt.TabIndex = 43;
            this.barcodeTxt.TextChanged += new System.EventHandler(this.barcodeTxt_TextChanged);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Malgun Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(365, -3);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(233, 42);
            this.guna2HtmlLabel5.TabIndex = 44;
            this.guna2HtmlLabel5.Text = "Make Sales Here";
            // 
            // addQuantity
            // 
            this.addQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addQuantity.BackColor = System.Drawing.Color.Transparent;
            this.addQuantity.BorderColor = System.Drawing.Color.Navy;
            this.addQuantity.BorderRadius = 6;
            this.addQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addQuantity.DisabledState.Parent = this.addQuantity;
            this.addQuantity.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.addQuantity.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.addQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addQuantity.FocusedState.Parent = this.addQuantity;
            this.addQuantity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.addQuantity.Location = new System.Drawing.Point(346, 409);
            this.addQuantity.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.addQuantity.Name = "addQuantity";
            this.addQuantity.ShadowDecoration.Parent = this.addQuantity;
            this.addQuantity.Size = new System.Drawing.Size(75, 24);
            this.addQuantity.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(233, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 56;
            this.label5.Text = "Quantity Needed";
            // 
            // add
            // 
            this.add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.IconChar = FontAwesome.Sharp.IconChar.ChevronRight;
            this.add.IconColor = System.Drawing.Color.Navy;
            this.add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.add.IconSize = 25;
            this.add.Location = new System.Drawing.Point(344, 439);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 29);
            this.add.TabIndex = 58;
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // salesReceiptPrinter
            // 
            this.salesReceiptPrinter.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.salesReceiptPrinter_PrintPage);
            // 
            // salesPrintPreview
            // 
            this.salesPrintPreview.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.salesPrintPreview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.salesPrintPreview.ClientSize = new System.Drawing.Size(400, 300);
            this.salesPrintPreview.Enabled = true;
            this.salesPrintPreview.Icon = ((System.Drawing.Icon)(resources.GetObject("salesPrintPreview.Icon")));
            this.salesPrintPreview.Name = "salesPrintPreview";
            this.salesPrintPreview.Visible = false;
            // 
            // Sales_Main_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(953, 540);
            this.Controls.Add(this.add);
            this.Controls.Add(this.addQuantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.barcodeTxt);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.searchSearchDetailTextBox);
            this.Controls.Add(this.camCBX);
            this.Controls.Add(this.barcodePic);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.cartDataGridView);
            this.Controls.Add(this.productsDetailDataGridview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Sales_Main_UI";
            this.Text = "Sales_Main_UI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sales_Main_UI_FormClosing);
            this.Load += new System.EventHandler(this.Sales_Main_UI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsDetailDataGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGridView)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changeAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView productsDetailDataGridview;
        private Guna.UI2.WinForms.Guna2DataGridView cartDataGridView;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ComboBox camCBX;
        private FontAwesome.Sharp.IconPictureBox barcodePic;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox searchSearchDetailTextBox;
        private Guna.UI2.WinForms.Guna2TextBox barcodeTxt;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2NumericUpDown changeAmount;
        private Guna.UI2.WinForms.Guna2NumericUpDown totalAmount;
        private Guna.UI2.WinForms.Guna2TextBox recievedAmount;
        private Guna.UI2.WinForms.Guna2DateTimePicker salesDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2NumericUpDown addQuantity;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton add;
        private System.Drawing.Printing.PrintDocument salesReceiptPrinter;
        private System.Windows.Forms.PrintPreviewDialog salesPrintPreview;
    }
}