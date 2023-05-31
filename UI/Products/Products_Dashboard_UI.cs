using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThinkCE_Store_Management_System.UI.Products
{
    public partial class Products_Dashboard_UI : Form
    {
        public Products_Dashboard_UI()
        {
            InitializeComponent();
        }

        private void Products_Dashboard_UI_Load(object sender, EventArgs e)
        {
            toggleMenuButton(detailsProductsMenuBtn);
            openChildForm(new Products_Details_UI());
            lableTxt.Text = "PRODUCTS DETAILS";
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
        Guna2Button activeButton = null;
        private void toggleMenuButton(Guna2Button pressedButton)
        {
            if (activeButton != null)
            {

                activeButton.FillColor = Color.Transparent;
                activeButton = null;
            }
            activeButton = pressedButton;
            activeButton.FillColor = Color.White;


        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            toggleMenuButton(addProductBtn);
            openChildForm(new Add_Product_UI());
            //new Add_Product_UI().ShowDialog();
            lableTxt.Text = "AND NEW PRODUCTS";
        }

        private void detailsProductsMenuBtn_Click(object sender, EventArgs e)
        {
            toggleMenuButton(detailsProductsMenuBtn);
            openChildForm(new Products_Details_UI());
            lableTxt.Text = "PRODUCTS DETAILS";
        }
    }
}
