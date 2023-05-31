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
    public partial class Users_Details_Auth_UI : Form
    {
        string user_id = "";
        public Users_Details_Auth_UI()
        {
            InitializeComponent();
        }
        UsersSqliteDatabaseHelper usersSqliteDatabaseHelper = new UsersSqliteDatabaseHelper();
        AuthGetterAndSettter authGetterAndSettter = new AuthGetterAndSettter();
        private void loadAllData()
        {
            DataTable dt = usersSqliteDatabaseHelper.SelectUsersFromSqliteToDisplay();
            usersDetailDataGridview.DataSource = dt;
        }
        private void Users_Details_Auth_UI_Load(object sender, EventArgs e)
        {
            loadAllData();
        }

        private void usersDetailDataGridview_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                user_id = usersDetailDataGridview.Rows[rowIndex].Cells[0].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void SearchUserInfoFromSQLite(string name)
        {
            DataTable dataTable = usersSqliteDatabaseHelper.SearchUsersFromSqliteToDisplay(name);
            usersDetailDataGridview.DataSource = dataTable;
        }

        private void searchUserDetailTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchUserInfoFromSQLite(searchUserDetailTextBox.Text);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if(user_id != "")
            {
                new Update_User_Auth_UI(user_id).ShowDialog();
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            if(user_id != "")
            {
                DialogResult results  = MessageBox.Show("Are You Sure You Want To Delete", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (results == DialogResult.Yes)
                {
                    authGetterAndSettter.id = int.Parse(user_id);
                    if (usersSqliteDatabaseHelper.DeleteUserInfoToLocalDB(authGetterAndSettter))
                    {
                        loadAllData();
                    }
                }
            }
            
        }
    }
}
