using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThinkCE_Store_Management_System.MAIN_ADMIN.Transactions;
using ThinkCE_Store_Management_System.MAIN_ADMIN.UI.Products;
using ThinkCE_Store_Management_System.MAIN_ADMIN.UI.STAFF;
using ThinkCE_Store_Management_System.MAIN_ADMIN.UI.Supplier;
using ThinkCE_Store_Management_System.UI.Auth;

namespace ThinkCE_Store_Management_System.MAIN_ADMIN.UI
{
    public partial class Main_Admin_Dashboard : Form
    {
        public Main_Admin_Dashboard()
        {
            InitializeComponent();
        }

        private void Main_Admin_Dashboard_Load(object sender, EventArgs e)
        {

        }
        FontAwesome.Sharp.IconButton activeButton = null;
        private void toggleMenuButton(FontAwesome.Sharp.IconButton pressedButton)
        {
            if (activeButton != null)
            {
                activeButton.ForeColor = Color.White;
                activeButton.BackColor = Color.Transparent;
                activeButton.IconColor = Color.White;
                activeButton = null;
            }
            activeButton = pressedButton;
            activeButton.BackColor = Color.White;
            activeButton.ForeColor = Color.Green;
            activeButton.IconColor = Color.Green;

        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(childForm);
            childFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void usersButton_Click(object sender, EventArgs e)
        {
            toggleMenuButton(usersButton);
            openChildForm(new Main_Admin_Staff_UI());
        }

        private void productsBtn_Click(object sender, EventArgs e)
        {
            toggleMenuButton(productsBtn);
            openChildForm(new Products_Main_Admin_UI());
        }

        private void transactionMenuBtn_Click(object sender, EventArgs e)
        {
            toggleMenuButton(transactionMenuBtn);
            openChildForm(new Transactions_Main_Admin_UI());
        }

        private void reportMenuBtn_Click(object sender, EventArgs e)
        {
            toggleMenuButton(reportMenuBtn);
            openChildForm(new Report_Main_Admin_UI());
        }

        private void supplierMenuBtn_Click(object sender, EventArgs e)
        {
            toggleMenuButton(supplierMenuBtn);
            openChildForm(new Supplier_Info_UI());
        }

        private void Main_Admin_Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

            this.Hide();
            new Login_User_UI().Show();
        }
    }
}
