using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThinkCE_Store_Management_System.DATABASE_HELPER;
using ThinkCE_Store_Management_System.DATABASE_HELPER.Auth;
using ThinkCE_Store_Management_System.DATABASE_HELPER.Products;
using ThinkCE_Store_Management_System.DATABASE_HELPER.Sales;
using ThinkCE_Store_Management_System.GETTERS_AND_SETTERS.Auth;
using ThinkCE_Store_Management_System.GETTERS_AND_SETTERS.Products;
using ThinkCE_Store_Management_System.GETTERS_AND_SETTERS.Sales;
using ThinkCE_Store_Management_System.GETTERS_AND_SETTERS.Suppliers;
using ThinkCE_Store_Management_System.SQLITE_DATABASE_HELPER;

namespace ThinkCE_Store_Management_System.MAIN_ADMIN.UI.Supplier
{
    public partial class Supplier_Order_Admin_UI : Form
    {
        public Supplier_Order_Admin_UI()
        {
            InitializeComponent();
        }
        
        VendorDetailsGS vendorDetailsGS = new VendorDetailsGS();
        VendorDetailOnlineDBHelper vendorDetailOnlineDB = new VendorDetailOnlineDBHelper();
        SupplierOnlineDBHelper supplierOnlineDB = new SupplierOnlineDBHelper();
       

        DataTable transactions;
        InitAppDatabaseHelper initAppDatabaseHelper = new InitAppDatabaseHelper();
        AuthDatabaseHelper authDatabase = new AuthDatabaseHelper();
        
        InitAppSqliteDatabaseHelper init = new InitAppSqliteDatabaseHelper();
        SalesAndTransactionsOnlineDatabaseHelper salesAndTransactions = new SalesAndTransactionsOnlineDatabaseHelper();
        
        DataTable branchDt;
        
        DataTable initDt;
        string branch_id = "";
        string branch_location = "";
        string unique_id = "";
        private void Supplier_Order_Admin_UI_Load(object sender, EventArgs e)
        {
            initDt = init.SelectDataFromLocalDBToCompareInitApp();
            if (initDt != null)
            {
                if (initDt.Rows.Count > 0)
                {
                    unique_id = initDt.Rows[0]["unique_id"].ToString();
                    branchDt = initAppDatabaseHelper.SelectDataFromOnlineDBToCompareBranch(unique_id);
                    if (branchDt != null)
                    {
                        if (branchDt.Rows.Count > 0)
                        {
                            selectedBranchCB.DataSource = branchDt;
                            selectedBranchCB.DisplayMember = "branch_name";
                            selectedBranchCB.ValueMember = "branch_unique_id";
                        }
                    }
                }

            }
        }

        private void selectedBranchCB_SelectedValueChanged(object sender, EventArgs e)
        {
            branch_id = selectedBranchCB.SelectedValue.ToString();
            try
            {
                DataTable bDT = initAppDatabaseHelper.SelectDataFromOnlineDBBranch(unique_id, branch_id);
                branch_location = bDT.Rows[0]["branch_location"].ToString();
            }
            catch (Exception)
            {

            }
            selectedIdTxt.Text = branch_id;
            selectedLocationTxt.Text = branch_location;
            
            transactions = vendorDetailOnlineDB.getVendorDetailsDataFromLocalDB(unique_id, branch_id);
            vDetailDataGridview.DataSource = transactions;
        }
    }
}
