using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThinkCE_Store_Management_System.UI.Supplier;

namespace ThinkCE_Store_Management_System.UI
{
    public partial class Supplier_Main_UI : Form
    {
        public Supplier_Main_UI()
        {
            InitializeComponent();
        }
        Guna.UI2.WinForms.Guna2Button activeButton = null;
        private void toggleMenuButton(Guna.UI2.WinForms.Guna2Button pressedButton)
        {
            if (activeButton != null)
            {

                activeButton.FillColor = Color.Transparent;
                activeButton = null;
            }
            activeButton = pressedButton;
            activeButton.FillColor = Color.White;


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

        private void Supplier_Load(object sender, EventArgs e)
        {
            toggleMenuButton(detailsUserMenuBtn);
            openChildForm(new Suppliers_Details_UI());
            labelTxt.Text = "Supplier Details Infomation";
        }

        private void addUserMenuBtn_Click(object sender, EventArgs e)
        {
            toggleMenuButton(addUserMenuBtn);
            openChildForm(new Add_Supplier_UI());
            labelTxt.Text = "Add New Supplier Infomation";
        }

        private void detailsUserMenuBtn_Click(object sender, EventArgs e)
        {
            toggleMenuButton(detailsUserMenuBtn);
            openChildForm(new Suppliers_Details_UI());
            labelTxt.Text = "Supplier Details Infomation";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            toggleMenuButton(guna2Button1);
            openChildForm(new Add_Supplier_Order_UI());
            labelTxt.Text = "Supplier Orders Infomation";
        }
    }
}
