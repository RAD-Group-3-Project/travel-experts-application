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
using static System.Windows.Forms.AxHost;

namespace TravelExpertGUI;
public partial class ucManageAgents : UserControl
{
    public ucManageAgents()
    {
        InitializeComponent();
    }

    private void ucManageAgents_Load(object sender, EventArgs e)
    {
        PopulateAgents();
    }

    private void PopulateAgents()
    {
        dgvAgents.Columns.Clear();
        dgvAgents.DataSource = AgentRepository.GetAgents();
    }

    public string function;

    private void dgvAgents_SelectionChanged(object sender, EventArgs e)
    {
        if (dgvAgents.CurrentRow != null) // if row selected
        {   

            loadAgencies();
            txtAgntId.Text = dgvAgents.CurrentRow.Cells["AgentId"].Value.ToString();
            txtAgntFName.Text = dgvAgents.CurrentRow.Cells["AgtFirstName"].Value.ToString();
            if (dgvAgents.CurrentRow.Cells["AgtMiddleInitial"].Value != null)
            {
                txtMiddleInit.Text = dgvAgents.CurrentRow.Cells["AgtMiddleInitial"].Value.ToString();
            }
            else
            {
                txtMiddleInit.Text = string.Empty; 
            }
            txtAgntLName.Text = dgvAgents.CurrentRow.Cells["AgtLastName"].Value.ToString();
            txtAgntBusPhone.Text = dgvAgents.CurrentRow.Cells["AgtBusPhone"].Value.ToString();
            txtAgntEmail.Text = dgvAgents.CurrentRow.Cells["AgtEmail"].Value.ToString();
            txtAgntPosition.Text = dgvAgents.CurrentRow.Cells["AgtPosition"].Value.ToString();
            var selectedAgencyId = dgvAgents.CurrentRow.Cells["AgencyId"].Value.ToString();
            cboAgency.SelectedValue = int.Parse(selectedAgencyId);

        }
    }

    public void loadAgencies()
    {
        List<Agency> agencies = AgencyRepository.GetAgency();

        // Set the DataSource and DisplayMember for the combo box
        cboAgency.DataSource = agencies;
        cboAgency.DisplayMember = "AgncyCity";
        cboAgency.ValueMember = "AgencyId";



    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        txtAgntId.Clear();
        txtAgntFName.Clear();
        txtAgntLName.Clear();
        txtAgntBusPhone.Clear();
        txtAgntEmail.Clear();
        txtAgntPosition.Clear();
        txtMiddleInit.Clear();
        txtAgntFName.ReadOnly = false;
        txtAgntLName.ReadOnly = false;
        txtAgntBusPhone.ReadOnly = false;
        txtAgntEmail.ReadOnly = false;
        txtAgntPosition.ReadOnly = false;
        txtMiddleInit.ReadOnly = false;
        cboAgency.Enabled = true;
        btnSave.Enabled = true;
        function = "ADD";



    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        MessageBox.Show("This function is not implemented yet", "Not Implemented", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //TODO: Implement here
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        MessageBox.Show("This function is not implemented yet", "Not Implemented", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //TODO: Implement here
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        if (function == "ADD")
        {
            Agent newAgent = new Agent();
            newAgent.AgtFirstName = txtAgntFName.Text;
            newAgent.AgtLastName = txtAgntLName.Text;
            newAgent.AgtBusPhone = txtAgntBusPhone.Text;
            newAgent.AgtEmail = txtAgntEmail.Text;
            newAgent.AgencyId = Convert.ToInt32(cboAgency.SelectedValue);
            newAgent.AgtMiddleInitial = txtMiddleInit.Text;
            newAgent.AgtPosition = txtAgntPosition.Text;
            AgentRepository.CreateAgent(newAgent);
            PopulateAgents();

        }

        if (function == "EDIT")
        {

        }
    }
}
