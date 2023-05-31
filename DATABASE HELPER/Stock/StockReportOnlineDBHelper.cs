using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ThinkCE_Store_Management_System.CONFIGURATIONS;

namespace ThinkCE_Store_Management_System.DATABASE_HELPER.Stock
{
    internal class StockReportOnlineDBHelper
    {
        ConnectionConf connectionConf = new ConnectionConf();
        public DataTable SelectMostPurchaseItem(string unique_id, string branch_id)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.Maincon();
            try
            {
                string sql = "SELECT product_name AS 'ITEM', SUM(quantity) AS 'TOTAL QUANTITY', " +
                    "SUM(total_price) AS 'TOTAL SALES FOR THE ITEM' FROM sales WHERE returned = 0 AND unique_id = '"+ unique_id +"' AND branch_id = '"+ branch_id +"' GROUP BY product_id";
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
        public DataTable SelectShortageItem(string unique_id, string branch_id, int quantity = 10)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.Maincon();
            try
            {
                string sql = "SELECT product_name AS 'ITEM', quantity AS 'QUANTITY', selling_price AS 'SELLING PRICE', " +
                    "updated_at AS 'LAST UPDATE' FROM products WHERE quantity <= " + quantity + " AND unique_id = '" + unique_id + "' AND branch_id = '" + branch_id + "'";
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
        public DataTable SelectExpensiveItem(string unique_id, string branch_id)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.Maincon();
            try
            {
                string sql = "SELECT product_name AS 'ITEM', quantity AS 'QUANTITY', selling_price AS 'SELLING PRICE'" +
                    " FROM products WHERE unique_id = '" + unique_id + "' AND branch_id = '" + branch_id + "' ORDER BY selling_price DESC";
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
        public DataTable SelectCheapestItem(string unique_id, string branch_id)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.Maincon();
            try
            {
                string sql = "SELECT product_name AS 'ITEM', quantity AS 'QUANTITY', selling_price AS 'SELLING PRICE'" +
                    " FROM products WHERE unique_id = '" + unique_id + "' AND branch_id = '" + branch_id + "'ORDER BY selling_price ASC";
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
        public DataTable SelectQuantizedItem(string unique_id, string branch_id)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.Maincon();
            try
            {
                string sql = "SELECT product_name AS 'ITEM', quantity AS 'QUANTITY', selling_price AS 'SELLING PRICE'" +
                    " FROM products WHERE unique_id = '" + unique_id + "' AND branch_id = '" + branch_id + "' ORDER BY quantity DESC";
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
        public DataTable SelectMostPurchaseItemByDate(string date, string unique_id, string branch_id)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.Maincon();
            try
            {
                string sql = "SELECT product_name AS 'ITEM', SUM(quantity) AS 'TOTAL QUANTITY', " +
                    "SUM(total_price) AS 'TOTAL SALES FOR THE ITEM' FROM sales WHERE date_to_show LIKE '%" + date + "%' AND returned = 0 AND unique_id = '" + unique_id + "' AND branch_id = '" + branch_id + "' GROUP BY product_id";
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
        public DataTable SelectMostPurchaseItemByThisMonth(string unique_id, string branch_id, string month, string year)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.Maincon();
            try
            {
                string sql = "SELECT product_name AS 'ITEM', SUM(quantity) AS 'TOTAL QUANTITY', " +
                    "SUM(total_price) AS 'TOTAL SALES FOR THE ITEM' FROM sales WHERE " +
                    "date_to_show LIKE '%" + month + "%' AND date_to_show LIKE '%" + year + "%' AND returned = 0 AND unique_id = '" + unique_id + "' AND branch_id = '" + branch_id + "' GROUP BY product_id";
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
        public DataTable SelectMostPurchaseItemByPeriod(string unique_id, string branch_id, string from, string to)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.Maincon();
            try
            {
                string sql = "SELECT product_name AS 'ITEM', SUM(quantity) AS 'TOTAL QUANTITY', " +
                    "SUM(total_price) AS 'TOTAL SALES FOR THE ITEM' FROM sales WHERE " +
                    "date BETWEEN '" + from + "' AND '" + to + "' AND returned = 0 AND unique_id = '" + unique_id + "' AND branch_id = '" + branch_id + "' GROUP BY product_id";
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
