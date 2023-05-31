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
using ThinkCE_Store_Management_System.UI.Branch;

namespace ThinkCE_Store_Management_System.UI.Auth
{
    public partial class app_init : Form
    {
        Ini_App_Getter_Setter ini_App_Getter_Setter = new Ini_App_Getter_Setter();
        InitAppDatabaseHelper initAppDatabaseHelper = new InitAppDatabaseHelper();
        InitAppSqliteDatabaseHelper initAppSqliteDatabaseHelper = new InitAppSqliteDatabaseHelper();
        public app_init()
        {
            InitializeComponent();
        }
        bool is_registed = false;
        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void toggleReadOnlyTextBox(bool is_read_only)
        {
            if (is_read_only)
            {
                companyNumOfBranchesTextBox.FillColor = Color.Gainsboro;
                companyNameTextBox.FillColor = Color.Gainsboro;
                companyLocationTextBox.FillColor = Color.Gainsboro;
                companyAddressTextBox.FillColor = Color.Gainsboro;
                idNumer.FillColor = Color.Gainsboro;
                uniqueIdTextBox.FillColor = Color.White;
                uniqueIdTextBox.ReadOnly = false;
            }
            else
            {
                companyAddressTextBox.FillColor = Color.White;
                companyLocationTextBox.FillColor = Color.White;
                companyNameTextBox.FillColor = Color.White;
                idNumer.FillColor = Color.White;
                companyNumOfBranchesTextBox.FillColor = Color.White; 
                uniqueIdTextBox.ReadOnly = true;
                uniqueIdTextBox.FillColor = Color.Gainsboro;
            }
            companyAddressTextBox.ReadOnly = is_read_only;
            companyLocationTextBox.ReadOnly = is_read_only;
            companyNameTextBox.ReadOnly = is_read_only;
            companyNumOfBranchesTextBox.ReadOnly = is_read_only;
        }
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
            if (companyAddressTextBox.Text != "" && companyLocationTextBox.Text != "" && companyNameTextBox.Text != "" && companyNumOfBranchesTextBox.Text != "")
            {
                Random random = new Random();
                ini_App_Getter_Setter.company_name = companyNameTextBox.Text;
                ini_App_Getter_Setter.company_location = companyLocationTextBox.Text;
                ini_App_Getter_Setter.company_address = companyAddressTextBox.Text;
                ini_App_Getter_Setter.num_of_branches = int.Parse(companyNumOfBranchesTextBox.Text);
                ini_App_Getter_Setter.unique_id = idNumer.Text;
                ini_App_Getter_Setter.created = DateTime.Now;
                bool is_success = false;
                if (!is_registed)
                {
                    initAppDatabaseHelper.insertInitAppRecords(ini_App_Getter_Setter);
                    is_success = true;
                }

                bool is_local_db_success = initAppSqliteDatabaseHelper.InsertInitAppInfo(ini_App_Getter_Setter);
                if (is_success || is_local_db_success)
                {
                    MessageBox.Show("Company Created Successfully With Unique Id Of " + ini_App_Getter_Setter.unique_id.ToString());
                    this.Hide();
                    new Branch_Configuration_UI().Show();
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
            else
            {
                MessageBox.Show("Please fields are required!", "Warning");
            }
        }

        private void searchInFoBtn_Click(object sender, EventArgs e)
        {
            if (alreadyRegisteredCheckBox.Checked)
            {
                DataTable dataTable = initAppDatabaseHelper.SelectDataFromOnlineDBToCompareInitApp(uniqueIdTextBox.Text);
                if(dataTable != null)
                {
                    if(dataTable.Rows.Count > 0)
                    {
                        companyLocationTextBox.Text = dataTable.Rows[0]["company_location"].ToString();
                        companyAddressTextBox.Text = dataTable.Rows[0]["company_address"].ToString();
                        companyNameTextBox.Text = dataTable.Rows[0]["company_name"].ToString();
                        idNumer.Text = dataTable.Rows[0]["unique_id"].ToString();
                        companyNumOfBranchesTextBox.Text = dataTable.Rows[0]["number_of_branches"].ToString();
                        is_registed = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("You must first check if already registered");
            }
        }

        private void app_init_Load(object sender, EventArgs e)
        {

        }
    }
}
