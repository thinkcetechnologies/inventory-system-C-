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
    public partial class Add_Supplier_UI : Form
    {
        public Add_Supplier_UI()
        {
            InitializeComponent();
        }
        SuppliersGetterAndSetter suppliers = new SuppliersGetterAndSetter();
        SupplierLocalDatabaseHelper suppliersLocalDatabase = new SupplierLocalDatabaseHelper();
        DataTable branchDt, companyDt, suppliersDt;
        InitAppSqliteDatabaseHelper init = new InitAppSqliteDatabaseHelper();

        private void Add_Supplier_UI_Load(object sender, EventArgs e)
        {
            branchDt = init.SelectDataFromLocalDBBranch();
            companyDt = init.SelectDataFromLocalDBToCompareInitApp();
            suppliersDt = suppliersLocalDatabase.getSupplierDataFromLocalDB();
            suppliersDGV.DataSource = suppliersDt;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(supplierName.Text != "" && supplierLocation.Text != "")
            {
                suppliers.supplier_name = supplierName.Text;
                suppliers.branch_id = branchDt.Rows[0]["branch_unique_id"].ToString();
                suppliers.unique_id = companyDt.Rows[0]["unique_id"].ToString();
                suppliers.updated_online = "0";
                suppliers.id_from_online = "0";
                suppliers.is_online = 0;
                suppliers.supplier_address = supplierAddress.Text;
                suppliers.supplier_contact = supplierContact.Text;
                suppliers.supplier_location = supplierLocation.Text;
                suppliers.date = DateTime.Now;
                if (suppliersLocalDatabase.insertSupplierIntoLocalDB(suppliers))
                {
                    MessageBox.Show("Supplier Records Added Successfully");
                    suppliersDt = suppliersLocalDatabase.getSupplierDataFromLocalDB();
                    suppliersDGV.DataSource = suppliersDt;
                }
                else
                {
                    MessageBox.Show("An Error Occured");
                }
            }
        }
    }
}
