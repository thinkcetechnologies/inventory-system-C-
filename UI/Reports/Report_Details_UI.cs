using DGVPrinterHelper;
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
using ThinkCE_Store_Management_System.GETTERS_AND_SETTERS;
using ThinkCE_Store_Management_System.SQLITE_DATABASE_HELPER;

namespace ThinkCE_Store_Management_System.UI.Reports
{
    public partial class Report_Details_UI : Form
    {
        public Report_Details_UI()
        {
            InitializeComponent();
        }
        DataTable transactions;
        SalesAndTransactionsSqliteDatabaseHelper salesAndTransactions = new SalesAndTransactionsSqliteDatabaseHelper();
        DGVPrinter dVGPrinter = new DGVPrinter();
        Ini_App_Getter_Setter ini_App_Getter_Setter = new Ini_App_Getter_Setter();
        InitAppDatabaseHelper initAppDatabaseHelper = new InitAppDatabaseHelper();
        InitAppSqliteDatabaseHelper initAppSqliteDatabaseHelper = new InitAppSqliteDatabaseHelper();
        private void Report_Details_UI_Load(object sender, EventArgs e)
        {
            dateDTP.Value = DateTime.Now;
            fromDTP.Value = DateTime.Now;
            toDTP.Value = DateTime.Now;
            transactions = salesAndTransactions.getAllSalesData();
            transDetailDataGridview.DataSource = transactions;
        
            calculateTheSelectedRow();
            
        }
        private void calculateTheSelectedRow()
        {

            decimal total_price = 0;
            decimal total_unit_price = 0;
            int quantity = 0;
            int totalEntry = 0;
            
            for (int i = 0; i < transactions.Rows.Count; i++)
            {
                total_price = total_price + decimal.Parse(transactions.Rows[i]["TOTAL PRICE"].ToString());
                total_unit_price = total_unit_price + decimal.Parse(transactions.Rows[i]["UNIT PRICE"].ToString());
                quantity = quantity + int.Parse(transactions.Rows[i]["QUANTITY"].ToString());
                totalEntry += 1;
            }
            tEntry.Text = totalEntry.ToString();
            tUnitPrice.Text = "GH₵ " + total_unit_price.ToString();
            tSalesPrice.Text = "GH₵ " + total_price.ToString();
            tQty.Text = quantity.ToString();
            dgvToPrint.DataSource = transactions;
        }

        private void deliverBtn_Click(object sender, EventArgs e)
        {
            string from = fromDTP.Value.ToString("yyyy-MM-dd");
            string to = toDTP.Value.ToString("yyyy-MM-dd");

            

                transactions = salesAndTransactions.getAllSalesDataByPeriod(from, to);
                transDetailDataGridview.DataSource = transactions;
                calculateTheSelectedRow();
           
        }

        private void yearCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void yearCB_SelectedValueChanged(object sender, EventArgs e)
        {
            transactions = salesAndTransactions.getAllSalesDataByYear(yearCB.Text);
            transDetailDataGridview.DataSource = transactions;
            calculateTheSelectedRow();
        }

        private void monthCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void monthCB_SelectedValueChanged(object sender, EventArgs e)
        {
            transactions = salesAndTransactions.getAllSalesDataByYear(monthCB.Text);
            transDetailDataGridview.DataSource = transactions;
            calculateTheSelectedRow();
        }

        private void productNameTextBox_TextChanged(object sender, EventArgs e)
        {
            transactions = salesAndTransactions.getAllSalesDataByNameOrId(productNameTextBox.Text);
            transDetailDataGridview.DataSource = transactions;
            calculateTheSelectedRow();
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            DataTable dt = initAppSqliteDatabaseHelper.SelectDataFromLocalDBToCompareInitApp();
            DataTable d = initAppSqliteDatabaseHelper.SelectDataFromLocalDBBranch();
            dVGPrinter.Title = dt.Rows[0]["company_name"].ToString() + "\n\n";
            dVGPrinter.SubTitle = d.Rows[0]["branch_name"].ToString();
            dVGPrinter.PageNumbers = true;
            dVGPrinter.PageNumberInHeader = false;
            dVGPrinter.PorportionalColumns = true;
            dVGPrinter.HeaderCellAlignment = StringAlignment.Near;
            dVGPrinter.Footer = "\r\n Total Numeber Of Entry:    " + tEntry.Text + "\r\n Total Quantity Sold:     " + tQty.Text + "\r\n Total Unit Price:      " + tUnitPrice.Text + "\r\n Total Sales Price:     " + tSalesPrice.Text + "";
            dVGPrinter.PageSettings.Landscape = true;
            dVGPrinter.PrintDataGridView(dgvToPrint);
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            transactions = salesAndTransactions.getAllSalesData();
            transDetailDataGridview.DataSource = transactions;
            calculateTheSelectedRow();
        }

        private void dateDTP_ValueChanged(object sender, EventArgs e)
        {
            transactions = salesAndTransactions.getAllSalesDataByDate(dateDTP.Text);
            transDetailDataGridview.DataSource = transactions;
            calculateTheSelectedRow();
        }
    }
}
