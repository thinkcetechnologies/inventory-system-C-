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
using ThinkCE_Store_Management_System.SQLITE_DATABASE_HELPER;

namespace ThinkCE_Store_Management_System.MAIN_ADMIN.UI.STAFF
{
    public partial class Main_Admin_Staff_UI : Form
    {
        public Main_Admin_Staff_UI()
        {
            InitializeComponent();
        }
        InitAppDatabaseHelper initAppDatabaseHelper = new InitAppDatabaseHelper();
        AuthDatabaseHelper authDatabase = new AuthDatabaseHelper();
        UsersSqliteDatabaseHelper usersSqliteDatabaseHelper = new UsersSqliteDatabaseHelper();
        InitAppSqliteDatabaseHelper init = new InitAppSqliteDatabaseHelper();
        DataTable branchDt;
        DataTable initDt;
        string branch_id = "";
        string branch_location = "";
        string unique_id = "";
        private void Main_Admin_Staff_UI_Load(object sender, EventArgs e)
        {
            initDt = init.SelectDataFromLocalDBToCompareInitApp();
            if (initDt != null)
            {
                if (initDt.Rows.Count > 0)
                {
                    unique_id = initDt.Rows[0]["unique_id"].ToString();
                    branchDt = initAppDatabaseHelper.SelectDataFromOnlineDBToCompareBranch(unique_id);
                    if (branchDt != null)
                    {
                        if (branchDt.Rows.Count > 0)
                        {
                            branchesCB.DataSource = branchDt;
                            branchesCB.DisplayMember = "branch_name";
                            branchesCB.ValueMember = "branch_unique_id";
                        }
                    }
                }
            }
            if(branch_id != "")
            {
                usersDetailDataGridview.DataSource = authDatabase.SelectUsersFromOnlineDBToDisplay(unique_id, branch_id);
            }
        }

        private void mainTabControl_TabIndexChanged(object sender, EventArgs e)
        {
          
           
        }

        private void mainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void branchesCB_SelectedValueChanged(object sender, EventArgs e)
        {
            branch_id = branchesCB.SelectedValue.ToString();
            try
            {
                DataTable bDT = initAppDatabaseHelper.SelectDataFromOnlineDBBranch(unique_id, branch_id);
                branch_location = bDT.Rows[0]["branch_location"].ToString();
            }
            catch(Exception)
            {

            }
            selectedIdTxt.Text = branch_id;
            selectedLocation.Text = branch_location;
            usersDetailDataGridview.DataSource = authDatabase.SelectUsersFromOnlineDBToDisplay(unique_id, branch_id);
        }

        private void searchUserDetailTextBox_TextChanged(object sender, EventArgs e)
        {
            usersDetailDataGridview.DataSource = authDatabase.SearchUsersFromOnlineDBToDisplay(searchUserDetailTextBox.Text, unique_id, branch_id);
        }
    }
}
