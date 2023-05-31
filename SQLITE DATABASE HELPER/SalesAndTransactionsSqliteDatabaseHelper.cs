using System;
using System.Collections.Generic;
using System.Data.SQLite;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ThinkCE_Store_Management_System.CONFIGURATIONS;
using ThinkCE_Store_Management_System.GETTERS_AND_SETTERS.Sales;
using System.Data;

namespace ThinkCE_Store_Management_System.SQLITE_DATABASE_HELPER
{
    internal class SalesAndTransactionsSqliteDatabaseHelper
    {
        ConnectionConf connectionConf = new ConnectionConf();
        public bool insertSales(SalesGetterAndSetter salesGetterAndSetter)
        {
            bool is_inserted = false;
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "INSERT INTO sales (product_id, product_name, sales_by, transaction_id, date_to_show, quantity, unit_price, total_price, unique_id, branch_id, date, is_online, returned) VALUES (@product_id, @product_name, @sales_by, @transaction_id, @date_to_show, @quantity, @unit_price, @total_price, @unique_id, @branch_id, @date, @is_online, @returned)";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                cmd.Parameters.AddWithValue("@product_id", salesGetterAndSetter.product_id);
                cmd.Parameters.AddWithValue("@product_name", salesGetterAndSetter.product_name);
                cmd.Parameters.AddWithValue("@transaction_id", salesGetterAndSetter.transaction_id);
                cmd.Parameters.AddWithValue("@quantity", salesGetterAndSetter.quantity);
                cmd.Parameters.AddWithValue("@unit_price", salesGetterAndSetter.unit_price);
                cmd.Parameters.AddWithValue("@total_price", salesGetterAndSetter.total_price);
                cmd.Parameters.AddWithValue("@unique_id", salesGetterAndSetter.unique_id);
                cmd.Parameters.AddWithValue("@sales_by", salesGetterAndSetter.sales_by);
                cmd.Parameters.AddWithValue("@branch_id", salesGetterAndSetter.branch_id);
                cmd.Parameters.AddWithValue("@is_online", salesGetterAndSetter.is_online);
                cmd.Parameters.AddWithValue("@date", salesGetterAndSetter.date);
                cmd.Parameters.AddWithValue("@returned", salesGetterAndSetter.returned);
                cmd.Parameters.AddWithValue("@date_to_show", salesGetterAndSetter.date_to_show);

                int row = cmd.ExecuteNonQuery();
                if(row > 0)
                {
                    is_inserted = true;
                }
                else
                {
                    is_inserted=false;
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
        public bool updateSalesForAllReturn(SalesGetterAndSetter salesGetterAndSetter)
        {
            bool is_inserted = false;
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "UPDATE sales SET returned = @returned WHERE transaction_id = @transaction_id";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                cmd.Parameters.AddWithValue("@transaction_id", salesGetterAndSetter.transaction_id);
                cmd.Parameters.AddWithValue("@returned", salesGetterAndSetter.returned);
                

                int row = cmd.ExecuteNonQuery();
                if (row > 0)
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
        public bool updateSalesForOneReturn(SalesGetterAndSetter salesGetterAndSetter)
        {
            bool is_inserted = false;
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "UPDATE sales SET returned = @returned WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", salesGetterAndSetter.id);
                cmd.Parameters.AddWithValue("@returned", salesGetterAndSetter.returned);


                int row = cmd.ExecuteNonQuery();
                if (row > 0)
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
        public bool insertTransactions(SalesGetterAndSetter salesGetterAndSetter)
        {
            bool is_inserted = false;
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "INSERT INTO transactions (transaction_id, date_to_show, sales_by, quantity, unit_price, total_price, unique_id, branch_id, date, is_online, returned) VALUES (@transaction_id, @date_to_show, @sales_by, @quantity, @unit_price, @total_price, @unique_id, @branch_id, @date, @is_online, @returned)";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                cmd.Parameters.AddWithValue("@transaction_id", salesGetterAndSetter.transaction_id);
                cmd.Parameters.AddWithValue("@quantity", salesGetterAndSetter.quantity);
                cmd.Parameters.AddWithValue("@unit_price", salesGetterAndSetter.unit_price);
                cmd.Parameters.AddWithValue("@total_price", salesGetterAndSetter.total_price);
                cmd.Parameters.AddWithValue("@sales_by", salesGetterAndSetter.sales_by);
                cmd.Parameters.AddWithValue("@unique_id", salesGetterAndSetter.unique_id);
                cmd.Parameters.AddWithValue("@branch_id", salesGetterAndSetter.branch_id);
                cmd.Parameters.AddWithValue("@is_online", salesGetterAndSetter.is_online);
                cmd.Parameters.AddWithValue("@date", salesGetterAndSetter.date);
                cmd.Parameters.AddWithValue("@returned", salesGetterAndSetter.returned);
                cmd.Parameters.AddWithValue("@date_to_show", salesGetterAndSetter.date_to_show);

                int row = cmd.ExecuteNonQuery();
                if (row > 0)
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
        public bool insertTransactionsReturns(SalesGetterAndSetter salesGetterAndSetter)
        {
            bool is_inserted = false;
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "UPDATE transactions SET returned = @returned WHERE transaction_id = @transaction_id";                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                cmd.Parameters.AddWithValue("@transaction_id", salesGetterAndSetter.transaction_id);
                
                cmd.Parameters.AddWithValue("@returned", salesGetterAndSetter.returned);

                int row = cmd.ExecuteNonQuery();
                if (row > 0)
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
        public bool insertTransactionsReturnsForQty(SalesGetterAndSetter salesGetterAndSetter)
        {
            bool is_inserted = false;
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "UPDATE transactions SET quantity = quantity -@quantity, unit_price = unit_price - @unit_price, total_price = total_price - @total_price WHERE transaction_id = @transaction_id"; 
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                cmd.Parameters.AddWithValue("@transaction_id", salesGetterAndSetter.transaction_id);
                cmd.Parameters.AddWithValue("@quantity", salesGetterAndSetter.quantity);
                cmd.Parameters.AddWithValue("@unit_price", salesGetterAndSetter.unit_price);
                cmd.Parameters.AddWithValue("@total_price", salesGetterAndSetter.total_price);
                cmd.Parameters.AddWithValue("@returned", salesGetterAndSetter.returned);

                int row = cmd.ExecuteNonQuery();
                if (row > 0)
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
        public DataTable getAllSalesData()
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "SELECT id AS 'SALES ID', product_name AS 'PRODUCT NAME', transaction_id AS 'TRANSACTION ID'," +
                    " quantity AS 'QUANTITY', unit_price AS 'UNIT PRICE', total_price AS 'TOTAL PRICE', " +
                    "sales_by AS 'SALES BY', date_to_show  AS 'DATE', time AS 'TIME' FROM sales WHERE returned = 0";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                dataAdapter.Fill(dataTable);
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

        public DataTable getAllTransactionData()
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "SELECT id AS 'ID', transaction_id AS 'TRANSACTION ID', quantity AS 'QUANTITY', unit_price AS 'UNIT PRICE', total_price AS 'TOTAL PRICE', sales_by AS 'SALES BY', date_to_show  AS 'DATE', time AS 'TIME' FROM transactions WHERE returned = 0";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                dataAdapter.Fill(dataTable);
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
        public DataTable getAllTransactionDataByYear(string year)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "SELECT id AS 'ID', transaction_id AS 'TRANSACTION ID', quantity AS 'QUANTITY', unit_price AS 'UNIT PRICE', total_price AS 'TOTAL PRICE', sales_by AS 'SALES BY', date_to_show  AS 'DATE', time AS 'TIME' FROM transactions WHERE date_to_show LIKE '%" + year + "%' AND returned = 0";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                dataAdapter.Fill(dataTable);
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
        public DataTable getAllSalesDataByYear(string year)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "SELECT id AS 'SALES ID', transaction_id AS 'TRANSACTION ID', quantity AS 'QUANTITY', unit_price AS 'UNIT PRICE',product_name AS 'PRODUCT NAME', total_price AS 'TOTAL PRICE', sales_by AS 'SALES BY',  date_to_show  AS 'DATE', time AS 'TIME' FROM sales WHERE date_to_show LIKE '%" + year + "%' AND returned = 0";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                dataAdapter.Fill(dataTable);
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
        public DataTable getAllSalesByMonthOfParticularYearData()
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "SELECT id AS 'SALES ID', trinasaction_id AS 'TRANSACTION ID', quantity AS 'QUANTITY', unit_price AS 'UNIT PRICE', total_price AS 'TOTAL PRICE', sales_by AS 'SALES BY', date  AS 'DATE' FROM sales WHERE returned = 0";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                dataAdapter.Fill(dataTable);
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
        public DataTable getAllSalesDataByPeriod(string from, string to)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "SELECT id AS 'SALES ID', transaction_id AS 'TRANSACTION ID', quantity AS 'QUANTITY', unit_price AS 'UNIT PRICE',product_name AS 'PRODUCT NAME', total_price AS 'TOTAL PRICE', sales_by AS 'SALES BY',  date_to_show  AS 'DATE', time AS 'TIME' FROM sales WHERE date BETWEEN '" + from + "' AND '" + to + "' AND returned = 0";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                dataAdapter.Fill(dataTable);
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
        public DataTable getAllTransactionDataByPeriod(string from, string to)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "SELECT id AS 'ID', transaction_id AS 'TRANSACTION ID', quantity AS 'QUANTITY', unit_price AS 'UNIT PRICE', total_price AS 'TOTAL PRICE', sales_by AS 'SALES BY', date_to_show  AS 'DATE', time AS 'TIME' FROM transactions WHERE date BETWEEN '" + from + "' AND '" + to + "' AND returned = 0";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                dataAdapter.Fill(dataTable);
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
        public DataTable getAllSalesDataByNameOrId(string id)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "SELECT id AS 'SALES ID', transaction_id AS 'TRANSACTION ID', quantity AS 'QUANTITY', unit_price AS 'UNIT PRICE',product_name AS 'PRODUCT NAME', total_price AS 'TOTAL PRICE', sales_by AS 'SALES BY',  date_to_show  AS 'DATE', time AS 'TIME' FROM sales WHERE product_name LIKE '%" + id + "%' AND returned = 0 OR transaction_id LIKE '%" + id + "%' AND returned = 0";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                dataAdapter.Fill(dataTable);
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
        public DataTable getAllSalesDataByDate(string date)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "SELECT id AS 'SALES ID', transaction_id AS 'TRANSACTION ID', quantity AS 'QUANTITY', unit_price AS 'UNIT PRICE',product_name AS 'PRODUCT NAME', total_price AS 'TOTAL PRICE', sales_by AS 'SALES BY',  date_to_show  AS 'DATE', time AS 'TIME' FROM sales WHERE date_to_show LIKE '%" + date + "%' AND returned = 0";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                dataAdapter.Fill(dataTable);
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
        public DataTable getAllTransactionDataByNameOrID(string id)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "SELECT id AS 'ID', transaction_id AS 'TRANSACTION ID', quantity AS 'QUANTITY', unit_price AS 'UNIT PRICE', total_price AS 'TOTAL PRICE', sales_by AS 'SALES BY', date_to_show  AS 'DATE', time AS 'TIME' FROM transactions WHERE transaction_id LIKE '%" + id + "%' AND returned = 0";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                dataAdapter.Fill(dataTable);
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
        public DataTable getAllTransactionDataByDate(string date)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "SELECT id AS 'ID', transaction_id AS 'TRANSACTION ID', quantity AS 'QUANTITY', unit_price AS 'UNIT PRICE', total_price AS 'TOTAL PRICE', sales_by AS 'SALES BY', date_to_show  AS 'DATE', time AS 'TIME' FROM transactions WHERE date_to_show LIKE '%" + date + "%' AND returned = 0";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                dataAdapter.Fill(dataTable);
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




        public DataTable getAllReturnedSalesData()
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "SELECT id AS 'SALES ID', product_name AS 'PRODUCT NAME', transaction_id AS 'TRANSACTION ID'," +
                    " quantity AS 'QUANTITY', unit_price AS 'UNIT PRICE', total_price AS 'TOTAL PRICE', " +
                    "sales_by AS 'SALES BY', date_to_show  AS 'DATE', time AS 'TIME' FROM sales WHERE returned = 1";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                dataAdapter.Fill(dataTable);
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
        public DataTable getAllReturnedTransactionData()
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "SELECT id AS 'ID', transaction_id AS 'TRANSACTION ID', quantity AS 'QUANTITY', unit_price AS 'UNIT PRICE', total_price AS 'TOTAL PRICE', sales_by AS 'SALES BY', date_to_show  AS 'DATE', time AS 'TIME' FROM transactions WHERE returned = 1";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                dataAdapter.Fill(dataTable);
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
