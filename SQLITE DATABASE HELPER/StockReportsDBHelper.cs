using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThinkCE_Store_Management_System.CONFIGURATIONS;

namespace ThinkCE_Store_Management_System.SQLITE_DATABASE_HELPER
{
    internal class StockReportsDBHelper
    {
        ConnectionConf connectionConf = new ConnectionConf();
        public DataTable SelectMostPurchaseItem()
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "SELECT product_name AS 'ITEM', SUM(quantity) AS 'TOTAL QUANTITY', " +
                    "SUM(total_price) AS 'TOTAL SALES FOR THE ITEM' FROM sales WHERE returned = 0 GROUP BY product_id";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
            return dataTable;
        }
        public DataTable SelectShortageItem(int quantity = 10)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "SELECT product_name AS 'ITEM', quantity AS 'QUANTITY', selling_price AS 'SELLING PRICE', " +
                    "updated_at AS 'LAST UPDATE' FROM products WHERE quantity <= "+ quantity;
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
            return dataTable;
        }
        public DataTable SelectExpensiveItem()
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "SELECT product_name AS 'ITEM', quantity AS 'QUANTITY', selling_price AS 'SELLING PRICE'" +
                    " FROM products ORDER BY selling_price DESC";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
            return dataTable;
        }
        public DataTable SelectCheapestItem()
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "SELECT product_name AS 'ITEM', quantity AS 'QUANTITY', selling_price AS 'SELLING PRICE'" +
                    " FROM products ORDER BY selling_price ASC";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
            return dataTable;
        }
        public DataTable SelectQuantizedItem()
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "SELECT product_name AS 'ITEM', quantity AS 'QUANTITY', selling_price AS 'SELLING PRICE'" +
                    " FROM products ORDER BY quantity DESC";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
            return dataTable;
        }
        public DataTable SelectMostPurchaseItemByDate(string date)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "SELECT product_name AS 'ITEM', SUM(quantity) AS 'TOTAL QUANTITY', " +
                    "SUM(total_price) AS 'TOTAL SALES FOR THE ITEM' FROM sales WHERE date_to_show LIKE '%" + date + "%' AND returned = 0 GROUP BY product_id";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dataTable;
        }
        public DataTable SelectMostPurchaseItemByThisMonth(string month, string year)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "SELECT product_name AS 'ITEM', SUM(quantity) AS 'TOTAL QUANTITY', " +
                    "SUM(total_price) AS 'TOTAL SALES FOR THE ITEM' FROM sales WHERE " +
                    "date_to_show LIKE '%" + month + "%' AND date_to_show LIKE '%" + year + "%' AND returned = 0 GROUP BY product_id";
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
        public DataTable SelectMostPurchaseItemByPeriod(string month, string year)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "SELECT product_name AS 'ITEM', SUM(quantity) AS 'TOTAL QUANTITY', " +
                    "SUM(total_price) AS 'TOTAL SALES FOR THE ITEM' FROM sales WHERE " +
                    "date_to_show LIKE '%" + month + "%' AND date_to_show LIKE '%" + year + "%'  AND returned = 0 GROUP BY product_id";
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
    }
}
