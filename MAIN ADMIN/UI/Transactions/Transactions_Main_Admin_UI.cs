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
using ThinkCE_Store_Management_System.UI.Transactions;

namespace ThinkCE_Store_Management_System.MAIN_ADMIN.Transactions
{
    public partial class Transactions_Main_Admin_UI : Form
    {
        public Transactions_Main_Admin_UI()
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
        private void Transactions_Main_Admin_UI_Load(object sender, EventArgs e)
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
            transac.Checked = true;
            if (branch_id != "")
            {
                transactions = salesAndTransactions.getAllTransactionData(unique_id, branch_id);
                transDetailDataGridview.DataSource = transactions;
            }
            calculateTheSelectedRow();
        }
        private void calculateTheSelectedRow()
        {

            decimal total_price = 0;
            decimal total_unit_price = 0;
            int quantity = 0;
            int totalEntry = 0;
            if (sales.Checked || transac.Checked)
            {
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
            if (sales.Checked)
            {
                transactions = salesAndTransactions.getAllSalesData(unique_id, branch_id);
                transDetailDataGridview.DataSource = transactions;
                calculateTheSelectedRow();
            }
            if (transac.Checked)
            {
                transactions = salesAndTransactions.getAllTransactionData(unique_id, branch_id);
                transDetailDataGridview.DataSource = transactions;
                calculateTheSelectedRow();
            }
            
           
        }

        private void transac_CheckedChanged(object sender, EventArgs e)
        {
            if (transac.Checked)
            {
                transactions = salesAndTransactions.getAllTransactionData(unique_id, branch_id);
                transDetailDataGridview.DataSource = transactions;
                calculateTheSelectedRow();
            }
        }

        private void sales_CheckedChanged(object sender, EventArgs e)
        {
            if (sales.Checked)
            {
                transactions = salesAndTransactions.getAllSalesData(unique_id, branch_id);
                transDetailDataGridview.DataSource = transactions;
                calculateTheSelectedRow();
            }
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            new Transaction_Full_Screen(transactions).ShowDialog();
        }

        private void deliverBtn_Click(object sender, EventArgs e)
        {
            string from = fromDTP.Value.ToString("yyyy-MM-dd");
            string to = toDTP.Value.ToString("yyyy-MM-dd");

            if (sales.Checked)
            {

                transactions = salesAndTransactions.getAllSalesDataByPeriod(unique_id, branch_id, from, to);
                transDetailDataGridview.DataSource = transactions;
                calculateTheSelectedRow();
            }
            if (transac.Checked)
            {
                transactions = salesAndTransactions.getAllTransactionDataByPeriod(unique_id, branch_id, from, to);
                transDetailDataGridview.DataSource = transactions;
                calculateTheSelectedRow();
            }
        }

        private void yearCB_SelectedValueChanged(object sender, EventArgs e)
        {
            if (sales.Checked)
            {
                transactions = salesAndTransactions.getAllSalesDataByYear(unique_id, branch_id, yearCB.Text);
                transDetailDataGridview.DataSource = transactions;
                calculateTheSelectedRow();
            }
            else if (transac.Checked)
            {
                transactions = salesAndTransactions.getAllTransactionDataByYear(unique_id, branch_id, yearCB.Text);
                transDetailDataGridview.DataSource = transactions;
                calculateTheSelectedRow();
            }
        }

        private void monthCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sales.Checked)
            {
                transactions = salesAndTransactions.getAllSalesDataByYear(unique_id, branch_id, monthCB.Text);
                transDetailDataGridview.DataSource = transactions;
                calculateTheSelectedRow();
            }
            else if (transac.Checked)
            {
                transactions = salesAndTransactions.getAllTransactionDataByYear(unique_id, branch_id, monthCB.Text);
                transDetailDataGridview.DataSource = transactions;
                calculateTheSelectedRow();
            }
        }

        private void productNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (sales.Checked)
            {
                transactions = salesAndTransactions.getAllSalesDataByNameOrId(unique_id, branch_id, productNameTextBox.Text);
                transDetailDataGridview.DataSource = transactions;
                calculateTheSelectedRow();
            }
            if (transac.Checked)
            {
                transactions = salesAndTransactions.getAllTransactionDataByNameOrID(unique_id, branch_id, productNameTextBox.Text);
                transDetailDataGridview.DataSource = transactions;
                calculateTheSelectedRow();
            }
        }

        private void transDetailDataGridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                sDelivered.Text = transactions.Rows[row]["QUANTITY"].ToString();
                sUnitPrice.Text = "GH₵ " + transactions.Rows[row]["UNIT PRICE"].ToString();
                sTotalPrice.Text = "GH₵ " + transactions.Rows[row]["TOTAL PRICE"].ToString();
                sDate.Text = transactions.Rows[row]["DATE"].ToString();
                sTime.Text = transactions.Rows[row]["TIME"].ToString();
                sSalesBy.Text = transactions.Rows[row]["SALES BY"].ToString();
                if (sales.Checked)
                {
                    sName.Text = transactions.Rows[row]["PRODUCT NAME"].ToString();
                }
                else
                {
                    sName.Text = "?";
                }
            }
            catch (Exception)
            {

            }
        }

        private void yearCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateDTP_ValueChanged(object sender, EventArgs e)
        {
            if (sales.Checked)
            {
                transactions = salesAndTransactions.getAllSalesDataByYear(unique_id, branch_id, dateDTP.Text);
                transDetailDataGridview.DataSource = transactions;
                calculateTheSelectedRow();
            }
            if (transac.Checked)
            {
                transactions = salesAndTransactions.getAllTransactionDataByYear(unique_id, branch_id, dateDTP.Text);
                transDetailDataGridview.DataSource = transactions;
                calculateTheSelectedRow();
            }
        }

        private void getReturn_CheckedChanged(object sender, EventArgs e)
        {
            if (getReturn.Checked)
            {
                if (sales.Checked)
                {
                    transactions = salesAndTransactions.getAllReturnedSalesData(unique_id, branch_id);
                    transDetailDataGridview.DataSource = transactions;
                    calculateTheSelectedRow();
                    
                }
                if (transac.Checked)
                {
                    transactions = salesAndTransactions.getAllReturnedTransactionData(unique_id, branch_id);
                    transDetailDataGridview.DataSource = transactions;
                    calculateTheSelectedRow();
                   
                }
            }
            else
            {
                if (sales.Checked)
                {
                    transactions = salesAndTransactions.getAllSalesData(unique_id, branch_id);
                    transDetailDataGridview.DataSource = transactions;
                    calculateTheSelectedRow();
                    
                }
                if (transac.Checked)
                {
                    transactions = salesAndTransactions.getAllTransactionData(unique_id, branch_id);
                    transDetailDataGridview.DataSource = transactions;
                    calculateTheSelectedRow();
                   
                }
            }
        }
    }
}
