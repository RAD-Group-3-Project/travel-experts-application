using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        CurrentUser currentuser = new();
        private void button1_Click(object sender, EventArgs e)
        {
            currentuser = UserRepository.UserLogin(txtUser.Text, txtPassword.Text);
            if (currentuser.Username != null)
            {
                MainForm mainForm = new MainForm()
                {
                    currentuser = currentuser,
                };
                mainForm.ShowDialog();
                this.Close();
            }
            if (currentuser.Username == null)
            {
                MessageBox.Show("Invalid Username / Password");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
