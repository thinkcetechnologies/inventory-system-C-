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
    internal class GeneralDatabaseOnlineHelper
    {
        ConnectionConf connectionConf = new ConnectionConf();
        public DataTable getTheInsertIdFromOnlineDB(string dbtable, string unique_id, string branch_id = "")
        {
            DataTable table = new DataTable();
            MySqlConnection con = connectionConf.Maincon();
            try
            {
                string sql = "SELECT MAX(id) AS 'MAX ID' FROM " + dbtable + " WHERE unique_id = '" + unique_id + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(table);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return table;
        }
    }
}
