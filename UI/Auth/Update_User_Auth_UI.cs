using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThinkCE_Store_Management_System.GETTERS_AND_SETTERS.Auth;
using ThinkCE_Store_Management_System.SQLITE_DATABASE_HELPER;

namespace ThinkCE_Store_Management_System.UI.Auth
{
    public partial class Update_User_Auth_UI : Form
    {
        string user_id = "";
        UsersSqliteDatabaseHelper usersSqliteDatabaseHelper = new UsersSqliteDatabaseHelper();
        AuthGetterAndSettter authGetterAndSettter = new AuthGetterAndSettter();
        InitAppSqliteDatabaseHelper initAppSqliteDatabaseHelper = new InitAppSqliteDatabaseHelper();
        AuthGetterAndSettter authGetterAndSetter = new AuthGetterAndSettter();
        int id;
        public Update_User_Auth_UI(string user_id)
        {
            InitializeComponent();
            this.user_id = user_id;
        }
        public void fillFieldsForSelectUser()
        {
            if(this.user_id != "")
            {
                DataTable dataTable = usersSqliteDatabaseHelper.SelectUsersFromSqliteForUpdate(int.Parse(user_id));
                if(dataTable != null)
                {
                    usernameTextBox.Text =  dataTable.Rows[0]["username"].ToString();
                    firstNameTextBox.Text = dataTable.Rows[0]["first_name"].ToString();
                    lastNameTextBox.Text = dataTable.Rows[0]["last_name"].ToString();
                    emailTextBox.Text = dataTable.Rows[0]["email"].ToString();
                    contactTextBox.Text = dataTable.Rows[0]["contact"].ToString();
                    id = int.Parse(dataTable.Rows[0]["id"].ToString());
                    if(dataTable.Rows[0]["is_staff"].ToString() == "1")
                    {
                        administratorRadioButton.Checked = true;
                    }
                    else
                    {
                        standardUserRadiobutton.Checked = true;
                    }
                    title.Text = "Update " + dataTable.Rows[0]["first_name"].ToString() + " " + dataTable.Rows[0]["last_name"].ToString() + " Info";
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }
        private void Update_User_Auth_UI_Load(object sender, EventArgs e)
        {
            fillFieldsForSelectUser();
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private bool is_valid()
        {
            bool isvilid = false;

            if(usernameTextBox.Text != "" && firstNameTextBox.Text != "" && lastNameTextBox.Text != "" && emailTextBox.Text != "" && contactTextBox.Text != "")
            {
                if(administratorRadioButton.Checked || standardUserRadiobutton.Checked)
                {
                    isvilid = true;
                }
            }

            return isvilid;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (is_valid())
            {
               
                
                   
                authGetterAndSetter.username = usernameTextBox.Text;
                authGetterAndSetter.first_name = firstNameTextBox.Text;
                authGetterAndSetter.last_name = lastNameTextBox.Text;
                authGetterAndSetter.contact = contactTextBox.Text;
                authGetterAndSetter.email = emailTextBox.Text;
                authGetterAndSetter.is_staff = (administratorRadioButton.Checked) ? 1 : 0;
                authGetterAndSetter.is_added_to_online_db = 0;
                authGetterAndSetter.updated_online = 0;
                authGetterAndSetter.id = id;
                   
                if (usersSqliteDatabaseHelper.UpdateUserInfoToLocalDB(authGetterAndSetter))
                {
                    MessageBox.Show("Data Updated For Local DB Only");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Data Is Invalid!!!!!");
                }
            

            }
            else
            {
                MessageBox.Show("Data Is Invalid");
            }
        }
    }
}
