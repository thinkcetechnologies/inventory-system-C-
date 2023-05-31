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

namespace ThinkCE_Store_Management_System.UI.Auth
{
    public partial class Main_Users_Auth_UI : Form
    {
        public Main_Users_Auth_UI()
        {
            InitializeComponent();
        }

        private void childFormPanel_Paint(object sender, PaintEventArgs e)
        {

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

        private void addUserMenuBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Add_User_Auth_UI());
            toggleMenuButton(addUserMenuBtn);
        }

        private void detailsUserMenuBtn_Click(object sender, EventArgs e)
        {
            toggleMenuButton(detailsUserMenuBtn);
            openChildForm(new Users_Details_Auth_UI());
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Main_Users_Auth_UI_Load(object sender, EventArgs e)
        {
            toggleMenuButton(detailsUserMenuBtn);
            openChildForm(new Users_Details_Auth_UI());
        }
    }
}
