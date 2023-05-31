using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThinkCE_Store_Management_System.SQLITE_DATABASE_HELPER;

namespace ThinkCE_Store_Management_System.UI.Reports
{
    public partial class Main_Report_UI : Form
    {
        public Main_Report_UI()
        {
            InitializeComponent();
        }
        SalesAndTransactionsSqliteDatabaseHelper salesAndTransactions = new SalesAndTransactionsSqliteDatabaseHelper();
        ReportSummaryLocalDBHelper reportSummary = new ReportSummaryLocalDBHelper();
       
        private void guna2GroupBox2_Click(object sender, EventArgs e)
        {

        }

        private void viewSalesReportBtn_Click(object sender, EventArgs e)
        {
            new Report_Details_UI().ShowDialog();
        }

        private void transactionDetailBtn_Click(object sender, EventArgs e)
        {
            new Transaction_Report_Details_UI().ShowDialog();
        }

        private void stockReportBtn_Click(object sender, EventArgs e)
        {
            new Stock_Reports().ShowDialog();
        }
        DataTable ts, ms, ys, ta, tas, na, tps, tstock, tshort, todayT, monthT, yearT;
        private void Main_Report_UI_Load(object sender, EventArgs e)
        {
            String[] mountArray =  {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
            int month = int.Parse(DateTime.Now.Month.ToString());
            
            ts = reportSummary.getTodaySales(DateTime.Now.ToLongDateString());
            ys = reportSummary.getThisYearSales(DateTime.Now.Year.ToString());
            ms = reportSummary.getThisMonthSales(mountArray[month - 1], DateTime.Now.Year.ToString());
            ta = reportSummary.getTotalStaff();
            tas = reportSummary.getTotalAdminStaff();
            na = reportSummary.getTotalNonAdminStaff();
            tps = reportSummary.getTodayProductSold(DateTime.Now.ToLongDateString());
            tstock = reportSummary.getTotalProducts();
            tshort = reportSummary.getShortageProducts();

            todayT = reportSummary.getTodayTransaction(DateTime.Now.ToLongDateString());
            yearT = reportSummary.getThisYearTransactions(DateTime.Now.Year.ToString());
            monthT = reportSummary.getThisMonthTransactions(mountArray[month - 1], DateTime.Now.Year.ToString());
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
