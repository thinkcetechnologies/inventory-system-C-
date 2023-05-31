using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ThinkCE_Store_Management_System.CONFIGURATIONS;

namespace ThinkCE_Store_Management_System.DATABASE_HELPER
{
    internal class ReportSummaryOnlineDBHelper
    {
        ConnectionConf connectionConf = new ConnectionConf();
        public DataTable getTodaySales(string date, string unique_id, string branch_id)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.Maincon();
            try
            {
                string sql = "SELECT SUM(total_price) AS 'SALES' FROM sales WHERE date_to_show LIKE '%" + date + "%' AND branch_id = '" + branch_id + "' AND unique_id = '" + unique_id + "'";
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
        public DataTable getTodayTransaction(string date, string unique_id, string branch_id)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.Maincon();
            try
            {
                string sql = "SELECT COUNT(*) AS 'TRANSACTIONS' FROM transactions WHERE date_to_show LIKE '%" + date + "%' AND branch_id = '" + branch_id + "' AND unique_id = '" + unique_id + "'";
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
        public DataTable getTodayProductSold(string date, string unique_id, string branch_id)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.Maincon();
            try
            {
                string sql = "SELECT SUM(quantity) AS 'TOTAL' FROM sales WHERE date_to_show LIKE '%" + date + "%' AND branch_id = '" + branch_id + "' AND unique_id = '" + unique_id + "'";
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
        public DataTable getShortageProducts(string unique_id, string branch_id)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.Maincon();
            try
            {
                string sql = "SELECT COUNT(*) AS 'TOTAL' FROM products WHERE quantity <= 15  AND branch_id = '" + branch_id + "' AND unique_id = '" + unique_id + "'";
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
        public DataTable getTotalProducts(string unique_id, string branch_id)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.Maincon();
            try
            {
                string sql = "SELECT SUM(quantity) AS 'TOTAL' FROM products";
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
        public DataTable getThisMonthSales(string month, string year, string unique_id, string branch_id)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.Maincon();
            try
            {
                string sql = "SELECT SUM(total_price) AS 'SALES' FROM sales WHERE date_to_show LIKE '%" + month + "%' AND date_to_show LIKE '%" + year + "%' AND branch_id = '" + branch_id + "' AND unique_id = '" + unique_id + "'";
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
        public DataTable getThisMonthTransactions(string month, string year, string unique_id, string branch_id)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.Maincon();
            try
            {
                string sql = "SELECT COUNT(*) AS 'TRANSACTIONS' FROM transactions WHERE date_to_show LIKE '%" + month + "%' AND date_to_show LIKE '%" + year + "%' AND branch_id = '" + branch_id + "' AND unique_id = '" + unique_id + "'";
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
        public DataTable getTotalStaff(string unique_id, string branch_id)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.Maincon();
            try
            {
                string sql = "SELECT COUNT(*) AS 'STAFFS' FROM users  WHERE branch_id = '" + branch_id + "' AND unique_id = '" + unique_id + "'";
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
        public DataTable getTotalAdminStaff(string unique_id, string branch_id)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.Maincon();
            try
            {
                string sql = "SELECT COUNT(*) AS 'STAFFS' FROM users WHERE is_staff = 1 AND branch_id = '" + branch_id + "' AND unique_id = '" + unique_id + "'";
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
        public DataTable getTotalNonAdminStaff(string unique_id, string branch_id)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.Maincon();
            try
            {
                string sql = "SELECT COUNT(*) AS 'STAFFS' FROM users WHERE is_staff = 0  AND branch_id = '" + branch_id + "' AND unique_id = '" + unique_id + "'";
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
        public DataTable getThisYearSales(string year, string unique_id, string branch_id)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.Maincon();
            try
            {
                string sql = "SELECT SUM(total_price) AS 'SALES' FROM sales WHERE date_to_show LIKE '%" + year + "%'  AND branch_id = '" + branch_id + "' AND unique_id = '" + unique_id + "'";
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
        public DataTable getThisYearTransactions(string year, string unique_id, string branch_id)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.Maincon();
            try
            {
                string sql = "SELECT COUNT(*) AS 'TRANSACTIONS' FROM transactions WHERE date_to_show LIKE '%" + year + "%' AND branch_id = '" + branch_id + "' AND unique_id = '" + unique_id + "'";
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
    }
}
