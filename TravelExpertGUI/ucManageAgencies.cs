using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertData.Repositories;

namespace TravelExpertGUI
{
    public partial class ucManageAgencies : UserControl
    {
        public ucManageAgencies()
        {
            InitializeComponent();
        }

        private void ucManageAgencies_Load(object sender, EventArgs e)
        {
            dgvAgencies.DataSource = AgencyRepository.GetAgency();
        }
    }
}
