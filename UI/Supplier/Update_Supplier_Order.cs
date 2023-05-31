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
    public partial class Update_Supplier_Order : Form
    {
        int orderID;
        VendorDetailsGS vendorDetailsGS = new VendorDetailsGS();
        VendorDetailLocalDBHelper vendorDetailLocalDB = new VendorDetailLocalDBHelper();
        DataTable vDt;
        SupplierLocalDatabaseHelper supplierLocalDatabase = new SupplierLocalDatabaseHelper();
        InitAppSqliteDatabaseHelper init = new InitAppSqliteDatabaseHelper();
        UsersSqliteDatabaseHelper users = new UsersSqliteDatabaseHelper();
        decimal amount;
        int vId;

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(updatedAmount.Value > 0)
            {
                decimal totalPaidAmount = paidAmount.Value + updatedAmount.Value;
                if (totalPaidAmount < amount)
                {
                    vendorDetailsGS.status = "Part Payment";
                }
                else if(totalPaidAmount >= amount)
                {
                    vendorDetailsGS.status = "Full Payment";
                }
                vendorDetailsGS.part_payment_amount = totalPaidAmount;
                vendorDetailsGS.updated_at = addedAtDTP.Value;
                vendorDetailsGS.id = vId;
                if (vendorDetailLocalDB.updateVendorDetailToLocalDB(vendorDetailsGS))
                {
                    MessageBox.Show("Info Updated Successfully");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("An Error Occured");
                }
            }
            
        }

       

        public Update_Supplier_Order(int id)
        {
            InitializeComponent();
            orderID = id;
        }

        private void Update_Supplier_Order_Load(object sender, EventArgs e)
        {
            addedAtDTP.Value = DateTime.Now;
            try
            {
                vDt = vendorDetailLocalDB.searchOneVendorDetailsDataFromLocalDB(orderID);
                if (vDt != null)
                {
                    if (vDt.Rows.Count > 0)
                    {
                        paidAmount.Value = decimal.Parse(vDt.Rows[0]["part_payment_amount"].ToString());
                        vName.Text = vDt.Rows[0]["vendor"].ToString();
                        amount = decimal.Parse(vDt.Rows[0]["amount"].ToString());
                        vId = int.Parse(vDt.Rows[0]["id"].ToString());
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
