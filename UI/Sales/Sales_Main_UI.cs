using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using Guna.UI2.WinForms;
using ThinkCE_Store_Management_System.GETTERS_AND_SETTERS.Products;
using ThinkCE_Store_Management_System.GETTERS_AND_SETTERS.Sales;
using ThinkCE_Store_Management_System.SQLITE_DATABASE_HELPER;
using USB_Barcode_Scanner;
using ZXing;

namespace ThinkCE_Store_Management_System.UI.Sales
{
    public partial class Sales_Main_UI : Form
    {
        public Sales_Main_UI()
        {
            InitializeComponent();
        }
        int qty = 1;
        decimal totalPrice = decimal.Parse("0.00");
        DataTable dataTable = new DataTable();
        int transactionId;
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        ProductsGetterAndSetter productsGetterAndSetter = new ProductsGetterAndSetter();
        UsersSqliteDatabaseHelper usersSqliteDatabaseHelper = new UsersSqliteDatabaseHelper();
        InitAppSqliteDatabaseHelper initAppSqliteDatabaseHelper = new InitAppSqliteDatabaseHelper();
        ProductsSqliteDatabaseHelper productsSqliteDatabaseHelper = new ProductsSqliteDatabaseHelper();
        SalesAndTransactionsSqliteDatabaseHelper SalesAndTransactionsSqliteDatabaseHelper = new SalesAndTransactionsSqliteDatabaseHelper();
        SalesGetterAndSetter salesGetterAndSetter = new SalesGetterAndSetter();
        DataTable dt, companyInfo, branchInfo;
        decimal p;
        int yOffSetForNext = 0;
        int irow;

        private void Sales_Main_UI_Load(object sender, EventArgs e)
        {

            BarcodeScanner barcodeScanner = new BarcodeScanner(barcodeTxt);
            barcodeScanner.BarcodeScanned += BarcodeScanner_BarcodeScanned;
            barcodeTxt.Focus();
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                {
                    videoCaptureDevice.Stop();
                }
            }
            dt = productsSqliteDatabaseHelper.selectProductsFromLocalDBToDisplay();
            productsDetailDataGridview.DataSource = dt;
            createDT();
            salesDate.Value = DateTime.Now;
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            try
            {
                foreach (FilterInfo item in filterInfoCollection)
                    camCBX.Items.Add(item.Name);
                camCBX.SelectedIndex = 0;
                captureCode();
            }
            catch (Exception)
            {

            }
            companyInfo = initAppSqliteDatabaseHelper.SelectDataFromLocalDBToCompareInitApp();
            branchInfo = initAppSqliteDatabaseHelper.SelectDataFromLocalDBBranch();
        }
        private void BarcodeScanner_BarcodeScanned(object sender, BarcodeScannerEventArgs e)
        {
            barcodeTxt.Text = e.Barcode;
        }
        private void calculateTotalPrice()
        {
            totalPrice = 0;
            if(dataTable.Rows.Count > 0)
            {
                for(int x = 0; x < dataTable.Rows.Count; x++)
                {
                    decimal price = decimal.Parse(dataTable.Rows[x]["TOTAL PRICE"].ToString());
                    totalPrice = totalPrice + price;
                }
                totalAmount.Value = totalPrice;
            }
        }
        private void captureCode()
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[camCBX.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }
        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            try
            {
                Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
                BarcodeReader reader = new BarcodeReader();
                var results = reader.Decode(bitmap);
                if (results != null)
                {
                    barcodeTxt.Invoke(new MethodInvoker(delegate ()
                    {
                        barcodeTxt.Text = results.ToString();
                    }
                    ));
                }
                barcodePic.Image = bitmap;
            }
            catch
            {

            }
            
        }

        private void createDT()
        {
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("NAME");
            dataTable.Columns.Add("-");
            dataTable.Columns.Add("QTY");
            dataTable.Columns.Add("+");
            dataTable.Columns.Add("UNIT PRICE");
            dataTable.Columns.Add("TOTAL PRICE");
            dataTable.Columns.Add("TOTAL Q");
            dataTable.Columns.Add("X");
            
            cartDataGridView.DataSource = dataTable;
        }
        private void cartDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 4)
            {
                try
                {
                    int row = e.RowIndex;
                    int q = int.Parse(dataTable.Rows[row]["QTY"].ToString());
                    decimal p = decimal.Parse(dataTable.Rows[row]["UNIT PRICE"].ToString());
                    int qT = int.Parse(dataTable.Rows[row]["TOTAL Q"].ToString());
                    if(q < qT)
                        q++;
                    dataTable.Rows[row]["TOTAL PRICE"] = (q * p).ToString();
                    dataTable.Rows[row]["QTY"] = q.ToString();
                    cartDataGridView.DataSource = dataTable;
                    calculateTotalPrice();
                }
                catch (Exception)
                {

                }    
            }
            else if (e.ColumnIndex == 2)
            {
                try
                {
                    int row = e.RowIndex;
                    int q = int.Parse(dataTable.Rows[row]["QTY"].ToString());
                    decimal p = decimal.Parse(dataTable.Rows[row]["UNIT PRICE"].ToString());
                    if(q > 1)
                        q--;
                    dataTable.Rows[row]["TOTAL PRICE"] = (q * p).ToString();
                    dataTable.Rows[row]["QTY"] = q.ToString();
                    cartDataGridView.DataSource = dataTable;
                    calculateTotalPrice();
                }
                catch (Exception)
                {
        
                }
            }
            else if (e.ColumnIndex == 8)
            {
                try
                {
                    int row = e.RowIndex;
                    dataTable.Rows.RemoveAt(row);
                    cartDataGridView.DataSource = dataTable;
                    calculateTotalPrice();
                }
                catch (Exception)
                {

                }
            }
            try
            {
                irow = e.RowIndex;
                addQuantity.Value = int.Parse(dataTable.Rows[irow]["QTY"].ToString());
                p = decimal.Parse(dataTable.Rows[irow]["UNIT PRICE"].ToString());
                totalQ = int.Parse(dataTable.Rows[irow]["TOTAL Q"].ToString());
            }
            catch 
            {
               
            }
        }
        int totalQ = 0;
        private void Sales_Main_UI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                {
                    videoCaptureDevice.Stop();
                }
            }
        }
        int quantity = 0;
        private void productsDetailDataGridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                string product_name = productsDetailDataGridview.Rows[row].Cells[1].Value.ToString();
                string price = productsDetailDataGridview.Rows[row].Cells[4].Value.ToString();
                string id = productsDetailDataGridview.Rows[row].Cells[0].Value.ToString();
                string qity = productsDetailDataGridview.Rows[row].Cells[3].Value.ToString();
                if (!isAlreadyInserted(id))
                {
                    dataTable.Rows.Add(id, product_name, "<", qty, ">", price, qty * decimal.Parse(price), qity, "X");
                }
                cartDataGridView.DataSource = dataTable;
                calculateTotalPrice();
            }
            catch (Exception)
            {

            } 
        }
        private bool isAlreadyInserted(string id)
        {
            for(int x = 0; x < dataTable.Rows.Count; x++)
            {
                try
                {
                    if (dataTable.Rows[x]["ID"].ToString() == id)
                    {
                        int q = int.Parse(dataTable.Rows[x]["QTY"].ToString());
                        decimal p = decimal.Parse(dataTable.Rows[x]["UNIT PRICE"].ToString());
                        int qT = int.Parse(dataTable.Rows[x]["TOTAL Q"].ToString());
                        if (q < qT)
                            q++;
                        dataTable.Rows[x]["TOTAL PRICE"] = (q * p).ToString();
                        dataTable.Rows[x]["QTY"] = q.ToString();
                        cartDataGridView.DataSource = dataTable;
                        calculateTotalPrice();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } 
            }
            return false;
        }
        private void barcodeTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dt = productsSqliteDatabaseHelper.selectProductsFromLocalDBByBarcode(barcodeTxt.Text);
                
                string product_name = dt.Rows[0]["PRODUCT NAME"].ToString();
                string price = dt.Rows[0]["SELLING PRICE"].ToString();
                string id = dt.Rows[0]["PRODUCT ID"].ToString();
                string qt = dt.Rows[0]["QUANTITY"].ToString();
                if (!isAlreadyInserted(id))
                {
                    dataTable.Rows.Add(id, product_name, "<", qty, ">", price, qty * decimal.Parse(price), qt, "X");
                }
                
                cartDataGridView.DataSource = dataTable;
                calculateTotalPrice();
            }
            catch (Exception)
            {

            }
            
        }
        private void recievedAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (decimal.Parse(recievedAmount.Text) > totalAmount.Value)
                {
                    changeAmount.Value = decimal.Parse(recievedAmount.Text) - totalAmount.Value;
                }
                else
                {
                    changeAmount.Value = 0;
                }
            }
            catch (Exception)
            {

            }
        }
        private void deliverBtn_Click(object sender, EventArgs e)
        {
            if(recievedAmount.Text != "")
            {
                if (decimal.Parse(recievedAmount.Text) >= totalAmount.Value)
                {
                    DataTable loggedInUser = usersSqliteDatabaseHelper.getLoggedInUser();
                    Random random = new Random();
                    transactionId = random.Next(100000000, 900000000);
                    string branchid = "";
                    string uniqueId = "";
                    string quantity = "";
                    string total_selling_price = "";
                    string cost_price = "";
                    string profit = "";
                    bool salesInserted = false;
                    if (dataTable.Rows.Count > 0)
                    {
                        int totalQty = 0;
                        decimal tup = 0;
                        salesGetterAndSetter.sales_by = loggedInUser.Rows[0]["username"].ToString();
                        for (int i = 0; i < dataTable.Rows.Count; i++)
                        {
                            string productId = dataTable.Rows[i]["ID"].ToString();
                            string productName = dataTable.Rows[i]["NAME"].ToString();
                            string productUnitPrice = dataTable.Rows[i]["UNIT PRICE"].ToString();
                            string productTotalPrice = dataTable.Rows[i]["TOTAL PRICE"].ToString();
                            string productQuantity = dataTable.Rows[i]["QTY"].ToString();
                            DataTable table = productsSqliteDatabaseHelper.selectProductsFromLocalDB(productId);
                            if (table.Rows.Count > 0)
                            {
                                branchid = table.Rows[0]["branch_id"].ToString();
                                uniqueId = table.Rows[0]["unique_id"].ToString();
                                quantity = table.Rows[0]["quantity"].ToString();
                                total_selling_price = table.Rows[0]["total_selling_price"].ToString();
                                cost_price = table.Rows[0]["cost_price"].ToString();
                                profit = table.Rows[0]["profit"].ToString();
                            }
                            totalQty = totalQty + int.Parse(productQuantity);
                            tup = tup + decimal.Parse(productUnitPrice);
                            int qty_left = int.Parse(quantity) - int.Parse(productQuantity);
                            decimal tsp_left = decimal.Parse(total_selling_price) - decimal.Parse(productTotalPrice);
                            decimal tcp_left = decimal.Parse(cost_price) * qty_left;
                            decimal tp_left = decimal.Parse(profit) * qty_left;
                            salesGetterAndSetter.product_id = int.Parse(productId);
                            salesGetterAndSetter.product_name = productName;
                            salesGetterAndSetter.unit_price = productUnitPrice;
                            salesGetterAndSetter.total_price = decimal.Parse(productTotalPrice);
                            salesGetterAndSetter.transaction_id = transactionId.ToString();
                            salesGetterAndSetter.unique_id = uniqueId;
                            salesGetterAndSetter.returned = 0;
                            salesGetterAndSetter.date = salesDate.Value.Date;
                            salesGetterAndSetter.date_to_show = salesDate.Text;
                            salesGetterAndSetter.quantity = int.Parse(productQuantity);
                            salesGetterAndSetter.is_online = 0;
                            salesGetterAndSetter.branch_id = branchid;
                            productsGetterAndSetter.quantity = qty_left;
                            productsGetterAndSetter.total_cost_price = tcp_left;
                            productsGetterAndSetter.total_selling_price = tsp_left;
                            productsGetterAndSetter.total_profit = tp_left;
                            productsGetterAndSetter.id = int.Parse(productId);
                            if (SalesAndTransactionsSqliteDatabaseHelper.insertSales(salesGetterAndSetter))
                            {
                                if (productsSqliteDatabaseHelper.updateProductsToLocalDBSales(productsGetterAndSetter))
                                {
                                    salesInserted = true;
                                }
                            }
                        }
                        salesGetterAndSetter.is_online = 0;
                        salesGetterAndSetter.unit_price = tup.ToString();
                        salesGetterAndSetter.total_price = totalAmount.Value;
                        salesGetterAndSetter.transaction_id = transactionId.ToString();
                        salesGetterAndSetter.unique_id = uniqueId;
                        salesGetterAndSetter.date = salesDate.Value.Date;
                        salesGetterAndSetter.date_to_show = salesDate.Text;
                        salesGetterAndSetter.quantity = totalQty;
                        salesGetterAndSetter.is_online = 0;
                        salesGetterAndSetter.returned = 0;
                        salesGetterAndSetter.branch_id = branchid;
                        if (salesInserted)
                        {
                            if (SalesAndTransactionsSqliteDatabaseHelper.insertTransactions(salesGetterAndSetter))
                            {
                                salesPrintPreview.Document = salesReceiptPrinter;
                                salesReceiptPrinter.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 260, 800);
                                salesPrintPreview.ShowDialog();
                                MessageBox.Show("Sales Made Successfully");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Amount Entered Is Not Enough");
                }
            }
            else
            {
                MessageBox.Show("Please Enter The Received Amount");
            }
        }
        private void searchSearchDetailTextBox_TextChanged(object sender, EventArgs e)
        {
            dt = productsSqliteDatabaseHelper.selectProductsFromLocalDBByProductNameOrID(searchSearchDetailTextBox.Text);
            productsDetailDataGridview.DataSource = dt;
        }

        private void add_Click(object sender, EventArgs e)
        {
            if(addQuantity.Value != 0 && totalQ != 0)
            {
                if(addQuantity.Value > totalQ)
                {
                    MessageBox.Show("Quantity Enter For The Product Is More Than In Stock");
                }
                else
                {
                    try
                    {
                        dataTable.Rows[irow]["QTY"] = addQuantity.Value.ToString();
                        dataTable.Rows[irow]["TOTAL PRICE"] = (addQuantity.Value * p).ToString();
                        calculateTotalPrice();
                        addQuantity.Value = 0;
                    }
                    catch
                    {

                    }
                   
                }
               
            }

        }

        private void salesReceiptPrinter_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(companyInfo.Rows[0]["company_name"].ToString(), new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(10, 10));
            e.Graphics.DrawString("Location: " + branchInfo.Rows[0]["branch_location"].ToString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(10, 35));
            e.Graphics.DrawString("Contact: " + branchInfo.Rows[0]["contact"].ToString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(10, 55));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(0, 85));
            e.Graphics.DrawString("ITEM            ", new Font("Arial", 7, FontStyle.Bold), Brushes.Black, new Point(5, 105));
            e.Graphics.DrawString("QTY  ", new Font("Arial", 7, FontStyle.Bold), Brushes.Black, new Point(80, 105));
            e.Graphics.DrawString("UNIT PRICE ", new Font("Arial", 7, FontStyle.Bold), Brushes.Black, new Point(130, 105));
            e.Graphics.DrawString("TOTAL", new Font("Arial", 7, FontStyle.Bold), Brushes.Black, new Point(200, 105));
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(0, 105));
            int yOffset = 40;
            
            for(int i = 0; i < dataTable.Rows.Count; i++)
            {
                
                int newYoffset = 0;
                string itemName = dataTable.Rows[i]["NAME"].ToString();
                if (itemName.Length > 14)
                {
                    itemName = itemName.Insert(13, "\n");
                    newYoffset = 15;
                }
                
                e.Graphics.DrawString(itemName, new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(3, 130 + (yOffset * i)));
                e.Graphics.DrawString(dataTable.Rows[i]["QTY"].ToString(), new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(82, 130 + (yOffset * i)));
                e.Graphics.DrawString(dataTable.Rows[i]["UNIT PRICE"].ToString(), new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(132, 130 + (yOffset * i)));
                e.Graphics.DrawString(dataTable.Rows[i]["TOTAL PRICE"].ToString(), new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(202, 130 + (yOffset * i)));
                e.Graphics.DrawString("-------------------------------------------------------------------------------------------------", new Font("Arial", 7, FontStyle.Bold), Brushes.Black, new Point(0, ((140 + newYoffset) + (yOffset * i))));
                yOffSetForNext = 130 + (yOffset * i);
            }
            int offsetForPaper = yOffSetForNext;
            e.Graphics.DrawString("Grand Total: GH₵ " + totalAmount.Text, new Font("Arial", 7, FontStyle.Bold), Brushes.Black, new Point(5, yOffSetForNext + 50));
            e.Graphics.DrawString("Paid Amount: GH₵ " + recievedAmount.Text, new Font("Arial", 7, FontStyle.Bold), Brushes.Black, new Point(5, yOffSetForNext + 70));
            e.Graphics.DrawString("Change Received: GH₵ " + changeAmount.Text, new Font("Arial", 7, FontStyle.Bold), Brushes.Black, new Point(5, yOffSetForNext + 90));
            e.Graphics.DrawString("Transacion ID: " + transactionId.ToString(), new Font("Arial", 7, FontStyle.Bold), Brushes.Black, new Point(5, yOffSetForNext + 110));
            e.Graphics.DrawString("Sales By: " + salesGetterAndSetter.sales_by.ToUpper(), new Font("Arial", 7, FontStyle.Bold), Brushes.Black, new Point(5, yOffSetForNext + 130));
            e.Graphics.DrawString("Date: " + salesDate.Value.ToLongDateString() +", Time: " + salesDate.Value.ToLongTimeString(), new Font("Arial", 7, FontStyle.Bold), Brushes.Black, new Point(5, yOffSetForNext + 150));
            e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------", new Font("Arial", 7, FontStyle.Bold), Brushes.Black, new Point(0, yOffSetForNext + 170));
            e.Graphics.DrawString("------------Thanks For Doing Business With Us!------------------", new Font("Arial", 7, FontStyle.Bold), Brushes.Black, new Point(5, yOffSetForNext + 190));
            dataTable.Rows.Clear();
            totalAmount.Value = 0;
            changeAmount.Value = 0;
            recievedAmount.Text = "";
            yOffSetForNext = offsetForPaper + 230;
        }
    }
}
