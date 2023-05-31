using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThinkCE_Store_Management_System.GETTERS_AND_SETTERS.Sales;
using ThinkCE_Store_Management_System.SQLITE_DATABASE_HELPER;

namespace ThinkCE_Store_Management_System.UI.Transactions
{
    public partial class Transactions_UI : Form
    {
        DataTable transactions;
        public Transactions_UI()
        {
            InitializeComponent();
        }
        SalesAndTransactionsSqliteDatabaseHelper salesAndTransactions = new SalesAndTransactionsSqliteDatabaseHelper();
        SalesGetterAndSetter salesGetterAndSetter = new SalesGetterAndSetter();
        decimal unitP = 0, totalP = 0;
        int id, tId, qty;
        private void Transactions_UI_Load(object sender, EventArgs e)
        {
            transac.Checked = true;
            dateDTP.Value = DateTime.Now;
            fromDTP.Value = DateTime.Now;
            toDTP.Value = DateTime.Now;
            calculateTheSelectedRow();
        }

        private void sales_CheckedChanged(object sender, EventArgs e)
        {
            if (sales.Checked)
            {
                transactions = salesAndTransactions.getAllSalesData();
                transDetailDataGridview.DataSource = transactions;
                calculateTheSelectedRow();
                labelTxt.Text = "Sales Details";
            }
           
        }

        private void transac_CheckedChanged(object sender, EventArgs e)
        {
            if (transac.Checked)
            {
                transactions = salesAndTransactions.getAllTransactionData();
                transDetailDataGridview.DataSource = transactions;
                calculateTheSelectedRow();
                labelTxt.Text = "Transactions Details";
            }
        }

        private void yearCB_SelectedValueChanged(object sender, EventArgs e)
        {
            if (sales.Checked)
            {
                transactions = salesAndTransactions.getAllSalesDataByYear(yearCB.Text);
                transDetailDataGridview.DataSource = transactions;
                calculateTheSelectedRow();
                labelTxt.Text = "Sales Details For " + yearCB.Text;
            }
            else if (transac.Checked)
            {
                transactions = salesAndTransactions.getAllTransactionDataByYear(yearCB.Text);
                transDetailDataGridview.DataSource = transactions;
                calculateTheSelectedRow();
                labelTxt.Text = "Transactions Details For " + yearCB.Text;
            }
            
        }

        private void monthCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void monthCB_SelectedValueChanged(object sender, EventArgs e)
        {
            if (sales.Checked)
            {
                transactions = salesAndTransactions.getAllSalesDataByYear(monthCB.Text);
                transDetailDataGridview.DataSource = transactions;
                calculateTheSelectedRow();
                labelTxt.Text = "Sales Details For " + monthCB.Text;
            }
            else if (transac.Checked)
            {
                transactions = salesAndTransactions.getAllTransactionDataByYear(monthCB.Text);
                transDetailDataGridview.DataSource = transactions;
                calculateTheSelectedRow();
                labelTxt.Text = "Transactions Details For " + monthCB.Text;
            }
        }
        private void calculateTheSelectedRow()
        {

            decimal total_price = 0;
            decimal total_unit_price = 0;
            int quantity = 0;
            int totalEntry = 0;
            if (sales.Checked || transac.Checked)
            {
                for(int i = 0; i < transactions.Rows.Count; i++)
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
        private void deliverBtn_Click(object sender, EventArgs e)
        {
            string from = DateTime.Parse(fromDTP.Text).ToString("yyyy-MM-dd");
            string to = toDTP.Value.ToString("yyyy-MM-dd");
           
            if (sales.Checked)
            {
                
                transactions = salesAndTransactions.getAllSalesDataByPeriod(from, to);
                transDetailDataGridview.DataSource = transactions;
                calculateTheSelectedRow();
                labelTxt.Text = "Sales Details For Period From " + fromDTP.Value.ToLongDateString() + " To " + toDTP.Value.ToLongDateString();
                labelTxt.Font = new Font("Mongolian Baiti", 11);
            }
            if (transac.Checked)
            {
                transactions = salesAndTransactions.getAllTransactionDataByPeriod(from, to);
                transDetailDataGridview.DataSource = transactions;
                calculateTheSelectedRow();
                labelTxt.Text = "Transactions Details For Period From " + fromDTP.Value.ToLongDateString() + " To " + toDTP.Value.ToLongTimeString();
                labelTxt.Font = new Font("Mongolian Baiti", 11);
            }

        }

        private void transDetailDataGridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                qty = int.Parse(transactions.Rows[row]["QUANTITY"].ToString());
                if (sales.Checked)
                {
                    id = int.Parse(transactions.Rows[row]["SALES ID"].ToString());
                }
                if (transac.Checked)
                {
                    id = int.Parse(transactions.Rows[row]["ID"].ToString());
                }
                tId = int.Parse(transactions.Rows[row]["TRANSACTION ID"].ToString());
                unitP = decimal.Parse(transactions.Rows[row]["UNIT PRICE"].ToString());
                totalP = decimal.Parse(transactions.Rows[row]["TOTAL PRICE"].ToString());
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

        private void productNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (sales.Checked)
            {
                transactions = salesAndTransactions.getAllSalesDataByNameOrId(productNameTextBox.Text);
                transDetailDataGridview.DataSource = transactions;
                calculateTheSelectedRow();

            }
            if (transac.Checked)
            {
                transactions = salesAndTransactions.getAllTransactionDataByNameOrID(productNameTextBox.Text);
                transDetailDataGridview.DataSource = transactions;
                calculateTheSelectedRow();
            }
        
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            new Transaction_Full_Screen(transactions).ShowDialog();
        }

        private void getReturn_CheckedChanged(object sender, EventArgs e)
        {
            if (getReturn.Checked)
            {
                if (sales.Checked)
                {
                    transactions = salesAndTransactions.getAllReturnedSalesData();
                    transDetailDataGridview.DataSource = transactions;
                    calculateTheSelectedRow();
                    labelTxt.Text = "Returned Sales Details ";
                }
                if (transac.Checked)
                {
                    transactions = salesAndTransactions.getAllReturnedTransactionData();
                    transDetailDataGridview.DataSource = transactions;
                    calculateTheSelectedRow();
                    labelTxt.Text = "Returned Transactions Details ";
                }
            }
            else
            {
                if (sales.Checked)
                {
                    transactions = salesAndTransactions.getAllSalesData();
                    transDetailDataGridview.DataSource = transactions;
                    calculateTheSelectedRow();
                    labelTxt.Text = "Sales Details";
                }
                if (transac.Checked)
                {
                    transactions = salesAndTransactions.getAllTransactionData();
                    transDetailDataGridview.DataSource = transactions;
                    calculateTheSelectedRow();
                    labelTxt.Text = "Transactions Details";
                }
            }
        }

        private void yearCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateDTP_ValueChanged(object sender, EventArgs e)
        {
            if (sales.Checked)
            {
                transactions = salesAndTransactions.getAllSalesDataByDate(dateDTP.Text);
                transDetailDataGridview.DataSource = transactions;
                calculateTheSelectedRow();
                labelTxt.Text = "Sales Details For " + dateDTP.Text;
            }
            if (transac.Checked)
            {
                transactions = salesAndTransactions.getAllTransactionDataByDate(dateDTP.Text);
                transDetailDataGridview.DataSource = transactions;
                calculateTheSelectedRow();
                labelTxt.Text = "Transactions Details For " + dateDTP.Text;
            }
        }

        private void saveReturnChangesBtn_Click(object sender, EventArgs e)
        {
            if (returnedCB.Checked)
            {
                salesGetterAndSetter.transaction_id = tId.ToString();
                salesGetterAndSetter.returned = 1;
                salesGetterAndSetter.unit_price = unitP.ToString();
                salesGetterAndSetter.total_price = totalP;
                salesGetterAndSetter.quantity = qty;
                salesGetterAndSetter.id = id;
                if (sales.Checked)
                {
                    if(totalP != 0 && unitP != 0)
                    {
                        if (salesAndTransactions.updateSalesForOneReturn(salesGetterAndSetter))
                        {
                            if (salesAndTransactions.insertTransactionsReturnsForQty(salesGetterAndSetter))
                            {
                                MessageBox.Show("Changes Saved Successfully");
                            }
                            else
                            {
                                MessageBox.Show("An Error Occured");
                            }
                        }
                        else
                        {
                            MessageBox.Show("An Error Occured!");
                        }
                    }
                }
                if (transac.Checked)
                {
                    if (totalP != 0 && unitP != 0)
                    {
                        if (salesAndTransactions.insertTransactionsReturns(salesGetterAndSetter))
                        {
                            if (salesAndTransactions.updateSalesForAllReturn(salesGetterAndSetter))
                            {
                                MessageBox.Show("Changes Saved Successfully");
                            }
                            else
                            {
                                MessageBox.Show("An Error Occured");
                            }
                        }
                        else
                        {
                            MessageBox.Show("An Error Occured!");
                        }
                    }
                }
            }
        }
    }
}
