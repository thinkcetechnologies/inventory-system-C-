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
    public partial class Stock_Reports : Form
    {
        public Stock_Reports()
        {
            InitializeComponent();
        }
        DataTable stockDt;
        StockReportsDBHelper stockReportsDBHelper = new StockReportsDBHelper();
        private void Stock_Reports_Load(object sender, EventArgs e)
        {
            stockDt = stockReportsDBHelper.SelectMostPurchaseItem();
            stockDetailDataGridview.DataSource = stockDt;
            tEntry.Text = stockDt.Rows.Count.ToString();
        }

        private void mostPurchaseItem_CheckedChanged(object sender, EventArgs e)
        {
            stockDt = stockReportsDBHelper.SelectMostPurchaseItem();
            stockDetailDataGridview.DataSource = stockDt;
            tEntry.Text = stockDt.Rows.Count.ToString();
        }

        private void dateDTP_ValueChanged(object sender, EventArgs e)
        {
          
            if (mostPurchaseItem.Checked)
            {
                stockDt = stockReportsDBHelper.SelectMostPurchaseItemByDate(dateDTP.Text);
                stockDetailDataGridview.DataSource = stockDt;
                tEntry.Text = stockDt.Rows.Count.ToString();
            }
        
        }

        private void monthCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string year = DateTime.Now.Year.ToString();
            if (mostPurchaseItem.Checked)
            {
                stockDt = stockReportsDBHelper.SelectMostPurchaseItemByThisMonth(monthCB.Text, year);
                stockDetailDataGridview.DataSource = stockDt;
                tEntry.Text = stockDt.Rows.Count.ToString();
            }
        }

        private void yearCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mostPurchaseItem.Checked)
            {
                stockDt = stockReportsDBHelper.SelectMostPurchaseItemByDate(yearCB.Text);
                stockDetailDataGridview.DataSource = stockDt;
                tEntry.Text = stockDt.Rows.Count.ToString();
            }
        }

        private void shortage_CheckedChanged(object sender, EventArgs e)
        {
            if (shortage.Checked)
            {
                if(minQty.Value == 0 || minQty.Text == "")
                {
                    stockDt = stockReportsDBHelper.SelectShortageItem();
                    stockDetailDataGridview.DataSource = stockDt;
                    tEntry.Text = stockDt.Rows.Count.ToString();
                }
                else
                {
                    stockDt = stockReportsDBHelper.SelectShortageItem(int.Parse(minQty.Value.ToString()));
                    stockDetailDataGridview.DataSource = stockDt;
                    tEntry.Text = stockDt.Rows.Count.ToString();
                }
            }
        }

        private void mostExpensive_CheckedChanged(object sender, EventArgs e)
        {
            stockDt = stockReportsDBHelper.SelectExpensiveItem();
            stockDetailDataGridview.DataSource = stockDt;
            tEntry.Text = stockDt.Rows.Count.ToString();
        }

        private void mostQuantize_CheckedChanged(object sender, EventArgs e)
        {
            stockDt = stockReportsDBHelper.SelectQuantizedItem();
            stockDetailDataGridview.DataSource = stockDt;
            tEntry.Text = stockDt.Rows.Count.ToString();
        }

        private void cheapItem_CheckedChanged(object sender, EventArgs e)
        {
            stockDt = stockReportsDBHelper.SelectCheapestItem();
            stockDetailDataGridview.DataSource = stockDt;
            tEntry.Text = stockDt.Rows.Count.ToString();
        }

        private void deliverBtn_Click(object sender, EventArgs e)
        {

        }

        private void minQty_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
