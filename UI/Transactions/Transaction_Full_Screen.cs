using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThinkCE_Store_Management_System.UI.Transactions
{
    public partial class Transaction_Full_Screen : Form
    {
        DataTable table;
        public Transaction_Full_Screen(DataTable dataTable)
        {
            InitializeComponent();
            table = dataTable;
        }

        private void Transaction_Full_Screen_Load(object sender, EventArgs e)
        {
            transDetailDataGridview.DataSource = table;
        }
    }
}
