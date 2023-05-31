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
    public partial class Add_Supplier_Order_UI : Form
    {
        public Add_Supplier_Order_UI()
        {
            InitializeComponent();
        }
        VendorDetailsGS vendorDetailsGS = new VendorDetailsGS();
        VendorDetailLocalDBHelper vendorDetailLocalDB = new VendorDetailLocalDBHelper();
        DataTable brachDt, uniqueDt, userDt, vDt;
        SupplierLocalDatabaseHelper supplierLocalDatabase = new SupplierLocalDatabaseHelper();
        InitAppSqliteDatabaseHelper init = new InitAppSqliteDatabaseHelper();
        UsersSqliteDatabaseHelper users = new UsersSqliteDatabaseHelper();
        int id;

        private void vDetailDataGridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            try
            {
                id = int.Parse(vDt.Rows[i]["ID"].ToString());
            }
            catch(Exception ex)
            {

            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            new Update_Supplier_Order(id).ShowDialog();
        }

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
        private void Add_Supplier_Order_UI_Load(object sender, EventArgs e)
        {
            fillCB();
            vDt = vendorDetailLocalDB.getVendorDetailsDataFromLocalDB();
            brachDt = init.SelectDataFromLocalDBBranch();
            userDt = users.getLoggedInUser();
            vDetailDataGridview.DataSource = vDt;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(amount.Value != 0 && supplierCB.SelectedValue.ToString() != "")
            {
                vendorDetailsGS.branch_id = brachDt.Rows[0]["branch_unique_id"].ToString();
                vendorDetailsGS.unique_id = brachDt.Rows[0]["unique_id"].ToString();
                vendorDetailsGS.vendor_name = supplierCB.SelectedValue.ToString();
                vendorDetailsGS.is_online = 0;
                vendorDetailsGS.amount = amount.Value;
                vendorDetailsGS.added_by = userDt.Rows[0]["username"].ToString();
                vendorDetailsGS.added_at = addedAtDTP.Value;
                vendorDetailsGS.updated_at = addedAtDTP.Value;
                vendorDetailsGS.id_from_online = 0;
                vendorDetailsGS.part_payment_amount = paidAmount.Value;
                if (paidAmount.Value >= amount.Value)
                {
                    vendorDetailsGS.status = "Full Payment";
                }
                else if (paidAmount.Value > 0 && paidAmount.Value < amount.Value)
                {
                    vendorDetailsGS.status = "Part Payment";
                }
                else if(paidAmount.Value == 0)
                {
                    vendorDetailsGS.status = "On Credit";
                }
                if (vendorDetailLocalDB.insertVendorDetailToLocalDB(vendorDetailsGS))
                {
                    MessageBox.Show("Supplier Other Data Inserted Successfully");
                    vDt = vendorDetailLocalDB.getVendorDetailsDataFromLocalDB();
                    vDetailDataGridview.DataSource = vDt;
                }
                else
                {
                    MessageBox.Show("An Error Occured");
                }
            }
            
        }
    }
}
