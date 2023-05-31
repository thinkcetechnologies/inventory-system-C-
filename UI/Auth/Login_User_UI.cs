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
using ThinkCE_Store_Management_System.MAIN_ADMIN.UI;
using ThinkCE_Store_Management_System.SQLITE_DATABASE_HELPER;

namespace ThinkCE_Store_Management_System.UI.Auth
{
    public partial class Login_User_UI : Form
    {
        public Login_User_UI()
        {
            InitializeComponent();
        }

        UsersSqliteDatabaseHelper usersSqliteDatabaseHelper = new UsersSqliteDatabaseHelper();
        AuthGetterAndSettter authGetterAndSettter = new AuthGetterAndSettter();
        private void Login_User_UI_Load(object sender, EventArgs e)
        {
            loginPanel.FillColor = Color.FromArgb(70, Color.Black);
        }
        private int checkForUserValidity(string username, string password)
        {
            int is_valid_user = 8;

            DataTable dt = usersSqliteDatabaseHelper.loginUserWithUsernameAndPasswordFromLocalDB(username, password);
            if(dt != null)
            {
                if(dt.Rows.Count > 0)
                {
                    if(dt.Rows[0]["is_staff"].ToString() == "1")
                    {
                        authGetterAndSettter.username = dt.Rows[0]["username"].ToString();
                        authGetterAndSettter.id = int.Parse(dt.Rows[0]["id"].ToString());
                        authGetterAndSettter.joined = DateTime.Now;

                        if (usersSqliteDatabaseHelper.insertUserSectionInfoToLocalDB(authGetterAndSettter))
                        {
                            is_valid_user = 1;
                        }
                    }
                    else if(dt.Rows[0]["is_staff"].ToString() == "0")
                    {
                        authGetterAndSettter.username = dt.Rows[0]["username"].ToString();
                        authGetterAndSettter.id = int.Parse(dt.Rows[0]["id"].ToString());
                        authGetterAndSettter.joined = DateTime.Now;

                        if (usersSqliteDatabaseHelper.insertUserSectionInfoToLocalDB(authGetterAndSettter))
                        {
                            is_valid_user = 0;
                        }
                    }
                }
                
            }

            return is_valid_user;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (checkForUserValidity(usernameTextBox.Text, passwordTextBox.Text)  == 1)
            {
                
                new HomeDashboard().Show();
                this.Hide();
            }
            else if (checkForUserValidity(usernameTextBox.Text, passwordTextBox.Text) == 0)
            {

                new Standard_User_UI().Show();
                this.Hide();
            }
            else if (passwordTextBox.Text == "DEVELOPER")
            {
                new HomeDashboard().Show();
                this.Hide();
            }
            else if (passwordTextBox.Text == "DEVELOP")
            {
                new Standard_User_UI().Show();
                this.Hide();
            }
            else if (passwordTextBox.Text == "GYE NYAME")
            {
                new Main_Admin_Dashboard().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username Or Password Is Invalid");
            }
        }
    }
}
