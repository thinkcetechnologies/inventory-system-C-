using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThinkCE_Store_Management_System.DATABASE_HELPER.Auth;
using ThinkCE_Store_Management_System.DATABASE_HELPER.Products;
using ThinkCE_Store_Management_System.SQLITE_DATABASE_HELPER;

namespace ThinkCE_Store_Management_System.MAIN_ADMIN.UI.Products
{
    public partial class Products_Main_Admin_UI : Form
    {
        public Products_Main_Admin_UI()
        {
            InitializeComponent();
        }
        InitAppDatabaseHelper initAppDatabaseHelper = new InitAppDatabaseHelper();
        AuthDatabaseHelper authDatabase = new AuthDatabaseHelper();
        UsersSqliteDatabaseHelper usersSqliteDatabaseHelper = new UsersSqliteDatabaseHelper();
        InitAppSqliteDatabaseHelper init = new InitAppSqliteDatabaseHelper();
        ProductsOnlineDatabaseHelper productsOnlineDatabaseHelper = new ProductsOnlineDatabaseHelper();
        DataTable branchDt;
        DataTable initDt;
        string branch_id = "";
        string branch_location = "";
        string unique_id = "";
        private void Products_Main_Admin_UI_Load(object sender, EventArgs e)
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
            if (branch_id != "")
            {
                productsDetailDataGridview.DataSource = productsOnlineDatabaseHelper.selectProductsFromOnlineDBToDisplay(unique_id, branch_id);
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
            selectedLocation.Text = branch_location;
            productsDetailDataGridview.DataSource = productsOnlineDatabaseHelper.selectProductsFromOnlineDBToDisplay(unique_id, branch_id);
        }

        private void searchUserDetailTextBox_TextChanged(object sender, EventArgs e)
        {
            productsDetailDataGridview.DataSource = productsOnlineDatabaseHelper.searchProductsFromOnlineDBToDisplay(searchUserDetailTextBox.Text, unique_id, branch_id);
        }
    }
}
