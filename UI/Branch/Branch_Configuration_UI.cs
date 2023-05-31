using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThinkCE_Store_Management_System.DATABASE_HELPER.Auth;
using ThinkCE_Store_Management_System.GETTERS_AND_SETTERS;
using ThinkCE_Store_Management_System.SQLITE_DATABASE_HELPER;
using ThinkCE_Store_Management_System.UI.Auth;

namespace ThinkCE_Store_Management_System.UI.Branch
{
    public partial class Branch_Configuration_UI : Form
    {
        public Branch_Configuration_UI()
        {
            InitializeComponent();
        }
        Ini_App_Getter_Setter ini_App_Getter_Setter = new Ini_App_Getter_Setter();
        InitAppDatabaseHelper initAppDatabaseHelper = new InitAppDatabaseHelper();
        InitAppSqliteDatabaseHelper initAppSqliteDatabaseHelper = new InitAppSqliteDatabaseHelper();
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void toggleReadOnlyTextBox(bool is_read_only)
        {
            if (is_read_only)
            {
                companyNameTextBox.FillColor = Color.Gainsboro;
                companyLocationTextBox.FillColor = Color.Gainsboro;
                companyAddressTextBox.FillColor = Color.Gainsboro;
                uniqueIdTextBox.FillColor = Color.White;
                uniqueIdTextBox.ReadOnly = false;
            }
            else
            {
                companyAddressTextBox.FillColor = Color.White;
                companyLocationTextBox.FillColor = Color.White;
                companyNameTextBox.FillColor = Color.White;
                uniqueIdTextBox.ReadOnly = true;
                uniqueIdTextBox.FillColor = Color.Gainsboro;
            }
            companyAddressTextBox.ReadOnly = is_read_only;
            companyLocationTextBox.ReadOnly = is_read_only;
            companyNameTextBox.ReadOnly = is_read_only;
            
        }
        bool is_registered = false;
        private void alreadyRegisteredCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (alreadyRegisteredCheckBox.Checked)
            {
                toggleReadOnlyTextBox(true);
            }
            else
            {
                toggleReadOnlyTextBox(false);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(companyAddressTextBox.Text != "" && companyLocationTextBox.Text != "" && companyNameTextBox.Text != "")
            {
                Random random = new Random();
                DataTable d = initAppSqliteDatabaseHelper.SelectDataFromLocalDBToCompareInitApp();
                ini_App_Getter_Setter.branch_name = companyNameTextBox.Text;
                ini_App_Getter_Setter.branch_location = companyLocationTextBox.Text;
                ini_App_Getter_Setter.branch_address = companyAddressTextBox.Text;
               
                ini_App_Getter_Setter.unique_id = d.Rows[0]["unique_id"].ToString();
                ini_App_Getter_Setter.created = DateTime.Now;
                ini_App_Getter_Setter.contact = contact.Text;
                if (!is_registered)
                {
                    ini_App_Getter_Setter.branch_id = random.Next(1000000, 9000000).ToString();
                }
                else
                {
                    ini_App_Getter_Setter.branch_id = uniqueIdTextBox.Text;
                }
                bool is_success = false;
                if (!is_registered)
                {
                    is_success = initAppDatabaseHelper.insertBranchRecords(ini_App_Getter_Setter);
                }
                

                bool is_local_db_success = initAppSqliteDatabaseHelper.insertBranchRecords(ini_App_Getter_Setter);
                if (is_success || is_local_db_success)
                {
                    MessageBox.Show("Company Created Successfully With Unique Id Of " + ini_App_Getter_Setter.branch_id.ToString());
                    this.Hide();
                    new Login_User_UI().Show();
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
        }

        private void searchInFoBtn_Click(object sender, EventArgs e)
        {
            if (alreadyRegisteredCheckBox.Checked)
            {
                DataTable dataTable = initAppDatabaseHelper.SelectDataFromOnlineDBToCompareBranchOne(uniqueIdTextBox.Text);
                if (dataTable != null)
                {
                    if (dataTable.Rows.Count > 0)
                    {
                        companyLocationTextBox.Text = dataTable.Rows[0]["branch_location"].ToString();
                        companyAddressTextBox.Text = dataTable.Rows[0]["branch_address"].ToString();
                        companyNameTextBox.Text = dataTable.Rows[0]["branch_name"].ToString();
                        contact.Text = dataTable.Rows[0]["contact"].ToString();
                       
                        is_registered = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("You must first check if already registered");
            }
        }
    }
}
