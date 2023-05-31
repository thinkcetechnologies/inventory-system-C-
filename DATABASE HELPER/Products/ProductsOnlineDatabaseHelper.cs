using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ThinkCE_Store_Management_System.CONFIGURATIONS;
using ThinkCE_Store_Management_System.GETTERS_AND_SETTERS.Products;

namespace ThinkCE_Store_Management_System.DATABASE_HELPER.Products
{
    internal class ProductsOnlineDatabaseHelper
    {
        ConnectionConf connectionConf = new ConnectionConf();
        public bool insertProductsToOnlineDB(ProductsGetterAndSetter productsGetterAndSetter)
        {
            bool is_inserted = false;
            MySqlConnection con = connectionConf.Maincon();

            try
            {
                string sql = "INSERT INTO products (product_name, product_description, quantity, selling_price, cost_price, branch_id, unique_id, added_by, profit, total_selling_price, total_cost_price, total_profit, added_at, updated_at, barcode, status, shell) VALUES (@product_name, @product_description, @quantity, @selling_price, @cost_price, @branch_id, @unique_id, @added_by, @profit, @total_selling_price, @total_cost_price, @total_profit, @added_at, @updated_at, @barcode, @status, @shell)";
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
               
                cmd.Parameters.AddWithValue("@status", productsGetterAndSetter.status);

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
        public bool updateProductsToOnlineDB(ProductsGetterAndSetter productsGetterAndSetter)
        {
            bool is_inserted = false;
            MySqlConnection con = connectionConf.Maincon();
            try
            {
                string sql = "UPDATE products SET product_name = @product_name, product_description = @product_description, quantity = @quantity, selling_price = @selling_price, cost_price = @cost_price, profit = @profit, total_selling_price = @total_selling_price, total_cost_price = @total_cost_price, total_profit = @total_profit, updated_at = @updated_at, barcode = @barcode, status = @status, shell = @shell, WHERE id = @id AND unique_id = @unique_id AND branch_id = @branch_id";
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
                cmd.Parameters.AddWithValue("@id", productsGetterAndSetter.on_line_id);
                cmd.Parameters.AddWithValue("@branch_id", productsGetterAndSetter.branch_id);
                cmd.Parameters.AddWithValue("@unique_id", productsGetterAndSetter.unique_id);
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
        public DataTable selectProductsFromOnlineDBToDisplay(string unique_id, string branch_id)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.Maincon();
            try
            {
                string sql = "SELECT id AS 'PRODUCT ID', product_name AS 'PRODUCT NAME', product_description AS 'DESCRIPTION', quantity AS 'QUANTITY', selling_price AS 'SELLING PRICE', shell AS 'SHELL IDENTITY' FROM products WHERE unique_id = '" + unique_id + "' AND branch_id = '" + branch_id + "'";
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
        public DataTable searchProductsFromOnlineDBToDisplay(string name, string unique_id, string branch_id)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.Maincon();
            try
            {
                string sql = "SELECT id AS 'PRODUCT ID', product_name AS 'PRODUCT NAME', " +
                    "product_description AS 'DESCRIPTION', quantity AS 'QUANTITY'," +
                    " selling_price AS 'SELLING PRICE', shell AS 'SHELL IDENTITY' FROM products " +
                    "WHERE " +
                    "product_name LIKE '%" + name + "%' AND unique_id = '" + unique_id + "' AND branch_id = '" + branch_id + "' OR " +
                    "product_description LIKE '%" + name + "%' AND unique_id = '" + unique_id + "' AND branch_id = '" + branch_id + "' OR " +
                    "status LIKE '%" + name + "%' AND unique_id = '" + unique_id + "' AND branch_id = '" + branch_id + "' OR " +
                   " id LIKE '%" + name + "%' AND unique_id = '" + unique_id + "' AND branch_id = '" + branch_id + "' OR " +
                   "barcode LIKE '%" + name + "%' AND unique_id = '" + unique_id + "' AND branch_id = '" + branch_id + "'";
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
        public DataTable selectProductsFromOnlineDB(string id)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.Maincon();
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
        public DataTable selectProductsFromOnlineDBByBarcode(string barcode)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "SELECT id AS 'PRODUCT ID', product_name AS 'PRODUCT NAME', product_description AS 'DESCRIPTION', quantity AS 'QUANTITY', selling_price AS 'SELLING PRICE', shell AS 'SHELL IDENTITY' FROM products WHERE barcode = '" + barcode + "'";
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
        public DataTable selectProductsFromOnlineDBForSales()
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
    }
}
