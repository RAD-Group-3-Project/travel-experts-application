using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertData.Models;
using TravelExpertData.Repositories;

namespace TravelExpertGUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        CurrentUser currentuser = new();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            currentuser = UserRepository.UserLogin(txtUsername.Text, txtPassword.Text);
            if (currentuser.Username != null)
            {
                frmMain mainForm = new frmMain()
                {
                    currentuser = currentuser,
                };
                mainForm.ShowDialog();
                this.Close();
            }
            if (currentuser.Username == null)
            {
                MessageBox.Show("Invalid Username / Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Hides our password as we enter it 
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }
    }
}
