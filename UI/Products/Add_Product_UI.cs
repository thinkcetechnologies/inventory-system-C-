using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThinkCE_Store_Management_System.GETTERS_AND_SETTERS.Products;
using ThinkCE_Store_Management_System.SQLITE_DATABASE_HELPER;
using ZXing;
using USB_Barcode_Scanner;

namespace ThinkCE_Store_Management_System.UI.Products
{
    public partial class Add_Product_UI : Form
    {
        BarcodeScanner barcodeScanner = null;
        public Add_Product_UI()
        {
            InitializeComponent();
            barcodeScanner = new BarcodeScanner(barcodeTxt);
            barcodeScanner.BarcodeScanned += BarcodeScanner_BarcodeScanned;

        }
        private void BarcodeScanner_BarcodeScanned(object sender, BarcodeScannerEventArgs e)
        {
            barcodeTxt.Text = e.Barcode;
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        ProductsGetterAndSetter productsGetterAndSetter = new ProductsGetterAndSetter();
        UsersSqliteDatabaseHelper usersSqliteDatabaseHelper = new UsersSqliteDatabaseHelper();
        InitAppSqliteDatabaseHelper initAppSqliteDatabaseHelper = new InitAppSqliteDatabaseHelper();
        ProductsSqliteDatabaseHelper productsSqliteDatabaseHelper = new ProductsSqliteDatabaseHelper();
        SupplierLocalDatabaseHelper supplierLocalDatabase = new SupplierLocalDatabaseHelper();
        string status = "";

        private void fillCB()
        {
           
            DataTable cb = supplierLocalDatabase.getAllSupplierDataFromLocalDB();
            if(cb != null)
            {
                if(cb.Rows.Count > 0)
                {
                    supplierCB.DataSource = cb;
                    supplierCB.DisplayMember = "supplier_name";
                    supplierCB.ValueMember = "supplier_name";
                }
            }
        }

        private void Add_Product_UI_Load(object sender, EventArgs e)
        {
            barcodeTxt.Focus();

            fillCB();
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                {
                    videoCaptureDevice.Stop();
                }
            }
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            loadProductDataFromLocalDB();
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
            
        }
        private void loadProductDataFromLocalDB()
        {
            DataTable dataTable = productsSqliteDatabaseHelper.selectProductsFromLocalDBToDisplay();
            productsDetailDataGridview.DataSource = dataTable;
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

        private void Add_Product_UI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                {
                    videoCaptureDevice.Stop();
                }
            }
        }
        private void barcodePic_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                captureCode();
            }
            catch (Exception)
            {

            }
        }
        bool calculated = false;
        private void calculateBtn_Click(object sender, EventArgs e)
        {
            if(productQuantityTxt.Value != 0 && decimal.Parse(costPriceTxt.Text) != 0 && decimal.Parse(sellingPriceTxt.Text) != 0)
            {
                totalSellingPriceTxt.Text = (productQuantityTxt.Value * decimal.Parse(sellingPriceTxt.Text)).ToString();
                totalCostPriceTxt.Text = (productQuantityTxt.Value * decimal.Parse(costPriceTxt.Text)).ToString();
                Decimal p = decimal.Parse(sellingPriceTxt.Text) - decimal.Parse(costPriceTxt.Text);
                profitTxt.Text = p.ToString();
                totalProfitTxt.Text = (p * productQuantityTxt.Value).ToString();
                calculated = true;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (calculated)
            {
                if (decimal.Parse(totalProfitTxt.Text) != 0 && decimal.Parse(totalSellingPriceTxt.Text) != 0 && decimal.Parse(totalCostPriceTxt.Text) != 0)
                {
                    DataTable dataTable = usersSqliteDatabaseHelper.getLoggedInUser();
                    DataTable dt = initAppSqliteDatabaseHelper.SelectDataFromLocalDBToCompareInitApp();
                    DataTable d = initAppSqliteDatabaseHelper.SelectDataFromLocalDBBranch();
                    if (dataTable != null && dt != null)
                    {
                        if (dataTable.Rows.Count > 0 && dt.Rows.Count > 0)
                        {
                            productsGetterAndSetter.added_by = dataTable.Rows[0]["username"].ToString();
                            productsGetterAndSetter.unique_id = dt.Rows[0]["unique_id"].ToString();
                            productsGetterAndSetter.quantity = int.Parse(productQuantityTxt.Value.ToString());
                            productsGetterAndSetter.profit = decimal.Parse(profitTxt.Text);
                            productsGetterAndSetter.product_name = productNameTextBox.Text;
                            productsGetterAndSetter.description = productDescriptionTextBox.Text;
                            productsGetterAndSetter.total_cost_price = decimal.Parse(totalCostPriceTxt.Text);
                            productsGetterAndSetter.total_profit = decimal.Parse(totalProfitTxt.Text);
                            productsGetterAndSetter.selling_price = decimal.Parse(sellingPriceTxt.Text);
                            productsGetterAndSetter.total_selling_price = decimal.Parse(totalSellingPriceTxt.Text);
                            productsGetterAndSetter.barcode = barcodeTxt.Text;
                            productsGetterAndSetter.branch_id = d.Rows[0]["branch_unique_id"].ToString();
                            productsGetterAndSetter.status = status;
                            productsGetterAndSetter.date = DateTime.Now;
                            productsGetterAndSetter.updated_at = DateTime.Now;
                            productsGetterAndSetter.shell = shellNumberTextBox.Text;
                            productsGetterAndSetter.is_online = 0;
                            productsGetterAndSetter.cost_price = decimal.Parse(costPriceTxt.Text);
                            productsGetterAndSetter.vendor = supplierCB.SelectedText.ToString();
                            if (productsSqliteDatabaseHelper.insertProductsToLocalDB(productsGetterAndSetter))
                            {
                                MessageBox.Show("Product Added Successfully");
                                clear();
                                loadProductDataFromLocalDB();
                            }
                            else
                            {
                                MessageBox.Show("Add Product Failed");
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Press the calculate button to perform all calculations");
            }
            
        }
        private void onCredit_CheckedChanged(object sender, EventArgs e)
        {
            if (onCredit.Checked)
            {
                status = "On Credit";
            }
        }
        private void paid_CheckedChanged(object sender, EventArgs e)
        {
            if (paid.Checked)
            {
                status = "Paid";
            }
        }
        private void productsDetailDataGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void clear()
        {
            productDescriptionTextBox.Text = "";
            productNameTextBox.Text = "";
            productQuantityTxt.Text = "";
            barcodeTxt.Text = "";
            costPriceTxt.Text = "";
            sellingPriceTxt.Text = "";
            totalCostPriceTxt.Text = "";
            totalSellingPriceTxt.Text = "";
            profitTxt.Text = "";
            totalProfitTxt.Text = "";
            shellNumberTextBox.Text = "";
            onCredit.Checked = false;
            paid.Checked = false;
        }
    }
}
