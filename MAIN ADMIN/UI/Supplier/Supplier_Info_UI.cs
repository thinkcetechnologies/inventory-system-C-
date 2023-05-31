using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThinkCE_Store_Management_System.MAIN_ADMIN.UI.Supplier
{
    public partial class Supplier_Info_UI : Form
    {
        public Supplier_Info_UI()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            toggleMenuButton(guna2Button1);
            openChildForm(new Supplier_Order_Admin_UI());
            labelTxt.Text = "Supplier Orders";
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

        private void detailsUserMenuBtn_Click(object sender, EventArgs e)
        {
            toggleMenuButton(detailsUserMenuBtn);
            openChildForm(new Supplier_Details_UI());
            labelTxt.Text = "Supplier Details";
        }

        private void Supplier_Info_UI_Load(object sender, EventArgs e)
        {
            toggleMenuButton(guna2Button1);
            openChildForm(new Supplier_Order_Admin_UI());
            labelTxt.Text = "Supplier Orders";
        }
    }
}
