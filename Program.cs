using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThinkCE_Store_Management_System.MAIN_ADMIN.UI;
using ThinkCE_Store_Management_System.SQLITE_DATABASE_HELPER;
using ThinkCE_Store_Management_System.UI.Auth;

namespace ThinkCE_Store_Management_System
{
    internal static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            InitAppSqliteDatabaseHelper initAppSqliteDatabaseHelper = new InitAppSqliteDatabaseHelper();

            DataTable dataTable = initAppSqliteDatabaseHelper.SelectDataFromLocalDBToCompareInitApp();

            int dataTableRows = dataTable.Rows.Count;

            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
          
            if (dataTableRows > 0)
            {
                Application.Run(new Login_User_UI());
            }
            else
            {
                //Application.Run(new Login_User_UI());
                Application.Run(new app_init());
            }

        }
    }
}
