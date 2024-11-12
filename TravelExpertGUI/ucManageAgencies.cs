using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertData.Data;
using TravelExpertData.Models;
using TravelExpertData.Repositories;

namespace TravelExpertGUI
{
    public partial class ucManageAgencies : UserControl
    {
        public ucManageAgencies()
        {
            InitializeComponent();
        }
        string function;
        

        private void ucManageAgencies_Load(object sender, EventArgs e)
        {
            // Loads all of our agencies 
            PopulateAgencies();
        }
        // Function to clear and populate datagrid view 
        private void PopulateAgencies()
        {
            dgvAgencies.Columns.Clear();
            dgvAgencies.DataSource = AgencyRepository.GetAgency();
            

            // format the column header
            dgvAgencies.EnableHeadersVisualStyles = false;
            dgvAgencies.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvAgencies.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAgencies.ColumnHeadersDefaultCellStyle.BackColor = Color.SlateBlue;
            dgvAgencies.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            // Manually change our column width, alignment, and header text
            //dgvAgencies.Columns[0].Width = 100;
            //dgvAgencies.Columns[0].HeaderText = "Code";
            //dgvAgencies.Columns[1].Width = 250;
            //dgvAgencies.Columns[2].Width = 50;
            //dgvAgencies.Columns[2].HeaderText = "Ver.";
            dgvAgencies.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Hides the row selection columns
            dgvAgencies.RowHeadersVisible = false;
            dgvAgencies.Columns[8].Visible = false;
            dgvAgencies.Columns[9].Visible = false;
            txtAgencyAddress.ReadOnly = true;
            txtCountry.ReadOnly = true;
            txtPostal.ReadOnly = true;
            txtCity.ReadOnly = true;
            txtProv.ReadOnly = true;
            txtPhone.ReadOnly = true;
            txtFax.ReadOnly = true;

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
                txtCountry.Text = dgvAgencies.CurrentRow.Cells["AgncyCountry"].Value.ToString();
                txtPhone.Text = dgvAgencies.CurrentRow.Cells["AgncyPhone"].Value.ToString();
                txtFax.Text = dgvAgencies.CurrentRow.Cells["AgncyFax"].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtAgencyId.Clear();
            txtAgencyAddress.Clear();
            txtCity.Clear();
            txtProv.Clear();
            txtCountry.Clear();
            txtPostal.Clear();
            txtPhone.Clear();
            txtFax.Clear();
            txtAgencyAddress.ReadOnly = false;
            txtCountry.ReadOnly = false;
            txtPostal.ReadOnly = false;
            txtCity.ReadOnly = false;
            txtProv.ReadOnly = false;
            txtPhone.ReadOnly = false;
            txtFax.ReadOnly = false;
            btnSave.Visible = true;
            function = "add";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (function == "add")
            {
                Agency newagency = new();
                newagency.AgncyAddress = txtAgencyAddress.Text;
                newagency.AgncyCity = txtCity.Text;
                newagency.AgncyProv = txtProv.Text;
                newagency.AgncyFax = txtFax.Text;
                newagency.AgncyPostal = txtPostal.Text;
                newagency.AgncyPhone = txtPhone.Text;
                newagency.AgncyCountry = txtCountry.Text;
                AgencyRepository.CreateLocation(newagency);
                PopulateAgencies();
            }
        }
    }
}
