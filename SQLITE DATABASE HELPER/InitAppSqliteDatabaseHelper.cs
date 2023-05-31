using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThinkCE_Store_Management_System.CONFIGURATIONS;
using ThinkCE_Store_Management_System.GETTERS_AND_SETTERS;

namespace ThinkCE_Store_Management_System.SQLITE_DATABASE_HELPER
{
    internal class InitAppSqliteDatabaseHelper
    {
        ConnectionConf connectionConf = new ConnectionConf();

        public bool InsertInitAppInfo(Ini_App_Getter_Setter ini_App_Getter_Setter)
        {
            bool is_inserted = false;
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "INSERT INTO init_app (company_name, unique_id, date, company_location, company_address, number_of_branches) VALUES (@company_name, @unique_id, @date, @company_location, @company_address, @number_of_branches)";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                cmd.Parameters.AddWithValue("@company_name", ini_App_Getter_Setter.company_name);
                cmd.Parameters.AddWithValue("@unique_id", ini_App_Getter_Setter.unique_id);
                cmd.Parameters.AddWithValue("@company_location", ini_App_Getter_Setter.company_location);
                cmd.Parameters.AddWithValue("@company_address", ini_App_Getter_Setter.company_address);
                cmd.Parameters.AddWithValue("@number_of_branches", ini_App_Getter_Setter.num_of_branches);
                cmd.Parameters.AddWithValue("@date", ini_App_Getter_Setter.created);
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return is_inserted;
        }
        public bool insertBranchRecords(Ini_App_Getter_Setter ini_App_Getter_Setter)
        {
            bool is_inserted = false;
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "INSERT INTO branch (branch_name, branch_location, branch_address, unique_id, branch_unique_id, date, contact)" +
                    " VALUES (@branch_name, @branch_location, @branch_address, @unique_id, @branch_unique_id, @date, @contact)";
                MySqlCommand mySqlCommand = new MySqlCommand(sql, con);
                con.Open();
                mySqlCommand.Parameters.AddWithValue("@branch_name", ini_App_Getter_Setter.branch_name);
                mySqlCommand.Parameters.AddWithValue("@branch_location", ini_App_Getter_Setter.branch_location);
                mySqlCommand.Parameters.AddWithValue("@branch_address", ini_App_Getter_Setter.branch_address);
                mySqlCommand.Parameters.AddWithValue("@unique_id", ini_App_Getter_Setter.unique_id);
                mySqlCommand.Parameters.AddWithValue("@branch_unique_id", ini_App_Getter_Setter.branch_id);
                mySqlCommand.Parameters.AddWithValue("@contact", ini_App_Getter_Setter.contact);
                mySqlCommand.Parameters.AddWithValue("@date", ini_App_Getter_Setter.created);
                int rows = mySqlCommand.ExecuteNonQuery();
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
        public DataTable SelectDataFromLocalDBBranch()
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "SELECT * FROM branch";
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
        public DataTable SelectDataFromLocalDBToCompareInitApp()
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "SELECT * FROM init_app";
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
    }
}
