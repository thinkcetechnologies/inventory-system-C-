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
using ThinkCE_Store_Management_System.DATABASE_HELPER.Sales;
using ThinkCE_Store_Management_System.DATABASE_HELPER.Stock;
using ThinkCE_Store_Management_System.SQLITE_DATABASE_HELPER;

namespace ThinkCE_Store_Management_System.MAIN_ADMIN.UI.Reports
{
    public partial class Stock_Report_Detail_UI : Form
    {
        public Stock_Report_Detail_UI()
        {
            InitializeComponent();
        }
        DataTable transactions;
        InitAppDatabaseHelper initAppDatabaseHelper = new InitAppDatabaseHelper();
        AuthDatabaseHelper authDatabase = new AuthDatabaseHelper();
        UsersSqliteDatabaseHelper usersSqliteDatabaseHelper = new UsersSqliteDatabaseHelper();
        InitAppSqliteDatabaseHelper init = new InitAppSqliteDatabaseHelper();
        SalesAndTransactionsOnlineDatabaseHelper salesAndTransactions = new SalesAndTransactionsOnlineDatabaseHelper();
        ProductsOnlineDatabaseHelper productsOnlineDatabaseHelper = new ProductsOnlineDatabaseHelper();
        DataTable branchDt;
        StockReportOnlineDBHelper stockReportOnlineDBHelper = new StockReportOnlineDBHelper();
        DataTable initDt;
        string branch_id = "";
        string branch_location = "";
        string unique_id = "";
        private void Stock_Report_Detail_UI_Load(object sender, EventArgs e)
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
            transactions = stockReportOnlineDBHelper.SelectMostPurchaseItem(unique_id, branch_id);
            stockDetailDataGridview.DataSource = transactions;
        }

        private void mostPurchaseItem_CheckedChanged(object sender, EventArgs e)
        {
            transactions = stockReportOnlineDBHelper.SelectMostPurchaseItem(unique_id, branch_id);
            stockDetailDataGridview.DataSource = transactions;
            tEntry.Text = transactions.Rows.Count.ToString();
        }

        private void mostQuantize_CheckedChanged(object sender, EventArgs e)
        {
            transactions = stockReportOnlineDBHelper.SelectQuantizedItem(unique_id, branch_id);
            stockDetailDataGridview.DataSource = transactions;
            tEntry.Text = transactions.Rows.Count.ToString();
        }

        private void shortage_CheckedChanged(object sender, EventArgs e)
        {
            if (shortage.Checked)
            {
                if (minQty.Value == 0 || minQty.Text == "")
                {
                    transactions = stockReportOnlineDBHelper.SelectShortageItem(unique_id, branch_id);
                    stockDetailDataGridview.DataSource = transactions;
                    tEntry.Text = transactions.Rows.Count.ToString();
                }
                else
                {
                    transactions = stockReportOnlineDBHelper.SelectShortageItem(unique_id, branch_id,int.Parse(minQty.Value.ToString()));
                    stockDetailDataGridview.DataSource = transactions;
                    tEntry.Text = transactions.Rows.Count.ToString();
                }
            }
        }
        private void mostExpensive_CheckedChanged(object sender, EventArgs e)
        {
            transactions = stockReportOnlineDBHelper.SelectExpensiveItem(unique_id, branch_id);
            stockDetailDataGridview.DataSource = transactions;
            tEntry.Text = transactions.Rows.Count.ToString();
        }

        private void cheapItem_CheckedChanged(object sender, EventArgs e)
        {
            transactions = stockReportOnlineDBHelper.SelectCheapestItem(unique_id, branch_id);
            stockDetailDataGridview.DataSource = transactions;
            tEntry.Text = transactions.Rows.Count.ToString();
        }

        private void deliverBtn_Click(object sender, EventArgs e)
        {
            string from = DateTime.Parse(fromDTP.Text).ToString("yyyy-MM-dd");
            string to = toDTP.Value.ToString("yyyy-MM-dd");
            if (mostPurchaseItem.Checked)
            {
                transactions = stockReportOnlineDBHelper.SelectMostPurchaseItemByPeriod(unique_id, branch_id, from, to);
                stockDetailDataGridview.DataSource = transactions;
                tEntry.Text = transactions.Rows.Count.ToString();
            }
        }

        private void yearCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mostPurchaseItem.Checked)
            {
                transactions = stockReportOnlineDBHelper.SelectMostPurchaseItemByDate(yearCB.Text, unique_id, branch_id);
                stockDetailDataGridview.DataSource = transactions;
                tEntry.Text = transactions.Rows.Count.ToString();
            }
        }

        private void monthCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string year = DateTime.Now.Year.ToString();
            if (mostPurchaseItem.Checked)
            {
                transactions = stockReportOnlineDBHelper.SelectMostPurchaseItemByThisMonth(unique_id, branch_id, monthCB.Text, year);
                stockDetailDataGridview.DataSource = transactions;
                tEntry.Text = transactions.Rows.Count.ToString();
            }
        }

        private void dateDTP_ValueChanged(object sender, EventArgs e)
        {
            if (mostPurchaseItem.Checked)
            {
                transactions = stockReportOnlineDBHelper.SelectMostPurchaseItemByDate(dateDTP.Text, unique_id, branch_id);
                stockDetailDataGridview.DataSource = transactions;
                tEntry.Text = transactions.Rows.Count.ToString();
            }
        }

        private void monthCB_SelectedValueChanged(object sender, EventArgs e)
        {
            string year = DateTime.Now.Year.ToString();
            if (mostPurchaseItem.Checked)
            {
                transactions = stockReportOnlineDBHelper.SelectMostPurchaseItemByThisMonth(unique_id, branch_id, monthCB.Text, year);
                stockDetailDataGridview.DataSource = transactions;
                tEntry.Text = transactions.Rows.Count.ToString();
            }
        }
    }
}
