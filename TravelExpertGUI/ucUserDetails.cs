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

namespace TravelExpertGUI
{
    public partial class ucUserDetails : UserControl
    {
        public ucUserDetails()
        {
            InitializeComponent();
        }
        public CurrentUser currentuser = new CurrentUser();
        private void ucUserDetails_Load(object sender, EventArgs e)
        {
            txtUsername.Text = currentuser.Username.ToString();
            if (currentuser.IS_Admin) 
            {
                txtPriv.Text = "Full";
            }
            else
            {
                txtPriv.Text = "Limited";
            }
        }
    }
}
