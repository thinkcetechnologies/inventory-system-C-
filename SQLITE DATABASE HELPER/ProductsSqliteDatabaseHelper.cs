using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThinkCE_Store_Management_System.CONFIGURATIONS;
using ThinkCE_Store_Management_System.GETTERS_AND_SETTERS.Products;
using System.Windows;

namespace ThinkCE_Store_Management_System.SQLITE_DATABASE_HELPER
{
    internal class ProductsSqliteDatabaseHelper
    {
        ConnectionConf connectionConf = new ConnectionConf();
        public bool insertProductsToLocalDB(ProductsGetterAndSetter productsGetterAndSetter)
        {
            bool is_inserted = false;
            MySqlConnection con = connectionConf.LocalDBCon();

            try
            {
                string sql = "INSERT INTO products (product_name, product_description, quantity, selling_price, cost_price," +
                    " branch_id, unique_id, added_by, profit, total_selling_price, total_cost_price, total_profit," +
                    " added_at, updated_at, barcode, status, shell, is_online, vendor)" +
                    " VALUES " +
                    "(@product_name, @product_description, @quantity, @selling_price, @cost_price," +
                    " @branch_id, @unique_id, @added_by, @profit, @total_selling_price, @total_cost_price," +
                    " @total_profit, @added_at, @updated_at, @barcode, @status, @shell, @is_online, @vendor)";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@product_name", productsGetterAndSetter.product_name);
                cmd.Parameters.AddWithValue("@product_description", productsGetterAndSetter.description);
                cmd.Parameters.AddWithValue("@quantity", productsGetterAndSetter.quantity);
                cmd.Parameters.AddWithValue("@selling_price", productsGetterAndSetter.selling_price);
                cmd.Parameters.AddWithValue("@cost_price", productsGetterAndSetter.cost_price);
                cmd.Parameters.AddWithValue("@branch_id", productsGetterAndSetter.branch_id);
                cmd.Parameters.AddWithValue("@unique_id", productsGetterAndSetter.unique_id);
                cmd.Parameters.AddWithValue("@added_by", productsGetterAndSetter.added_by);
                cmd.Parameters.AddWithValue("@profit", productsGetterAndSetter.profit);
                cmd.Parameters.AddWithValue("@total_selling_price", productsGetterAndSetter.total_selling_price);
                cmd.Parameters.AddWithValue("@total_cost_price", productsGetterAndSetter.total_cost_price);
                cmd.Parameters.AddWithValue("@total_profit", productsGetterAndSetter.total_profit);
                cmd.Parameters.AddWithValue("@added_at", productsGetterAndSetter.date);
                cmd.Parameters.AddWithValue("@updated_at", productsGetterAndSetter.updated_at);
                cmd.Parameters.AddWithValue("@barcode", productsGetterAndSetter.barcode);
                cmd.Parameters.AddWithValue("@shell", productsGetterAndSetter.shell);
                cmd.Parameters.AddWithValue("@is_online", productsGetterAndSetter.is_online);
                cmd.Parameters.AddWithValue("@status", productsGetterAndSetter.status);
                cmd.Parameters.AddWithValue("@vendor", productsGetterAndSetter.vendor);

                int rows = cmd.ExecuteNonQuery();

                if(rows > 0)
                {
                    is_inserted = true;
                }
                else
                {
                    is_inserted = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return is_inserted;
        }
        public bool updateProductsToLocalDB(ProductsGetterAndSetter productsGetterAndSetter)
        {
            bool is_inserted = false;
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "UPDATE products SET product_name = @product_name, product_description = @product_description," +
                    " quantity = @quantity, selling_price = @selling_price, cost_price = @cost_price, profit = @profit," +
                    " total_selling_price = @total_selling_price, total_cost_price = @total_cost_price," +
                    " total_profit = @total_profit, updated_at = @updated_at, barcode = @barcode, status = @status," +
                    " vendor = @vendor, shell = @shell, updated_online = @updated_online WHERE id = @id";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@product_name", productsGetterAndSetter.product_name);
                cmd.Parameters.AddWithValue("@product_description", productsGetterAndSetter.description);
                cmd.Parameters.AddWithValue("@quantity", productsGetterAndSetter.quantity);
                cmd.Parameters.AddWithValue("@selling_price", productsGetterAndSetter.selling_price);
                cmd.Parameters.AddWithValue("@cost_price", productsGetterAndSetter.cost_price);
                cmd.Parameters.AddWithValue("@profit", productsGetterAndSetter.profit);
                cmd.Parameters.AddWithValue("@total_selling_price", productsGetterAndSetter.total_selling_price);
                cmd.Parameters.AddWithValue("@total_cost_price", productsGetterAndSetter.total_cost_price);
                cmd.Parameters.AddWithValue("@total_profit", productsGetterAndSetter.total_profit);
                cmd.Parameters.AddWithValue("@updated_at", productsGetterAndSetter.updated_at);
                cmd.Parameters.AddWithValue("@barcode", productsGetterAndSetter.barcode);
                cmd.Parameters.AddWithValue("@status", productsGetterAndSetter.status);
                cmd.Parameters.AddWithValue("@shell", productsGetterAndSetter.shell);
                cmd.Parameters.AddWithValue("@id", productsGetterAndSetter.id);
                cmd.Parameters.AddWithValue("@vendor", productsGetterAndSetter.vendor);
                cmd.Parameters.AddWithValue("@updated_online", productsGetterAndSetter.updated_online);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    is_inserted = true;
                }
                else
                {
                    is_inserted = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return is_inserted;
        }
        public DataTable selectProductsFromLocalDBToDisplay()
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "SELECT id AS 'PRODUCT ID', product_name AS 'PRODUCT NAME', product_description AS 'DESCRIPTION', quantity AS 'QUANTITY', selling_price AS 'SELLING PRICE', shell AS 'SHELL IDENTITY', vendor AS 'SUPPLIER / VENDOR' FROM products";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dataTable;
        }
        public DataTable selectProductsFromLocalDB(string id)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "SELECT * FROM products WHERE id = '" + id + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }
            catch (Exception)
            {

            }
            finally
            {
                con.Close();
            }
            return dataTable;
        }
        public DataTable selectProductsFromLocalDBByVendor(string vendor)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "SELECT * FROM products WHERE vendor = '" + vendor + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }
            catch (Exception)
            {

            }
            finally
            {
                con.Close();
            }
            return dataTable;
        }
        public DataTable selectProductsFromLocalDBByBarcode(string barcode)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "SELECT id AS 'PRODUCT ID', product_name AS 'PRODUCT NAME', product_description AS 'DESCRIPTION', quantity AS 'QUANTITY', selling_price AS 'SELLING PRICE', shell AS 'SHELL IDENTITY', vendor AS 'SUPPLIER / VENDOR' FROM products WHERE barcode = '" + barcode + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }
            catch (Exception)
            {

            }
            finally
            {
                con.Close();
            }
            return dataTable;
        }
        public DataTable selectProductsFromLocalDBForSales()
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "SELECT * FROM products";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }
            catch (Exception)
            {

            }
            finally
            {
                con.Close();
            }
            return dataTable;
        }
        public bool updateProductsToLocalDBSales(ProductsGetterAndSetter productsGetterAndSetter)
        {
            bool is_inserted = false;
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "UPDATE products SET quantity = @quantity, total_selling_price = @total_selling_price, total_cost_price = @total_cost_price, total_profit = @total_profit, updated_online = @updated_online WHERE id = @id";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@quantity", productsGetterAndSetter.quantity);
                cmd.Parameters.AddWithValue("@total_selling_price", productsGetterAndSetter.total_selling_price);
                cmd.Parameters.AddWithValue("@total_cost_price", productsGetterAndSetter.total_cost_price);
                cmd.Parameters.AddWithValue("@total_profit", productsGetterAndSetter.total_profit);
                cmd.Parameters.AddWithValue("@id", productsGetterAndSetter.id);
                cmd.Parameters.AddWithValue("@updated_online", productsGetterAndSetter.updated_online);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    is_inserted = true;
                }
                else
                {
                    is_inserted = false;
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                con.Close();
            }
            return is_inserted;
        }
        public bool deleteProductsToLocalDBSales(ProductsGetterAndSetter productsGetterAndSetter)
        {
            bool is_inserted = false;
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "DELETE FROM products WHERE id = @id";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
               
                cmd.Parameters.AddWithValue("@id", productsGetterAndSetter.id);
                
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    is_inserted = true;
                }
                else
                {
                    is_inserted = false;
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                con.Close();
            }
            return is_inserted;
        }
        public DataTable selectProductsFromLocalDBByProductNameOrID(string name)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "SELECT id AS 'PRODUCT ID', product_name AS 'PRODUCT NAME', product_description AS 'DESCRIPTION', quantity AS 'QUANTITY', selling_price AS 'SELLING PRICE', shell AS 'SHELL IDENTITY', vendor AS 'SUPPLIER / VENDOR' FROM products WHERE product_name LIKE '%" + name + "%' OR id LIKE '%" + name +"%'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }
            catch (Exception)
            {

            }
            finally
            {
                con.Close();
            }
            return dataTable;
        }
        public DataTable selectProductsFromLocalDBByProductStatus(string name)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "SELECT id AS 'PRODUCT ID', product_name AS 'PRODUCT NAME', product_description AS 'DESCRIPTION'," +
                    " quantity AS 'QUANTITY', selling_price AS 'SELLING PRICE', shell AS 'SHELL IDENTITY', " +
                    "vendor AS 'SUPPLIER / VENDOR' FROM products WHERE status LIKE '%" + name + "%'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }
            catch (Exception)
            {

            }
            finally
            {
                con.Close();
            }
            return dataTable;
        }
        public DataTable selectProductsFromLocalDBByProductMinQty(string quantity)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "SELECT id AS 'PRODUCT ID', product_name AS 'PRODUCT NAME', product_description AS 'DESCRIPTION'," +
                    " quantity AS 'QUANTITY', selling_price AS 'SELLING PRICE', shell AS 'SHELL IDENTITY', vendor AS 'SUPPLIER / VENDOR' FROM products" +
                    " WHERE quantity <= " + quantity + "%'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }
            catch (Exception)
            {

            }
            finally
            {
                con.Close();
            }
            return dataTable;
        }
    }
}

