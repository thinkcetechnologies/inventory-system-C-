using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThinkCE_Store_Management_System.CONFIGURATIONS;
using ThinkCE_Store_Management_System.GETTERS_AND_SETTERS;

namespace ThinkCE_Store_Management_System.DATABASE_HELPER.Auth
{
    internal class InitAppDatabaseHelper
    {
        ConnectionConf connectionConf = new ConnectionConf();
        public bool insertInitAppRecords(Ini_App_Getter_Setter ini_App_Getter_Setter)
        {
            bool is_inserted = false;
            MySqlConnection con = connectionConf.Maincon();
            try
            {
                string sql = "INSERT INTO init_app (company_name, company_location, company_address, number_of_branches, unique_id, created) VALUES (@company_name, @company_location, @company_address, @number_of_branches, @unique_id, @created)";
                MySqlCommand mySqlCommand = new MySqlCommand(sql, con);
                con.Open();
                mySqlCommand.Parameters.AddWithValue("@company_name", ini_App_Getter_Setter.company_name);
                mySqlCommand.Parameters.AddWithValue("@company_location", ini_App_Getter_Setter.company_location);
                mySqlCommand.Parameters.AddWithValue("@company_address", ini_App_Getter_Setter.company_address);
                mySqlCommand.Parameters.AddWithValue("@number_of_branches", ini_App_Getter_Setter.num_of_branches);
                mySqlCommand.Parameters.AddWithValue("@unique_id", ini_App_Getter_Setter.unique_id);
                mySqlCommand.Parameters.AddWithValue("@created", ini_App_Getter_Setter.created);

                int rows = mySqlCommand.ExecuteNonQuery();

                if (rows > 0)
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
        public bool insertBranchRecords(Ini_App_Getter_Setter ini_App_Getter_Setter)
        {
            bool is_inserted = false;
            MySqlConnection con = connectionConf.Maincon();
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
        public DataTable SelectDataFromOnlineDBToCompareBranch(string unique_id)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.Maincon();
            try
            {
                string sql = "SELECT * FROM branch WHERE unique_id = '" + unique_id + "'";
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
        public DataTable SelectDataFromOnlineDBToCompareBranchOne(string unique_id)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.Maincon();
            try
            {
                string sql = "SELECT * FROM branch WHERE branch_unique_id = '" + unique_id + "'";
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
        public DataTable SelectDataFromOnlineDBBranch(string unique_id, string branch_id)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.Maincon();
            try
            {
                string sql = "SELECT * FROM branch WHERE unique_id = '" + unique_id + "' AND branch_unique_id = '" + branch_id + "'";
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
        public DataTable SelectDataFromOnlineDBToCompareInitApp(string unique_id)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.Maincon();
            try
            {
                string sql = "SELECT * FROM init_app WHERE unique_id = '" + unique_id +"'";
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
