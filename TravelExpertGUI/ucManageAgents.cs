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
        btnDisc.Enabled = false;
        btnSave.Enabled = false;
        dgvAgents.Enabled = true;
        dgvAgents.Columns.Clear();
        dgvAgents.DataSource = AgentRepository.GetAgents();
        // format the column header
        dgvAgents.EnableHeadersVisualStyles = false;
        dgvAgents.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
        dgvAgents.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dgvAgents.ColumnHeadersDefaultCellStyle.BackColor = Color.SlateBlue;
        dgvAgents.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        dgvAgents.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        // Hides the row selection columns
        dgvAgents.RowHeadersVisible = false;
        // Hides additional columns we dont need to see 
        dgvAgents.Columns[7].Visible = false;
        dgvAgents.Columns[8].Visible = false;
        dgvAgents.Columns[9].Visible = false;
        dgvAgents.Columns[10].Visible = false;
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
        btnSave.Enabled = true;
        btnDisc.Enabled = true;
        dgvAgents.Enabled = false;
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
        btnDisc.Enabled = true;
        function = "ADD";



    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        btnSave.Enabled = true;
        btnDisc.Enabled = true;
        dgvAgents.Enabled = false;
        txtAgntFName.ReadOnly = false;
        txtAgntLName.ReadOnly = false;
        txtAgntBusPhone.ReadOnly = false;
        txtAgntEmail.ReadOnly = false;
        txtAgntPosition.ReadOnly = false;
        txtMiddleInit.ReadOnly = false;
        cboAgency.Enabled = true;
        btnSave.Enabled = true;
        btnDisc.Enabled = true;
        function = "EDIT";
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        DataGridViewRow selectedRow = dgvAgents.CurrentRow;
        int selectedAgent = Convert.ToInt32(selectedRow.Cells[0].Value);
        DialogResult result =
            MessageBox.Show($"Are you sure you would like to delete Agent {selectedRow.Cells[1].Value} {selectedRow.Cells[3].Value}",
            "Confirm Agent Deletion",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
            AgentRepository.DeleteAgentById(selectedAgent);
            PopulateAgents();
        }

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
            Agent updatedAgent = new Agent();
            updatedAgent.AgentId = Convert.ToInt32(txtAgntId.Text);
            updatedAgent.AgtFirstName = txtAgntFName.Text;
            updatedAgent.AgtLastName = txtAgntLName.Text;
            updatedAgent.AgtBusPhone = txtAgntBusPhone.Text;
            updatedAgent.AgtEmail = txtAgntEmail.Text;
            updatedAgent.AgencyId = Convert.ToInt32(cboAgency.SelectedValue);
            updatedAgent.AgtMiddleInitial = txtMiddleInit.Text;
            updatedAgent.AgtPosition = txtAgntPosition.Text;
            updatedAgent.IsActive = true;
            AgentRepository.UpdateAgent(updatedAgent);
            PopulateAgents();

        }
    }

    private void btnDisc_Click(object sender, EventArgs e)
    {
        PopulateAgents();
    }
}
