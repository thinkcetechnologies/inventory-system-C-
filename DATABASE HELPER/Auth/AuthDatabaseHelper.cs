using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThinkCE_Store_Management_System.CONFIGURATIONS;
using ThinkCE_Store_Management_System.GETTERS_AND_SETTERS.Auth;
namespace ThinkCE_Store_Management_System.DATABASE_HELPER.Auth
{
    internal class AuthDatabaseHelper
    {
        ConnectionConf connectionConf = new ConnectionConf();
        public DataTable SelectUserToDisplay()
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.Maincon();
            try
            {
                string sql = "SELECT id AS ID, username AS USERNAME, first_name AS 'FIRST NAME', last_name AS 'LAST NAME', email AS EMAIL, contact AS CONTACT FROM users";
                MySqlCommand mySqlCommand = new MySqlCommand(sql, con);
                connectionConf.Maincon().Open();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                mySqlDataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connectionConf.Maincon().Close();
            }
            return dataTable;
        }
        public bool InsertUserInfoToOnlineDB(AuthGetterAndSettter authGetterAndSetter)
        {
            bool is_inserted = false;
            MySqlConnection con = connectionConf.Maincon();
            try
            {
                string sql = "INSERT INTO users " +
                    "(username, first_name, last_name, password, is_staff, email, contact, unique_id, branch_id, joined)" +
                    " VALUES " +
                    "(@username, @first_name, @last_name, @password, @is_staff, @email, @contact, @unique_id,@branch_id, @joined)";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                cmd.Parameters.AddWithValue("@username", authGetterAndSetter.username);
                cmd.Parameters.AddWithValue("@first_name", authGetterAndSetter.first_name);
                cmd.Parameters.AddWithValue("@last_name", authGetterAndSetter.last_name);
                cmd.Parameters.AddWithValue("@password", authGetterAndSetter.password);
                cmd.Parameters.AddWithValue("@is_staff", authGetterAndSetter.is_staff);
                cmd.Parameters.AddWithValue("@email", authGetterAndSetter.email);
                cmd.Parameters.AddWithValue("@contact", authGetterAndSetter.contact);
                cmd.Parameters.AddWithValue("@joined", authGetterAndSetter.joined);
                cmd.Parameters.AddWithValue("@unique_id", authGetterAndSetter.app_id);
                cmd.Parameters.AddWithValue("@branch_id", authGetterAndSetter.branch_id);
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
        public bool UpdateUserInfoToOnlineDB(AuthGetterAndSettter authGetterAndSetter)
        {
            bool is_inserted = false;
            MySqlConnection con = connectionConf.Maincon();
            try
            {
                string sql = "UPDATE users SET username = @username, first_name = @first_name, " +
                    "last_name = @last_name, is_staff = @is_staff, email = @email, contact = @contact," +
                    " is_online = @is_online WHERE id = @id AND unique_id = @unique_id";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                cmd.Parameters.AddWithValue("@username", authGetterAndSetter.username);
                cmd.Parameters.AddWithValue("@first_name", authGetterAndSetter.first_name);
                cmd.Parameters.AddWithValue("@last_name", authGetterAndSetter.last_name);
                cmd.Parameters.AddWithValue("@is_staff", authGetterAndSetter.is_staff);
                cmd.Parameters.AddWithValue("@email", authGetterAndSetter.email);
                cmd.Parameters.AddWithValue("@contact", authGetterAndSetter.contact);
                cmd.Parameters.AddWithValue("@id", authGetterAndSetter.id);
                cmd.Parameters.AddWithValue("@unique_id", authGetterAndSetter.app_id);
                cmd.Parameters.AddWithValue("@is_online", authGetterAndSetter.is_added_to_online_db);
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
        public DataTable SelectUsersFromOnlineDBToDisplay(string unique_id, string branch_id)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.Maincon();
            try
            {
                string sql = "SELECT id AS 'USER ID', username AS 'USERNAME', first_name AS 'FIRST NAME'," +
                    " last_name AS 'LAST NAME', email AS 'E-MAIL', contact AS 'CONTACT NUMBER', joined AS " +
                    "'DATE JOINED' FROM users WHERE unique_id = '" + unique_id + "' AND branch_id = '" + branch_id + "'";
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
        public DataTable SearchUsersFromOnlineDBToDisplay(string name, string unique_id, string branch_id)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.Maincon();
            try
            {
                string sql = "SELECT id AS 'USER ID', username AS 'USERNAME', first_name AS 'FIRST NAME'," +
                    " last_name AS 'LAST NAME', email AS 'E-MAIL', contact AS 'CONTACT NUMBER', joined AS " +
                    "'DATE JOINED' FROM users WHERE username LIKE '%" + name + "%' AND unique_id = '" + unique_id + "'" +
                    " AND branch_id = '" + branch_id + "' OR first_name LIKE '%" + name + "%' AND " +
                    "unique_id = '" + unique_id + "' AND branch_id = '" + branch_id + "' OR " +
                    "last_name LIKE '%" + name + "%' AND unique_id = '" + unique_id + "' AND branch_id = '" + branch_id + "'";
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
