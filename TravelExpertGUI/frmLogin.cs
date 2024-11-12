using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExpertGUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((txtUsername.Text == "admin" && txtPassword.Text == "1234") ||
                (txtUsername.Text == "agent" && txtPassword.Text == "1234"))
            {
                frmMain mainForm = new frmMain();
                mainForm.Show();
                this.Hide();
            }
        }
    }
}
