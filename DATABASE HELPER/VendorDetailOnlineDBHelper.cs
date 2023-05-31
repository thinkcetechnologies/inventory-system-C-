using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThinkCE_Store_Management_System.CONFIGURATIONS;
using ThinkCE_Store_Management_System.GETTERS_AND_SETTERS.Suppliers;

namespace ThinkCE_Store_Management_System.DATABASE_HELPER
{
    internal class VendorDetailOnlineDBHelper
    {
        ConnectionConf connectionConf = new ConnectionConf();
        public bool insertVendorDetailToLocalDB(VendorDetailsGS vendorDetailGS)
        {
            bool is_inserted = false;
            MySqlConnection con = connectionConf.Maincon();
            try
            {
                string sql = "INSERT INTO vendor_details " +
                    "(vendor, status, amount, branch_id, unique_id, added_by, added_at," +
                    " updated_at, part_payment_amount ) " +
                    " VALUES " +
                    "(@vendor, @status, @amount, @branch_id, @unique_id, @added_by, @added_at," +
                    " @updated_at, @part_payment_amount)";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                cmd.Parameters.AddWithValue("@vendor", vendorDetailGS.vendor_name);
                cmd.Parameters.AddWithValue("@status", vendorDetailGS.status);
                cmd.Parameters.AddWithValue("@amount", vendorDetailGS.amount);
                cmd.Parameters.AddWithValue("@branch_id", vendorDetailGS.branch_id);
                cmd.Parameters.AddWithValue("@unique_id", vendorDetailGS.unique_id);
                cmd.Parameters.AddWithValue("@added_by", vendorDetailGS.added_by);
                cmd.Parameters.AddWithValue("@added_at", vendorDetailGS.added_at);
                cmd.Parameters.AddWithValue("@part_payment_amount", vendorDetailGS.part_payment_amount);
                cmd.Parameters.AddWithValue("@updated_at", vendorDetailGS.updated_at);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    is_inserted = true;
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
        public bool updateVendorDetailToLocalDB(VendorDetailsGS vendorDetailGS)
        {
            bool is_inserted = false;
            MySqlConnection con = connectionConf.Maincon();
            try
            {
                string sql = "UPDATE vendor_details SET " +
                    " status = @status, " +
                    " part_payment_amount = @part_payment_amount, updated_at = @updated_at WHERE id = @id"
                    ;
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", vendorDetailGS.id);
                cmd.Parameters.AddWithValue("@status", vendorDetailGS.status);
                cmd.Parameters.AddWithValue("@updated_at", vendorDetailGS.updated_at);
                cmd.Parameters.AddWithValue("@part_payment_amount", vendorDetailGS.part_payment_amount);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    is_inserted = true;
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
        public DataTable getVendorDetailsDataFromLocalDB(string unique_id, string branch_id)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.Maincon();
            try
            {
                string sql = "SELECT id 'ID', vendor AS 'SUPPLIER / VENDOR', amount AS 'AMOUNT', " +
                    "status 'PAYMENT STATUS', part_payment_amount AS 'PAID AMOUNT', added_by AS 'ADDED BY', added_at AS 'DATE ADDED'," +
                    " updated_at AS 'DATE UPDATED' FROM vendor_details WHERE unique_id = '" + unique_id + "' AND branch_id = '" + branch_id + "'";
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
        public DataTable searchVendorDetailsDataFromLocalDB(string name, string unique_id, string branch_id)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.Maincon();
            try
            {
                string sql = "SELECT id 'ID', vendor AS 'SUPPLIER / VENDOR', amount AS 'AMOUNT', " +
                    "status 'PAYMENT STATUS', part_payment_amount AS 'PAID AMOUNT', added_by AS 'ADDED BY', added_at AS 'DATE ADDED'," +
                    " updated_at AS 'DATE UPDATED' FROM vendor_details " +
                    "WHERE " +
                    "vendor LIKE '%" + name + "%' AND unique_id = '" + unique_id + "' AND branch_id = '" + branch_id + "'" +
                    "OR " +
                    "status LIKE '%" + name + "%' AND unique_id = '" + unique_id + "' AND branch_id = '" + branch_id + "'";
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
        public DataTable searchOneVendorDetailsDataFromLocalDB(int id)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = connectionConf.LocalDBCon();
            try
            {
                string sql = "SELECT * FROM vendor_details WHERE id = " + id;
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
