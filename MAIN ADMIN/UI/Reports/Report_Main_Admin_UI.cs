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
using ThinkCE_Store_Management_System.DATABASE_HELPER.Stock;
using ThinkCE_Store_Management_System.MAIN_ADMIN.Reports;
using ThinkCE_Store_Management_System.MAIN_ADMIN.UI.Reports;
using ThinkCE_Store_Management_System.SQLITE_DATABASE_HELPER;

namespace ThinkCE_Store_Management_System.MAIN_ADMIN.UI
{
    public partial class Report_Main_Admin_UI : Form
    {
        public Report_Main_Admin_UI()
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
        ReportSummaryOnlineDBHelper reportSummary = new ReportSummaryOnlineDBHelper();
        private void viewSalesReportBtn_Click(object sender, EventArgs e)
        {
            new Sales_Reports_Detail_Admin_UI().ShowDialog();
        }

        private void transactionDetailBtn_Click(object sender, EventArgs e)
        {
            new Transaction_Report_UI().ShowDialog();
        }

        private void stockReport_Click(object sender, EventArgs e)
        {
            new Stock_Report_Detail_UI().ShowDialog();
        }
        DataTable ts, ms, ys, ta, tas, na, tps, tstock, tshort, todayT, monthT, yearT;

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
            getAll();
        }

        private void Report_Main_Admin_UI_Load(object sender, EventArgs e)
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
            getAll();
        }
        private void getAll()
        {
            String[] mountArray = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            int month = int.Parse(DateTime.Now.Month.ToString());

            ts = reportSummary.getTodaySales(DateTime.Now.ToLongDateString(), unique_id, branch_id);
            ys = reportSummary.getThisYearSales(DateTime.Now.Year.ToString(), unique_id, branch_id);
            ms = reportSummary.getThisMonthSales(mountArray[month - 1], DateTime.Now.Year.ToString(), unique_id, branch_id);
            ta = reportSummary.getTotalStaff(unique_id, branch_id);
            tas = reportSummary.getTotalAdminStaff(unique_id, branch_id);
            na = reportSummary.getTotalNonAdminStaff(unique_id, branch_id);
            tps = reportSummary.getTodayProductSold(DateTime.Now.ToLongDateString(), unique_id, branch_id);
            tstock = reportSummary.getTotalProducts(unique_id, branch_id);
            tshort = reportSummary.getShortageProducts(unique_id, branch_id);

            todayT = reportSummary.getTodayTransaction(DateTime.Now.ToLongDateString(), unique_id, branch_id);
            yearT = reportSummary.getThisYearTransactions(DateTime.Now.Year.ToString(), unique_id, branch_id);
            monthT = reportSummary.getThisMonthTransactions(mountArray[month - 1], DateTime.Now.Year.ToString(), unique_id, branch_id);
            try
            {
                todaySales.Text = "GHS " + ts.Rows[0]["SALES"].ToString();
                monthSales.Text = "GHS " + ms.Rows[0]["SALES"].ToString();
                yearSales.Text = "GHS " + ys.Rows[0]["SALES"].ToString();
                tStaff.Text = ta.Rows[0]["STAFFS"].ToString();
                aStaff.Text = tas.Rows[0]["STAFFS"].ToString();
                nAStaff.Text = na.Rows[0]["STAFFS"].ToString();
                nOfStock.Text = tstock.Rows[0]["TOTAL"].ToString();
                nOfStockSold.Text = tps.Rows[0]["TOTAL"].ToString();
                totalShortage.Text = tshort.Rows[0]["TOTAL"].ToString();
                ttt.Text = todayT.Rows[0]["TRANSACTIONS"].ToString();
                mtt.Text = monthT.Rows[0]["TRANSACTIONS"].ToString();
                ytt.Text = yearT.Rows[0]["TRANSACTIONS"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
