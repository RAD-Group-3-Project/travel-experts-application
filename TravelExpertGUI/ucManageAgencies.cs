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

            // Loads all of our agencies 
            dgvAgencies.DataSource = AgencyRepository.GetAgency();
        }

        private void dgvAgencies_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAgencies.CurrentRow != null) 
            { 
                txtAgencyId.Text = dgvAgencies.CurrentRow.Cells["AgencyId"].Value.ToString();
                txtAgencyAddress.Text = dgvAgencies.CurrentRow.Cells["AgncyAddress"].Value.ToString();
                txtCity.Text = dgvAgencies.CurrentRow.Cells["AgncyCity"].Value.ToString();
                txtProv.Text = dgvAgencies.CurrentRow.Cells["AgncyProv"].Value.ToString();
                txtCountry.Text = dgvAgencies.CurrentRow.Cells["AgncyCountry"].Value.ToString();
                txtPostal.Text = dgvAgencies.CurrentRow.Cells["AgncyPostal"].Value.ToString();
                txtCountry.Text = dgvAgencies.CurrentRow.Cells["AgncyCountry"].Value.ToString() ;
                txtPhone.Text = dgvAgencies.CurrentRow.Cells["AgncyPhone"].Value.ToString();
                txtFax.Text = dgvAgencies.CurrentRow.Cells["AgncyFax"].Value.ToString();


            }
        }
    }
}
