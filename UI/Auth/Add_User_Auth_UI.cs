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
using ThinkCE_Store_Management_System.GETTERS_AND_SETTERS.Auth;
using ThinkCE_Store_Management_System.SQLITE_DATABASE_HELPER;

namespace ThinkCE_Store_Management_System.UI.Auth
{
    public partial class Add_User_Auth_UI : Form
    {
        public Add_User_Auth_UI()
        {
            InitializeComponent();
        }
        AuthDatabaseHelper authDatabaseHelper = new AuthDatabaseHelper();

        UsersSqliteDatabaseHelper usersSqliteDatabaseHelper = new UsersSqliteDatabaseHelper();
        AuthGetterAndSettter authGetterAndSetter = new AuthGetterAndSettter();
        InitAppSqliteDatabaseHelper initAppSqliteDatabaseHelper = new InitAppSqliteDatabaseHelper();
        int is_staff = 0;
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                DataTable dt = initAppSqliteDatabaseHelper.SelectDataFromLocalDBToCompareInitApp();
                DataTable d = initAppSqliteDatabaseHelper.SelectDataFromLocalDBBranch();
                if (dt != null && d != null)
                {
                    string unique_id = dt.Rows[0]["unique_id"].ToString();
                    authGetterAndSetter.username = usernameTextBox.Text;
                    authGetterAndSetter.first_name = firstNameTextBox.Text;
                    authGetterAndSetter.last_name = lastNameTextBox.Text;
                    authGetterAndSetter.contact = contactTextBox.Text;
                    authGetterAndSetter.app_id = unique_id;
                    authGetterAndSetter.email = emailTextBox.Text;
                    authGetterAndSetter.password = passwordTextBox.Text;
                    authGetterAndSetter.is_staff = is_staff;
                    authGetterAndSetter.joined = DateTime.Now;
                    authGetterAndSetter.is_added_to_online_db = 0;
                    authGetterAndSetter.branch_id = d.Rows[0]["branch_unique_id"].ToString();
                    if (usersSqliteDatabaseHelper.InsertUserInfoToLocalDB(authGetterAndSetter))
                    {
                        clear();
                        MessageBox.Show("Data Stored For Local DB Only");
                        loadAllData();
                    } 
                }
            }
            else
            {
                MessageBox.Show("Not Valid");
            }
        }
        private bool validate()
        {
            bool is_valid = false;
            if (usernameTextBox.Text != "" || passwordTextBox.Text != "" || firstNameTextBox.Text != ""
                || lastNameTextBox.Text != "" || emailTextBox.Text != "" || confirmPasswordTextBox.Text != "" || contactTextBox.Text != "")
            {
                if (passwordTextBox.Text == confirmPasswordTextBox.Text)
                {
                    if (standardUserRadiobutton.Checked || administratorRadioButton.Checked)
                    {
                        is_valid = true;
                    } 
                }
                else
                {
                    is_valid = false;
                }
            }
            return is_valid;
        }

        private void administratorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (administratorRadioButton.Checked)
            {
                is_staff = 1;
            }
        }

        private void standardUserRadiobutton_CheckedChanged(object sender, EventArgs e)
        {
            if (standardUserRadiobutton.Checked)
            {
                is_staff = 0;
            }
        }
        private void loadAllData()
        {
            DataTable dt = usersSqliteDatabaseHelper.SelectUsersFromSqliteToDisplay();
            usersDetailDataGridview.DataSource = dt;
        }
        private void Add_User_Auth_UI_Load(object sender, EventArgs e)
        {
            loadAllData();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void clear()
        {
            usernameTextBox.Text = "";
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            emailTextBox.Text = "";
            confirmPasswordTextBox.Text = "";
            passwordTextBox.Text = "";
            contactTextBox.Text = "";
            administratorRadioButton.Checked = false;
            standardUserRadiobutton.Checked = false;

        }
    }
}
