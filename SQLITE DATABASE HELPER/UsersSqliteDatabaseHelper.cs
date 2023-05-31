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
using ThinkCE_Store_Management_System.GETTERS_AND_SETTERS.Auth;

namespace ThinkCE_Store_Management_System.SQLITE_DATABASE_HELPER
{
    internal class UsersSqliteDatabaseHelper
    {
        ConnectionConf connectionConf = new ConnectionConf();
        public bool InsertUserInfoToLocalDB(AuthGetterAndSettter authGetterAndSetter)
        {
            bool is_inserted = false;
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "INSERT INTO users (username, first_name, last_name, password, is_staff, email, contact, unique_id, branch_id, joined, is_online) VALUES (@username, @first_name, @last_name, @password, @is_staff, @email, @contact, @unique_id, @branch_id, @joined, @is_online)";
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
                cmd.Parameters.AddWithValue("@is_online", authGetterAndSetter.is_added_to_online_db);

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
        public DataTable SelectUsersFromSqliteForUpdate(int id)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "SELECT * FROM users WHERE id = " + id;
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
        public DataTable SelectUsersFromSqliteToDisplay()
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "SELECT id AS 'USER ID', username AS 'USERNAME', first_name AS 'FIRST NAME', last_name AS 'LAST NAME', email AS 'E-MAIL', contact AS 'CONTACT NUMBER', joined AS 'DATE JOINED' FROM users";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }
            catch(Exception)
            {

            }
            finally
            {
                con.Close();
            }

            return dataTable;
        }
        public DataTable SearchUsersFromSqliteToDisplay(string name)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "SELECT id AS 'USER ID', username AS 'USERNAME', first_name AS 'FIRST NAME', last_name AS 'LAST NAME', email AS 'E-MAIL', contact AS 'CONTACT NUMBER', joined AS 'DATE JOINED' FROM users WHERE username LIKE '%" + name + "%' OR first_name LIKE '%" + name + "%' OR last_name LIKE '%" + name + "%'";
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
        public bool UpdateUserInfoToLocalDB(AuthGetterAndSettter authGetterAndSetter)
        {
            bool is_inserted = false;
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "UPDATE users SET username = @username, first_name = @first_name, updated_online = @updated_online, last_name = @last_name, is_staff = @is_staff, email = @email, contact = @contact, is_online = @is_online WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                cmd.Parameters.AddWithValue("@username", authGetterAndSetter.username);
                cmd.Parameters.AddWithValue("@first_name", authGetterAndSetter.first_name);
                cmd.Parameters.AddWithValue("@last_name", authGetterAndSetter.last_name);
                cmd.Parameters.AddWithValue("@is_staff", authGetterAndSetter.is_staff);
                cmd.Parameters.AddWithValue("@email", authGetterAndSetter.email);
                cmd.Parameters.AddWithValue("@contact", authGetterAndSetter.contact);
                cmd.Parameters.AddWithValue("@id", authGetterAndSetter.id);
                cmd.Parameters.AddWithValue("@is_online", authGetterAndSetter.is_added_to_online_db);
                cmd.Parameters.AddWithValue("@updated_online", authGetterAndSetter.updated_online);

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
        public bool DeleteUserInfoToLocalDB(AuthGetterAndSettter authGetterAndSetter)
        {
            bool is_inserted = false;
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "DELETE FROM users WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
               
                cmd.Parameters.AddWithValue("@id", authGetterAndSetter.id);
               

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
        public DataTable loginUserWithUsernameAndPasswordFromLocalDB(string username, string password)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "SELECT * FROM users WHERE username = '" + username + "' AND password = '" + password + "'";
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
        public bool insertUserSectionInfoToLocalDB(AuthGetterAndSettter authGetterAndSettter)
        {
            bool is_inserted = false;
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "INSERT INTO users_session (username, user_id, time) VALUES (@username, @user_id, @time)";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                cmd.Parameters.AddWithValue("@username",authGetterAndSettter.username);
                cmd.Parameters.AddWithValue("@user_id", authGetterAndSettter.id);
                cmd.Parameters.AddWithValue("@time", authGetterAndSettter.joined);

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
            catch (Exception)
            {

            }
            finally
            {
                con.Close();
            }

            return is_inserted;
        }
        public bool deleteUserSectionInfoFromLocalDB()
        {
            bool is_inserted = false;
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "DELETE FROM users_session";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
               

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
        public DataTable getLoggedInUser()
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "SELECT * FROM users_session";
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
