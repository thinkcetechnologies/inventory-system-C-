using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThinkCE_Store_Management_System.GETTERS_AND_SETTERS.Suppliers;
using ThinkCE_Store_Management_System.SQLITE_DATABASE_HELPER;

namespace ThinkCE_Store_Management_System.UI.Supplier
{
    public partial class Suppliers_Details_UI : Form
    {
        public Suppliers_Details_UI()
        {
            InitializeComponent();
        }
        DataTable dataTable, pDt;
        string vendor_name = "";
        int id = 0;
        SupplierLocalDatabaseHelper suppliersLocalDatabase = new SupplierLocalDatabaseHelper();
        ProductsSqliteDatabaseHelper productsSqliteDatabaseHelper = new ProductsSqliteDatabaseHelper();
        VendorDetailsGS vendorDetailsGS = new VendorDetailsGS();
        VendorDetailLocalDBHelper vendorDetailLocalDB = new VendorDetailLocalDBHelper();
        private void transDetailDataGridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            decimal tDept = 0;
            decimal pamount = 0;
            decimal totalP = 0;
           
            try
            {
                vendor_name = dataTable.Rows[i]["SUPPLIER NAME"].ToString();
                id = int.Parse(dataTable.Rows[i]["SUPPLIER ID"].ToString());
                pDt = vendorDetailLocalDB.searchVendorDetailsDataFromLocalDB(vendor_name);
                if (pDt != null)
                {
                    if (pDt.Rows.Count > 0)
                    {
                        for (int j = 0; j < pDt.Rows.Count; j++)
                        {
                            if (pDt.Rows[j]["PAYMENT STATUS"].ToString() == "Part Payment" || pDt.Rows[j]["PAYMENT STATUS"].ToString() == "On Credit")
                            {
                                tDept = tDept + (decimal.Parse(pDt.Rows[j]["AMOUNT"].ToString()) - decimal.Parse(pDt.Rows[j]["PAID AMOUNT"].ToString()));
                            }
                            
                                pamount = pamount + decimal.Parse(pDt.Rows[j]["PAID AMOUNT"].ToString());
                            
                            totalP = totalP + decimal.Parse(pDt.Rows[j]["AMOUNT"].ToString());
                        }
                    }
                    tDeptT.Text = "GH₵ " + tDept.ToString();
                    tPaidP.Text = "GH₵ " + pamount.ToString();
                    tPrice.Text = "GH₵ " + totalP.ToString();
                }
            }
            catch (Exception)
            {
            }
        }

        private void searchUserDetailTextBox_TextChanged(object sender, EventArgs e)
        {

            dataTable = suppliersLocalDatabase.searchSupplierDataFromLocalDB(searchUserDetailTextBox.Text);
            supplierDetailDataGridview.DataSource = dataTable;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult results = MessageBox.Show("Are You Sure You Want To Delete", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (results == DialogResult.Yes)
            {
                if (suppliersLocalDatabase.deleteSupplierFromLocalDB(id))
                {
                    MessageBox.Show("Succesffully delete supplier", "Success");
                }
            }
                
        }

        private void Suppliers_Details_UI_Load(object sender, EventArgs e)
        {
            dataTable = suppliersLocalDatabase.getSupplierDataFromLocalDB();
            supplierDetailDataGridview.DataSource = dataTable;
        }
    }
}
