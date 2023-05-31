using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using Guna.UI2.WinForms;
using ThinkCE_Store_Management_System.SQLITE_DATABASE_HELPER;
using ThinkCE_Store_Management_System.UI.Sales;
using ThinkCE_Store_Management_System.UI.Auth;
using ThinkCE_Store_Management_System.UI.Products;
using ThinkCE_Store_Management_System.UI.Transactions;
using ThinkCE_Store_Management_System.UI.Reports;
using ThinkCE_Store_Management_System.DATABASE_HELPER;
using ThinkCE_Store_Management_System.GETTERS_AND_SETTERS.Products;
using ThinkCE_Store_Management_System.GETTERS_AND_SETTERS.Sales;
using ThinkCE_Store_Management_System.GETTERS_AND_SETTERS.Auth;
using ThinkCE_Store_Management_System.DATABASE_HELPER.Auth;
using ThinkCE_Store_Management_System.DATABASE_HELPER.Products;
using ThinkCE_Store_Management_System.DATABASE_HELPER.Sales;
using ThinkCE_Store_Management_System.UI;
using ThinkCE_Store_Management_System.GETTERS_AND_SETTERS.Suppliers;

namespace ThinkCE_Store_Management_System
{
    public partial class HomeDashboard : Form
    {
        public HomeDashboard()
        {
            InitializeComponent();
        }
        UsersSqliteDatabaseHelper usersSqliteDatabaseHelper = new UsersSqliteDatabaseHelper();
        VideoCaptureDevice videoCaptureDevice = new VideoCaptureDevice();
        GeneralLocalDatabaseHelper generalLocalDatabase = new GeneralLocalDatabaseHelper();
        GeneralDatabaseOnlineHelper generalDatabaseOnline = new GeneralDatabaseOnlineHelper();
        ProductsGetterAndSetter productsGetterAndSetter = new ProductsGetterAndSetter();
        SalesGetterAndSetter salesGetterAndSetter = new SalesGetterAndSetter();
        AuthGetterAndSettter usersGetterAndSettter = new AuthGetterAndSettter();
        AuthDatabaseHelper authDatabaseHelper = new AuthDatabaseHelper();
        SupplierLocalDatabaseHelper localDatabaseHelper = new SupplierLocalDatabaseHelper();
        VendorDetailsGS vendorDetailsGS = new VendorDetailsGS();
        VendorDetailOnlineDBHelper vendorDetailOnlineDB = new VendorDetailOnlineDBHelper();
        SupplierOnlineDBHelper supplierOnlineDB = new SupplierOnlineDBHelper();
        SuppliersGetterAndSetter suppliersGetterAndSetter = new SuppliersGetterAndSetter();
        ProductsOnlineDatabaseHelper productsOnlineDatabaseHelper = new ProductsOnlineDatabaseHelper();
        InitAppSqliteDatabaseHelper sqliteDatabaseHelper = new InitAppSqliteDatabaseHelper();
        SalesAndTransactionsOnlineDatabaseHelper salesAndTransactionsOnlineDatabaseHelper = new SalesAndTransactionsOnlineDatabaseHelper();
        DataTable usersDataTable, nomal;
        private void HomeDashboard_Load(object sender, EventArgs e)
        {
            synTxt.Text = "";
            nomal = sqliteDatabaseHelper.SelectDataFromLocalDBBranch();
            toggleMenuButton(dashboardBtn);
            openChildForm(new DashboardUI());
            openFormTitle.Text = "Dashboard";
            try
            {
                DataTable dt = usersSqliteDatabaseHelper.getLoggedInUser();
                userName.Text = dt.Rows[0]["username"].ToString().ToUpper();
                idLabel.Text = nomal.Rows[0]["branch_unique_id"].ToString();
            }catch (Exception ex)
            {

            }
           
        }
        FontAwesome.Sharp.IconButton activeButton = null;
        private void toggleMenuButton(FontAwesome.Sharp.IconButton pressedButton)
        {
            if(activeButton != null)
            {
                activeButton.ForeColor = Color.White;
                activeButton.BackColor = Color.Transparent;
                activeButton.IconColor = Color.White;
                activeButton = null;
            }
            activeButton = pressedButton;
            activeButton.BackColor = Color.White;
            activeButton.ForeColor = Color.Green;
            activeButton.IconColor = Color.Green;

        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(childForm);
            childFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

       
        private void HomeDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (usersSqliteDatabaseHelper.deleteUserSectionInfoFromLocalDB())
            {
                Application.Exit();
            }
            Application.Exit();
        }

        private void usersButton_Click(object sender, EventArgs e)
        {
            toggleMenuButton(usersButton);
            openChildForm(new Main_Users_Auth_UI());
            openFormTitle.Text = "Staff";
        }

        private void productsBtn_Click(object sender, EventArgs e)
        {
            if(videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                {
                    videoCaptureDevice.Stop();
                }
            }
            toggleMenuButton(productsBtn);
            openChildForm(new Products_Dashboard_UI());
            openFormTitle.Text = "Products";
        }

        private void salesBtn_Click(object sender, EventArgs e)
        {
            toggleMenuButton(salesBtn);
            openChildForm(new Sales_Main_UI());
            // new Sales_Main_UI().ShowDialog();
            openFormTitle.Text = "Sales";
        }

        private void transactionMenuBtn_Click(object sender, EventArgs e)
        {
            toggleMenuButton(transactionMenuBtn);
            openChildForm(new Transactions_UI());
            openFormTitle.Text = "Transactions";
        }

        private void reportMenuBtn_Click(object sender, EventArgs e)
        {
            toggleMenuButton(reportMenuBtn);
            openChildForm(new Main_Report_UI());
            openFormTitle.Text = "Reports";
        }

        private void syncBtn_Click(object sender, EventArgs e)
        {
            bool is_sync = false;
            synTxt.Text = "Data Is Synching .....";
            usersDataTable = generalLocalDatabase.selectNotOnlineData("users");
            if(usersDataTable != null)
            {
                for(int i = 0; i < usersDataTable.Rows.Count; i++)
                {
                    usersGetterAndSettter.username = usersDataTable.Rows[i]["username"].ToString();
                    usersGetterAndSettter.first_name = usersDataTable.Rows[i]["first_name"].ToString();
                    usersGetterAndSettter.last_name = usersDataTable.Rows[i]["last_name"].ToString();
                    usersGetterAndSettter.email = usersDataTable.Rows[i]["email"].ToString();
                    usersGetterAndSettter.password = usersDataTable.Rows[i]["password"].ToString();
                    usersGetterAndSettter.is_staff = int.Parse(usersDataTable.Rows[i]["is_staff"].ToString());
                    usersGetterAndSettter.contact = usersDataTable.Rows[i]["contact"].ToString();
                    usersGetterAndSettter.joined = DateTime.Parse(usersDataTable.Rows[i]["joined"].ToString());
                    usersGetterAndSettter.app_id = usersDataTable.Rows[i]["unique_id"].ToString();
                    usersGetterAndSettter.id = int.Parse(usersDataTable.Rows[i]["id"].ToString());
                    usersGetterAndSettter.branch_id = usersDataTable.Rows[i]["branch_id"].ToString();
                    if (authDatabaseHelper.InsertUserInfoToOnlineDB(usersGetterAndSettter))
                    {
                        DataTable d = generalDatabaseOnline.getTheInsertIdFromOnlineDB("users", usersGetterAndSettter.app_id.ToString());
                        if(generalLocalDatabase.updateIdFromDB("users", int.Parse(d.Rows[0]["MAX ID"].ToString()), 1, usersGetterAndSettter.id))
                        {
                            is_sync = true;

                        }
                        else
                        {
                            is_sync = false;
                        }
                    }
                }
            }
            DataTable productsDataTable = generalLocalDatabase.selectNotOnlineData("products");
            if(productsDataTable != null)
            {
                for(int i = 0; i < productsDataTable.Rows.Count; i++)
                {
                    productsGetterAndSetter.product_name = productsDataTable.Rows[i]["product_name"].ToString();
                    productsGetterAndSetter.cost_price = decimal.Parse(productsDataTable.Rows[i]["cost_price"].ToString());
                    productsGetterAndSetter.total_cost_price = decimal.Parse(productsDataTable.Rows[i]["total_cost_price"].ToString());
                    productsGetterAndSetter.selling_price = decimal.Parse(productsDataTable.Rows[i]["selling_price"].ToString());
                    productsGetterAndSetter.total_selling_price = decimal.Parse(productsDataTable.Rows[i]["total_selling_price"].ToString());
                    productsGetterAndSetter.quantity = int.Parse(productsDataTable.Rows[i]["quantity"].ToString());
                    productsGetterAndSetter.id = int.Parse(productsDataTable.Rows[i]["id"].ToString());
                    productsGetterAndSetter.profit = decimal.Parse(productsDataTable.Rows[i]["profit"].ToString());
                    productsGetterAndSetter.total_profit = decimal.Parse(productsDataTable.Rows[i]["total_profit"].ToString());
                    productsGetterAndSetter.description = productsDataTable.Rows[i]["product_description"].ToString();
                    productsGetterAndSetter.status = productsDataTable.Rows[i]["status"].ToString();
                    productsGetterAndSetter.barcode = productsDataTable.Rows[i]["barcode"].ToString();
                    productsGetterAndSetter.unique_id = productsDataTable.Rows[i]["unique_id"].ToString();
                    productsGetterAndSetter.branch_id = productsDataTable.Rows[i]["branch_id"].ToString();
                    productsGetterAndSetter.added_by = productsDataTable.Rows[i]["added_by"].ToString();
                    productsGetterAndSetter.shell = productsDataTable.Rows[i]["shell"].ToString();
                    productsGetterAndSetter.updated_at = DateTime.Parse(productsDataTable.Rows[i]["updated_at"].ToString());
                    productsGetterAndSetter.date = DateTime.Parse(productsDataTable.Rows[i]["added_at"].ToString());
                    if (productsOnlineDatabaseHelper.insertProductsToOnlineDB(productsGetterAndSetter))
                    {
                        DataTable d = generalDatabaseOnline.getTheInsertIdFromOnlineDB("products", productsGetterAndSetter.unique_id.ToString());
                        if (generalLocalDatabase.updateIdFromDB("products", int.Parse(d.Rows[0]["MAX ID"].ToString()), 1, productsGetterAndSetter.id))
                        {
                            is_sync = true;

                        }
                        else
                        {
                            is_sync = false;
                        }
                    }
                }
            }
            DataTable salesDataTable = generalLocalDatabase.selectNotOnlineData("sales");
            if(salesDataTable != null)
            {
                for(int i = 0; i < salesDataTable.Rows.Count; i++)
                {
                    salesGetterAndSetter.product_name = salesDataTable.Rows[i]["product_name"].ToString();
                    salesGetterAndSetter.quantity = int.Parse(salesDataTable.Rows[i]["quantity"].ToString());
                    salesGetterAndSetter.product_id = int.Parse(salesDataTable.Rows[i]["product_id"].ToString());
                    salesGetterAndSetter.unit_price = salesDataTable.Rows[i]["unit_price"].ToString();
                    salesGetterAndSetter.unique_id = salesDataTable.Rows[i]["unique_id"].ToString();
                    salesGetterAndSetter.branch_id = salesDataTable.Rows[i]["branch_id"].ToString();
                    salesGetterAndSetter.total_price = decimal.Parse(salesDataTable.Rows[i]["total_price"].ToString());
                    salesGetterAndSetter.id = int.Parse(salesDataTable.Rows[i]["id"].ToString());
                    salesGetterAndSetter.sales_by = salesDataTable.Rows[i]["sales_by"].ToString();
                    salesGetterAndSetter.date_to_show = salesDataTable.Rows[i]["date_to_show"].ToString();
                    salesGetterAndSetter.transaction_id = salesDataTable.Rows[i]["transaction_id"].ToString();
                    salesGetterAndSetter.date = DateTime.Parse(salesDataTable.Rows[i]["date"].ToString());
                    if (salesAndTransactionsOnlineDatabaseHelper.insertSalesIntoOnlineDB(salesGetterAndSetter))
                    {
                        DataTable d = generalDatabaseOnline.getTheInsertIdFromOnlineDB("sales", salesGetterAndSetter.unique_id.ToString());
                        if (generalLocalDatabase.updateIdFromDBForSalesAndTrans("sales", int.Parse(d.Rows[0]["MAX ID"].ToString()), 1, salesGetterAndSetter.id))
                        {
                            is_sync = true;
                        }
                        else
                        {
                            is_sync = false;
                        }
                    }
                }
            }
            DataTable transactionsDataTable = generalLocalDatabase.selectNotOnlineData("transactions");
            if (transactionsDataTable != null)
            {
                for (int i = 0; i < transactionsDataTable.Rows.Count; i++)
                {
                    
                    salesGetterAndSetter.quantity = int.Parse(transactionsDataTable.Rows[i]["quantity"].ToString());
                    salesGetterAndSetter.unit_price = transactionsDataTable.Rows[i]["unit_price"].ToString();
                    salesGetterAndSetter.unique_id = transactionsDataTable.Rows[i]["unique_id"].ToString();
                    salesGetterAndSetter.branch_id = transactionsDataTable.Rows[i]["branch_id"].ToString();
                    salesGetterAndSetter.total_price = decimal.Parse(transactionsDataTable.Rows[i]["total_price"].ToString());
                    salesGetterAndSetter.id = int.Parse(transactionsDataTable.Rows[i]["id"].ToString());
                    salesGetterAndSetter.sales_by = transactionsDataTable.Rows[i]["sales_by"].ToString();
                    salesGetterAndSetter.date_to_show = transactionsDataTable.Rows[i]["date_to_show"].ToString();
                    salesGetterAndSetter.transaction_id = transactionsDataTable.Rows[i]["transaction_id"].ToString();
                    salesGetterAndSetter.date = DateTime.Parse(transactionsDataTable.Rows[i]["date"].ToString());
                    if (salesAndTransactionsOnlineDatabaseHelper.insertTransactionsIntoOnlineDB(salesGetterAndSetter))
                    {
                        DataTable d = generalDatabaseOnline.getTheInsertIdFromOnlineDB("transactions", salesGetterAndSetter.unique_id.ToString());
                        if (generalLocalDatabase.updateIdFromDBForSalesAndTrans("transactions", int.Parse(d.Rows[0]["MAX ID"].ToString()), 1, salesGetterAndSetter.id))
                        {
                            is_sync = true;

                        }
                        else
                        {
                            is_sync = false;
                        }
                    }
                }
            }
            DataTable suplier = generalLocalDatabase.selectNotOnlineData("suppliers");
            if (suplier != null)
            {
                for (int i = 0; i < suplier.Rows.Count; i++)
                { 
                    suppliersGetterAndSetter.supplier_name = suplier.Rows[i]["supplier_name"].ToString();
                    suppliersGetterAndSetter.supplier_location = suplier.Rows[i]["supplier_location"].ToString();
                    suppliersGetterAndSetter.supplier_address = suplier.Rows[i]["supplier_address"].ToString();
                    suppliersGetterAndSetter.branch_id = suplier.Rows[i]["branch_id"].ToString();
                    suppliersGetterAndSetter.supplier_contact = suplier.Rows[i]["supplier_contact"].ToString();
                    suppliersGetterAndSetter.id = int.Parse(suplier.Rows[i]["id"].ToString());
                    suppliersGetterAndSetter.unique_id = suplier.Rows[i]["unique_id"].ToString();
                    suppliersGetterAndSetter.date = DateTime.Parse(suplier.Rows[i]["date"].ToString());
                    if (supplierOnlineDB.insertSupplierIntoLocalDB(suppliersGetterAndSetter))
                    {
                        DataTable d = generalDatabaseOnline.getTheInsertIdFromOnlineDB("suppliers", suppliersGetterAndSetter.unique_id.ToString());
                        if (generalLocalDatabase.updateIdFromDBForSalesAndTrans("suppliers", int.Parse(d.Rows[0]["MAX ID"].ToString()), 1, suppliersGetterAndSetter.id))
                        {
                            is_sync = true;

                        }
                        else
                        {
                            is_sync = false;
                        }
                    }
                }
            }
            DataTable vendorDetails = generalLocalDatabase.selectNotOnlineData("vendor_details");
            if (vendorDetails != null)
            {
                for (int i = 0; i < vendorDetails.Rows.Count; i++)
                {

                    vendorDetailsGS.vendor_name = vendorDetails.Rows[i]["vendor"].ToString();
                    vendorDetailsGS.added_by = vendorDetails.Rows[i]["added_by"].ToString();
                    vendorDetailsGS.amount = decimal.Parse(vendorDetails.Rows[i]["amount"].ToString());
                    vendorDetailsGS.branch_id = vendorDetails.Rows[i]["branch_id"].ToString();
                    vendorDetailsGS.part_payment_amount = decimal.Parse(vendorDetails.Rows[i]["part_payment_amount"].ToString());
                    vendorDetailsGS.id = int.Parse(vendorDetails.Rows[i]["id"].ToString());
                    vendorDetailsGS.unique_id = vendorDetails.Rows[i]["unique_id"].ToString();
                    vendorDetailsGS.status = vendorDetails.Rows[i]["status"].ToString();
                    vendorDetailsGS.updated_at = DateTime.Parse(vendorDetails.Rows[i]["updated_at"].ToString());
                    vendorDetailsGS.added_at = DateTime.Parse(vendorDetails.Rows[i]["added_at"].ToString());
                    if (vendorDetailOnlineDB.insertVendorDetailToLocalDB(vendorDetailsGS))
                    {
                        DataTable d = generalDatabaseOnline.getTheInsertIdFromOnlineDB("vendor_details", vendorDetailsGS.unique_id.ToString());
                        if (generalLocalDatabase.updateIdFromDBForSalesAndTrans("vendor_details", int.Parse(d.Rows[0]["MAX ID"].ToString()), 1, vendorDetailsGS.id))
                        {
                            is_sync = true;

                        }
                        else
                        {
                            is_sync = false;
                        }
                    }
                }
            }
            if (is_sync)
            {
                synTxt.Text = "Sync Completed Successfully";
            }
            else
            {
                synTxt.Text = "Sync Could Not Be Done";
            }
        }

        private void supplierMenuBtn_Click(object sender, EventArgs e)
        {
            toggleMenuButton(supplierMenuBtn);
            openChildForm(new Supplier_Main_UI());
            openFormTitle.Text = "Supplier";
        }

        private void stockMenuBtn_Click(object sender, EventArgs e)
        {
            toggleMenuButton(stockMenuBtn);
            openChildForm(new Products_Details_UI(true));
            openFormTitle.Text = "Stock";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            toggleMenuButton(dashboardBtn);
            openChildForm(new DashboardUI());
            openFormTitle.Text = "Dashboard";
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            if (usersSqliteDatabaseHelper.deleteUserSectionInfoFromLocalDB())
            {
                this.Hide();
                new Login_User_UI().Show();
            }
        }
    }
}
