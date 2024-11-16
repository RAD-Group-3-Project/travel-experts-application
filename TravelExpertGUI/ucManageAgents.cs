using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        btnAdd.Enabled = true;
        btnEdit.Enabled = true;
        btnDelete.Enabled = true;
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
        // Manually change our column width, alignment, and header text
        dgvAgents.Columns[0].HeaderText = "ID";
        dgvAgents.Columns[1].HeaderText = "First Name";
        dgvAgents.Columns[2].HeaderText = "Initial";
        dgvAgents.Columns[3].HeaderText = "Last Name";
        dgvAgents.Columns[4].HeaderText = "Phone";
        dgvAgents.Columns[5].HeaderText = "Email";
        dgvAgents.Columns[6].HeaderText = "Position";
        //dgvAgents.Columns[1].Width = 250;
        //dgvAgents.Columns[2].Width = 50;
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
            Debug.WriteLine($"({dgvAgents.CurrentCell.ColumnIndex}, {dgvAgents.CurrentRow.Index})");
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
        btnAdd.Enabled = false;
        btnDelete.Enabled = false;
        btnEdit.Enabled = false;
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
        btnAdd.Enabled = false;
        btnDelete.Enabled = false;
        btnEdit.Enabled = false;
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
            try
            {
                AgentRepository.DeleteAgentById(selectedAgent);
                PopulateAgents();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message}", "Agent Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        if (function == "ADD")
        {
            try
            {
                Agent newAgent = new Agent();
                newAgent.AgtFirstName = txtAgntFName.Text;
                newAgent.AgtLastName = txtAgntLName.Text;
                newAgent.AgtBusPhone = txtAgntBusPhone.Text;
                newAgent.AgtEmail = txtAgntEmail.Text;
                newAgent.AgencyId = Convert.ToInt32(cboAgency.SelectedValue);
                newAgent.AgtMiddleInitial = txtMiddleInit.Text;
                newAgent.AgtPosition = txtAgntPosition.Text;
                newAgent.IsActive = true;
                AgentRepository.CreateAgent(newAgent);
                PopulateAgents();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message}", "Agent Add Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        if (function == "EDIT")
        {
            try
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
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message}", "Agent Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }

    private void btnDisc_Click(object sender, EventArgs e)
    {
        PopulateAgents();
    }
}
