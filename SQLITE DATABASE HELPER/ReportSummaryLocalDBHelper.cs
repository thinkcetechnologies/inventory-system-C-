using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ThinkCE_Store_Management_System.CONFIGURATIONS;

namespace ThinkCE_Store_Management_System.SQLITE_DATABASE_HELPER
{
    internal class ReportSummaryLocalDBHelper
    {
        ConnectionConf connectionConf = new ConnectionConf();
        public DataTable getTodaySales(string date)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "SELECT SUM(total_price) AS 'SALES' FROM sales WHERE date_to_show LIKE '%" + date + "%' AND returned = 0";
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
        public DataTable getTodayTransaction(string date)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "SELECT COUNT(*) AS 'TRANSACTIONS' FROM transactions WHERE date_to_show LIKE '%" + date + "%' AND returned = 0";
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
        public DataTable getTodayProductSold(string date)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "SELECT SUM(quantity) AS 'TOTAL' FROM sales WHERE date_to_show LIKE '%" + date + "%' ";
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
        public DataTable getShortageProducts()
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "SELECT COUNT(*) AS 'TOTAL' FROM products WHERE quantity <= 15";
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
        public DataTable getTotalProducts()
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
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
        public DataTable getThisMonthSales(string month, string year)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "SELECT SUM(total_price) AS 'SALES' FROM sales WHERE date_to_show LIKE '%" + month + "%' AND date_to_show LIKE '%" + year + "%' AND returned = 0";
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
        public DataTable getThisMonthTransactions(string month, string year)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "SELECT COUNT(*) AS 'TRANSACTIONS' FROM transactions WHERE date_to_show LIKE '%" + month + "%' AND date_to_show LIKE '%" + year + "%' AND returned = 0";
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
        public DataTable getTotalStaff()
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "SELECT COUNT(*) AS 'STAFFS' FROM users";
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
        public DataTable getTotalAdminStaff()
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "SELECT COUNT(*) AS 'STAFFS' FROM users WHERE is_staff = 1";
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
        public DataTable getTotalNonAdminStaff()
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "SELECT COUNT(*) AS 'STAFFS' FROM users WHERE is_staff = 0";
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
        public DataTable getThisYearSales(string year)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "SELECT SUM(total_price) AS 'SALES' FROM sales WHERE date_to_show LIKE '%" + year + "%' ";
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
        public DataTable getThisYearTransactions(string year)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "SELECT COUNT(*) AS 'TRANSACTIONS' FROM transactions WHERE date_to_show LIKE '%" + year + "%' ";
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
