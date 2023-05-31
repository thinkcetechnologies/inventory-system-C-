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
using ThinkCE_Store_Management_System.DATABASE_HELPER.Products;
using ThinkCE_Store_Management_System.DATABASE_HELPER.Sales;
using ThinkCE_Store_Management_System.SQLITE_DATABASE_HELPER;

namespace ThinkCE_Store_Management_System.MAIN_ADMIN.Reports
{
    public partial class Sales_Reports_Detail_Admin_UI : Form
    {
        public Sales_Reports_Detail_Admin_UI()
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
        DataTable initDt;
        string branch_id = "";
        string branch_location = "";
        string unique_id = "";
        DGVPrinter dVGPrinter = new DGVPrinter();
        private void Sales_Reports_Detail_Admin_UI_Load(object sender, EventArgs e)
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
        string branch_name = "";
        private void selectedBranchCB_SelectedValueChanged(object sender, EventArgs e)
        {
            branch_id = selectedBranchCB.SelectedValue.ToString();
            try
            {
                DataTable bDT = initAppDatabaseHelper.SelectDataFromOnlineDBBranch(unique_id, branch_id);
                branch_location = bDT.Rows[0]["branch_location"].ToString();
                branch_name = bDT.Rows[0]["branch_name"].ToString();
            }
            catch (Exception)
            {

            }
            selectedIdTxt.Text = branch_id;
            selectedLocationTxt.Text = branch_location;
            transactions = salesAndTransactions.getAllSalesData(unique_id, branch_id);
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

        private void yearCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            transactions = salesAndTransactions.getAllSalesDataByYear(unique_id, branch_id, yearCB.Text);
            transDetailDataGridview.DataSource = transactions;
            calculateTheSelectedRow();
        }

        private void monthCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            transactions = salesAndTransactions.getAllSalesDataByYear(unique_id, branch_id, monthCB.Text);
            transDetailDataGridview.DataSource = transactions;
            calculateTheSelectedRow();
        }

        private void productNameTextBox_TextChanged(object sender, EventArgs e)
        {
            transactions = salesAndTransactions.getAllSalesDataByNameOrId(unique_id, branch_id, productNameTextBox.Text);
            transDetailDataGridview.DataSource = transactions;
            calculateTheSelectedRow();
        }

        private void deliverBtn_Click(object sender, EventArgs e)
        {
            string from = fromDTP.Value.ToString("yyyy-MM-dd");
            string to = toDTP.Value.ToString("yyyy-MM-dd");
            transactions = salesAndTransactions.getAllSalesDataByPeriod(unique_id, branch_id, from, to);
            transDetailDataGridview.DataSource = transactions;
            calculateTheSelectedRow();
           
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            dVGPrinter.Title = initDt.Rows[0]["company_name"].ToString() + "\n";
            dVGPrinter.SubTitle = branch_name;
            dVGPrinter.PageNumbers = true;
            dVGPrinter.PageNumberInHeader = false;
            dVGPrinter.PorportionalColumns = true;
            dVGPrinter.HeaderCellAlignment = StringAlignment.Near;
            dVGPrinter.Footer = "\r\n Total Numeber Of Entry:    " + tEntry.Text + "\r\n Total Quantity Sold:     " + tQty.Text + "\r\n Total Unit Price:      " + tUnitPrice.Text + "\r\n Total Sales Price:     " + tSalesPrice.Text + "";
            dVGPrinter.PageSettings.Landscape = true;
            dVGPrinter.PrintDataGridView(dgvToPrint);
        }
    }
}
