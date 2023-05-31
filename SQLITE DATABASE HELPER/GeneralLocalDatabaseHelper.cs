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
    internal class GeneralLocalDatabaseHelper
    {
        ConnectionConf connectionConf = new ConnectionConf();
        public bool updateIdFromDB(string table, int id_from_online, int is_online, int id, int updated_online = 1)
        {
            bool is_updated = false;
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "UPDATE " + table + " SET is_online = " + is_online + ", id_from_online = " + id_from_online + ", updated_online = " + updated_online +"  WHERE id = " + id;
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    is_updated = true;
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
            return is_updated;
        }
        public bool updateIdFromDBForSalesAndTrans(string table, int id_from_online, int is_online, int id)
        {
            bool is_updated = false;
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "UPDATE " + table + " SET is_online = " + is_online + ", id_from_online = " + id_from_online + "  WHERE id = " + id;
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    is_updated = true;
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
            return is_updated;
        }
        public DataTable selectNotOnlineData(string table)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "SELECT * FROM " + table + " WHERE is_online = " + 0;
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
