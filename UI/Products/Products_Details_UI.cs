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

namespace ThinkCE_Store_Management_System.UI.Products
{
    public partial class Products_Details_UI : Form
    {
        string productID = "";
        DataTable dataTable;
        bool hideData;
        public Products_Details_UI(bool hide = false)
        {
            InitializeComponent();
            hideData = hide;
        }
        ProductsGetterAndSetter productsGetterAndSetter = new ProductsGetterAndSetter();
        UsersSqliteDatabaseHelper usersSqliteDatabaseHelper = new UsersSqliteDatabaseHelper();
        InitAppSqliteDatabaseHelper initAppSqliteDatabaseHelper = new InitAppSqliteDatabaseHelper();
        ProductsSqliteDatabaseHelper productsSqliteDatabaseHelper = new ProductsSqliteDatabaseHelper();
        private void Products_Details_UI_Load(object sender, EventArgs e)
        {
            if (hideData)
            {
                updateBtn.Visible = false;
                deleteBtn.Visible = false;
            }
            loadProductDataFromLocalDB();
        }
        private void loadProductDataFromLocalDB()
        {
            dataTable = productsSqliteDatabaseHelper.selectProductsFromLocalDBToDisplay();
            productsDetailDataGridview.DataSource = dataTable;
        }

        private void productsDetailDataGridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                productID = productsDetailDataGridview.Rows[rowIndex].Cells[0].Value.ToString();
            }
            catch (Exception)
            {

            }
            
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            new Products_Update_UI(productID).ShowDialog();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void searchUserDetailTextBox_TextChanged(object sender, EventArgs e)
        {
            dataTable = productsSqliteDatabaseHelper.selectProductsFromLocalDBByProductNameOrID(searchUserDetailTextBox.Text);
            productsDetailDataGridview.DataSource = dataTable;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if(productID != "")
            {
                DialogResult results = MessageBox.Show("Are You Sure You Want To Delete", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (results == DialogResult.Yes)
                {
                    productsGetterAndSetter.id = int.Parse(productID);
                    if (productsSqliteDatabaseHelper.deleteProductsToLocalDBSales(productsGetterAndSetter))
                    {
                        dataTable = productsSqliteDatabaseHelper.selectProductsFromLocalDBToDisplay();
                        productsDetailDataGridview.DataSource = dataTable;
                    }
                }
            }
        }
    }
}
