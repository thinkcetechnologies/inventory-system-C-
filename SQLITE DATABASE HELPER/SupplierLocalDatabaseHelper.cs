using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThinkCE_Store_Management_System.CONFIGURATIONS;
using ThinkCE_Store_Management_System.GETTERS_AND_SETTERS.Suppliers;

namespace ThinkCE_Store_Management_System.SQLITE_DATABASE_HELPER
{
    internal class SupplierLocalDatabaseHelper
    {
        ConnectionConf connectionConf = new ConnectionConf();
        public bool insertSupplierIntoLocalDB(SuppliersGetterAndSetter suppliersGetterAndSetter)
        {
            bool is_inserted = false;
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "INSERT INTO suppliers (supplier_name, supplier_location, supplier_contact, supplier_address," +
                    " branch_id, unique_id, is_online, id_from_online, updated_online, date)" +
                    " VALUES " +
                    "(@supplier_name, @supplier_location, @supplier_contact, @supplier_address, @branch_id, @unique_id, @is_online, @id_from_online, @updated_online, @date)";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                cmd.Parameters.AddWithValue("@supplier_name", suppliersGetterAndSetter.supplier_name);
                cmd.Parameters.AddWithValue("@supplier_location", suppliersGetterAndSetter.supplier_location);
                cmd.Parameters.AddWithValue("@supplier_contact", suppliersGetterAndSetter.supplier_contact);
                cmd.Parameters.AddWithValue("@supplier_address", suppliersGetterAndSetter.supplier_address);
                cmd.Parameters.AddWithValue("@branch_id", suppliersGetterAndSetter.branch_id);
                cmd.Parameters.AddWithValue("@unique_id", suppliersGetterAndSetter.unique_id);
                cmd.Parameters.AddWithValue("@id_from_online", suppliersGetterAndSetter.id_from_online);
                cmd.Parameters.AddWithValue("@is_online", suppliersGetterAndSetter.is_online);
                cmd.Parameters.AddWithValue("@updated_online", suppliersGetterAndSetter.updated_online);
                cmd.Parameters.AddWithValue("@date", suppliersGetterAndSetter.date);
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
        public bool updateSupplierIntoLocalDB(SuppliersGetterAndSetter suppliersGetterAndSetter)
        {
            bool is_inserted = false;
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "UPDATE suppliers SET supplier_name = @supplier_name, supplier_location = @supplier_location, supplier_contact = @supplier_contact, supplier_address = @supplier_address," +
                    " date = @date";
                   
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                cmd.Parameters.AddWithValue("@supplier_name", suppliersGetterAndSetter.supplier_name);
                cmd.Parameters.AddWithValue("@supplier_location", suppliersGetterAndSetter.supplier_location);
                cmd.Parameters.AddWithValue("@supplier_contact", suppliersGetterAndSetter.supplier_contact);
                cmd.Parameters.AddWithValue("@supplier_address", suppliersGetterAndSetter.supplier_address);
                cmd.Parameters.AddWithValue("@updated_online", suppliersGetterAndSetter.updated_online);
                cmd.Parameters.AddWithValue("@date", suppliersGetterAndSetter.date);
                cmd.Parameters.AddWithValue("@id", suppliersGetterAndSetter.id);
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
        public DataTable getSupplierDataFromLocalDB()
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "SELECT id AS 'SUPPLIER ID', supplier_name AS 'SUPPLIER NAME', supplier_location AS 'SUPPLIER LOCATION', " +
                    "supplier_contact AS 'CONTACT NUMBER', supplier_address AS 'ADDRESS' FROM suppliers";
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
        public DataTable searchSupplierDataFromLocalDB(string name)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "SELECT id AS 'SUPPLIER ID', supplier_name AS 'SUPPLIER NAME', supplier_location AS 'SUPPLIER LOCATION', " +
                    "supplier_contact AS 'CONTACT NUMBER', supplier_address AS 'ADDRESS' FROM suppliers " +
                    "WHERE supplier_name LIKE '%" + name + "%' OR " +
                    "supplier_location LIKE '%" + name + "%' OR " +
                    "supplier_contact LIKE '%" + name + "%' OR " +
                    "supplier_address LIKE '%" + name + "%'";
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
        public DataTable getAllSupplierDataFromLocalDB()
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "SELECT * FROM suppliers";
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
        public bool deleteSupplierFromLocalDB(int id)
        {
            bool is_success = false;
            MySqlConnection con = connectionConf.LocalDBCon();

            try
            {
                string sql = "DELETE FROM suppliers WHERE id = " + id;

                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    is_success = true;
                }
                else
                {
                    is_success = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                
            }
            return is_success;
        }
    }
}
