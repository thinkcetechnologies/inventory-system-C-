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
using ThinkCE_Store_Management_System.DATABASE_HELPER.Products;
using ThinkCE_Store_Management_System.GETTERS_AND_SETTERS.Products;
using ThinkCE_Store_Management_System.SQLITE_DATABASE_HELPER;
using ZXing;
using USB_Barcode_Scanner;

namespace ThinkCE_Store_Management_System.UI.Products
{
    public partial class Products_Update_UI : Form
    {
        string productID = "";
        bool isCalculated = false;
        public Products_Update_UI(string id)
        {
            InitializeComponent();
            productID = id;
            BarcodeScanner barcodeScanner = new BarcodeScanner(barcodeTxt);
            barcodeScanner.BarcodeScanned += BarcodeScanner_BarcodeScanned;
        }
        private void BarcodeScanner_BarcodeScanned(object sender, BarcodeScannerEventArgs e)
        {
            barcodeTxt.Text = e.Barcode;
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        ProductsSqliteDatabaseHelper productsSqliteDatabaseHelper = new ProductsSqliteDatabaseHelper();
        ProductsGetterAndSetter productsGetterAndSetter = new ProductsGetterAndSetter();
        ProductsOnlineDatabaseHelper productsOnlineDatabaseHelper = new ProductsOnlineDatabaseHelper();
        SupplierLocalDatabaseHelper supplierLocalDatabase = new SupplierLocalDatabaseHelper();

        private void fillCB()
        {
            DataTable cb = supplierLocalDatabase.getAllSupplierDataFromLocalDB();
            if (cb != null)
            {
                if (cb.Rows.Count > 0)
                {
                    supplierCB.DataSource = cb;
                    supplierCB.DisplayMember = "supplier_name";
                    supplierCB.ValueMember = "supplier_name";
                }
            }
        }
        private void Products_Update_UI_Load(object sender, EventArgs e)
        {
            fillCB();
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                {
                    videoCaptureDevice.Stop();
                }
            }
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
            DataTable dt = productsSqliteDatabaseHelper.selectProductsFromLocalDB(productID);
            if(dt != null)
            {
                if(dt.Rows.Count > 0)
                {
                    productNameTextBox.Text = dt.Rows[0]["product_name"].ToString();
                    productDescriptionTextBox.Text = dt.Rows[0]["product_description"].ToString();
                    barcodeTxt.Text = dt.Rows[0]["barcode"].ToString();
                    supplierCB.SelectedValue = dt.Rows[0]["vendor"].ToString();
                    shellNumberTextBox.Text = dt.Rows[0]["shell"].ToString();
                    productQuantityTxt.Value = decimal.Parse(dt.Rows[0]["quantity"].ToString());
                    sellingPriceTxt.Text = dt.Rows[0]["selling_price"].ToString();
                    costPriceTxt.Text = dt.Rows[0]["cost_price"].ToString();
                    totalCostPriceTxt.Text = dt.Rows[0]["total_cost_price"].ToString();
                    totalProfitTxt.Text = dt.Rows[0]["total_profit"].ToString();
                    totalSellingPriceTxt.Text = dt.Rows[0]["total_selling_price"].ToString();
                    profitTxt.Text = dt.Rows[0]["profit"].ToString();
                    if(dt.Rows[0]["status"].ToString() == "Paid")
                    {
                        paid.Checked = true;
                    }
                    else
                    {
                        onCredit.Checked = true;
                    }
                }
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void calculateBtn_Click(object sender, EventArgs e)
        {
            if (productQuantityTxt.Value != 0 && decimal.Parse(costPriceTxt.Text) != 0 && decimal.Parse(sellingPriceTxt.Text) != 0)
            {
                int tQty = int.Parse((productQuantityTxt.Value + addQuantity.Value).ToString());
                productQuantityTxt.Value = tQty;
                addQuantity.Value = 0;
                totalSellingPriceTxt.Text = (productQuantityTxt.Value * decimal.Parse(sellingPriceTxt.Text)).ToString();
                totalCostPriceTxt.Text = (productQuantityTxt.Value * decimal.Parse(costPriceTxt.Text)).ToString();
                Decimal p = decimal.Parse(sellingPriceTxt.Text) - decimal.Parse(costPriceTxt.Text);
                profitTxt.Text = p.ToString();
                totalProfitTxt.Text = (p * productQuantityTxt.Value).ToString();
                isCalculated = true;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (isCalculated)
            {
                if(productDescriptionTextBox.Text != "" && productNameTextBox.Text != "")
                {
                    productsGetterAndSetter.product_name = productNameTextBox.Text;
                    productsGetterAndSetter.description = productDescriptionTextBox.Text;
                    productsGetterAndSetter.barcode = barcodeTxt.Text;
                    productsGetterAndSetter.cost_price = decimal.Parse(costPriceTxt.Text);
                    productsGetterAndSetter.selling_price = decimal.Parse(sellingPriceTxt.Text);
                    productsGetterAndSetter.total_selling_price = decimal.Parse(totalSellingPriceTxt.Text);
                    productsGetterAndSetter.quantity = int.Parse(productQuantityTxt.Value.ToString());
                    productsGetterAndSetter.profit = decimal.Parse(profitTxt.Text);
                    productsGetterAndSetter.total_profit = decimal.Parse(totalProfitTxt.Text);
                    productsGetterAndSetter.total_cost_price = decimal.Parse(totalCostPriceTxt.Text);
                    productsGetterAndSetter.total_profit = decimal.Parse(totalProfitTxt.Text);
                    productsGetterAndSetter.vendor = supplierCB.SelectedText.ToString();
                    productsGetterAndSetter.shell = shellNumberTextBox.Text;
                    productsGetterAndSetter.total_profit = decimal.Parse(totalProfitTxt.Text);
                    productsGetterAndSetter.id = int.Parse(productID);
                    productsGetterAndSetter.updated_online = 0;
                    if (paid.Checked)
                    {
                        productsGetterAndSetter.status = "Paid";
                    }
                    else if (onCredit.Checked)
                    {
                        productsGetterAndSetter.status = "On Credit";
                    }
                    
                    if (productsSqliteDatabaseHelper.updateProductsToLocalDB(productsGetterAndSetter))
                    {
                        MessageBox.Show(productNameTextBox.Text + "Updated Successfully");
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("An Error Occured");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please press the calculate button to perform all calculations before");
            }
        }

        private void Products_Update_UI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                {
                    videoCaptureDevice.Stop();
                }
            }
        }
    }
}
