﻿using System;
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
using TravelExpertGUI.Helpers;

namespace TravelExpertGUI;
public partial class ucManagePackages : UserControl
{
    string imageName = "";
    private List<Package> packages = null;
    private bool suppressSelectionChanged;
    string function;
    string destinationpath;

    public ucManagePackages()
    {
        InitializeComponent();
    }

    private void ucManagePackages_Load(object sender, EventArgs e)
    {
        populatePackages();
    }


    private void dgvPackages_SelectionChanged(object sender, EventArgs e)
    {
        if (suppressSelectionChanged)
        {
            return;
        }

        if (dgvPackages.SelectedRows != null)
        {
            txtPkgId.Text = dgvPackages.CurrentRow.Cells["PackageId"].Value.ToString();
            txtPkgName.Text = dgvPackages.CurrentRow.Cells["PkgName"].Value.ToString();
            DateTime startDate = Convert.ToDateTime(dgvPackages.CurrentRow.Cells["PkgStartDate"].Value);
            dtpStartDate.Text = startDate.ToString("yyyy-MM-dd");
            DateTime endDate = Convert.ToDateTime(dgvPackages.CurrentRow.Cells["PkgEndDate"].Value);
            dtpEndDate.Text = endDate.ToString("yyyy-MM-dd");
            txtPkgDesc.Text = dgvPackages.CurrentRow.Cells["PkgDesc"].Value.ToString();
            decimal basePrice = Convert.ToDecimal(dgvPackages.CurrentRow.Cells["PkgBasePrice"].Value);
            txtPkgBasePrice.Text = basePrice.ToString("c");
            decimal commission = Convert.ToDecimal(dgvPackages.CurrentRow.Cells["PkgAgencyCommission"].Value);
            txtPkgAgcyCom.Text = commission.ToString("c");
            lblImage.Text = dgvPackages.CurrentRow.Cells["PkgImage"].Value.ToString();

        }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        txtPkgId.ReadOnly = true;

        EnableEditableFields();
        txtPkgId.ReadOnly = true;
        txtPkgName.ReadOnly = false;
        txtPkgAgcyCom.ReadOnly = false;
        txtPkgBasePrice.ReadOnly = false;
        txtPkgDesc.ReadOnly = false;
        //txtPkgStartDate.ReadOnly = false;
        
        txtPkgName.Focus();
        btnAdd.Enabled = false;
        btnEdit.Enabled = false;
        btnDelete.Enabled = false;
        btnSave.Enabled = true;
        btnDiscard.Enabled = true;
        // End date formatting
        dtpEndDate.Format = DateTimePickerFormat.Custom;
        dtpEndDate.CustomFormat = "MM/dd/yyyy";
        dtpEndDate.Enabled = true;
        // Start date formatting
        dtpStartDate.Format = DateTimePickerFormat.Custom;
        dtpStartDate.CustomFormat = "MM/dd/yyyy";
        dtpStartDate.Enabled = true;

        // Finds last package ID and populate the box
        int lastRowColumnValue = lastID_PlusOne();
        txtPkgId.Text = lastRowColumnValue.ToString();

        // Changes the save name to "ADD"
        function = "ADD";

        // Locks the database grid view
        dgvPackages.Enabled = false;
        btnUploadImage.Enabled = true;
        btnUploadImage.Visible = true;
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        txtPkgId.ReadOnly = true;
        txtPkgName.ReadOnly = false;
        txtPkgName.Focus();
        //txtPkgStartDate.ReadOnly = false;
        //dtpEndDate.ReadOnly = false;
        txtPkgDesc.ReadOnly = false;
        txtPkgBasePrice.ReadOnly = false;
        txtPkgAgcyCom.ReadOnly = false;
        btnAdd.Enabled = false;
        btnEdit.Enabled = false;
        btnDelete.Enabled = false;
        btnSave.Enabled = true;
        btnDiscard.Enabled = true;
        function = "EDIT";
        dtpEndDate.Format = DateTimePickerFormat.Custom;
        dtpEndDate.CustomFormat = "MM/dd/yyyy";
        dtpEndDate.Enabled = true;

        dtpStartDate.Format = DateTimePickerFormat.Custom;
        dtpStartDate.CustomFormat = "MM/dd/yyyy";
        dtpStartDate.Enabled = true;

        dgvPackages.Enabled = false;
        btnUploadImage.Enabled = true;
        btnUploadImage.Visible = true;
        // Locks the database grid view
        dgvPackages.Enabled = false;
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        // Finds the selected row and supplier
        DataGridViewRow selectedRow = dgvPackages.CurrentRow;
        int selectedPackages = Convert.ToInt32(selectedRow.Cells[0].Value);

        // Pops out message box to ensure deletion
        DialogResult result = MessageBox.Show($"Are you sure you want to delete Package {selectedRow.Cells[1].Value} ", "Delete Package",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        // If user clicks yes
        if (result == DialogResult.Yes)
        {
            // Try-catch delete
            try
            {
                PackageRepository.DeletePackageByID(selectedPackages);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Package Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Refresh list
            populatePackages();
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        string basePr = txtPkgBasePrice.Text;
        string basePriceFormat = basePr.Replace("$", "");
        txtPkgBasePrice.Text = basePriceFormat;
        string baseComm = txtPkgAgcyCom.Text;
        string baseCommFormat = baseComm.Replace("$", "");
        txtPkgAgcyCom.Text = baseCommFormat;

        switch (function)
        {

            case "ADD":
                
                if (ValidateRequiredFieldsAndBizLogic())
                {
                    Package addedPackage = new Package();


                    addedPackage.PkgName = txtPkgName.Text;
                    DateTime pkgStartDate = Convert.ToDateTime(dtpStartDate.Text);
                    addedPackage.PkgStartDate = pkgStartDate;
                    DateTime pkgEndDate = Convert.ToDateTime(dtpEndDate.Text);
                    addedPackage.PkgEndDate = pkgEndDate;
                    addedPackage.PkgDesc = txtPkgDesc.Text;
                    addedPackage.PkgBasePrice = Convert.ToDecimal(txtPkgBasePrice.Text);
                    addedPackage.PkgAgencyCommission = Convert.ToDecimal(txtPkgAgcyCom.Text);
                    addedPackage.IsActive = true;
                    if (!string.IsNullOrEmpty(openFileDialog1.FileName) && File.Exists(openFileDialog1.FileName))
                    {
                        addedPackage.PkgImage = imageName;
                    }
                    else
                    {
                        addedPackage.PkgImage = "defaultPackage.jpg";
                    }

                    try
                    {

                        if (!string.IsNullOrEmpty(openFileDialog1.FileName) && File.Exists(openFileDialog1.FileName))
                        {
                            // Ensure the destination path is set correctly before copying
                            File.Copy(openFileDialog1.FileName, destinationpath, true); // Overwrite if exists
                        }


                        PackageRepository.AddPackage(addedPackage);
                        btnUploadImage.Enabled = false;
                        btnUploadImage.Visible = false;
                        imgPicture.Visible = false;
                        imageName = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Package Add Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // Refresh list
                    populatePackages();
                    break;
                }
                else
                {
                    MessageBox.Show("Please input a Package Name");
                    break;
                }

            case "EDIT":
                if (ValidateRequiredFieldsAndBizLogic())
                {
                    Package editedPackage = new Package();
                    editedPackage.PackageId = Convert.ToInt32(txtPkgId.Text);
                    editedPackage.PkgName = txtPkgName.Text;
                    DateTime pkgStartDate = Convert.ToDateTime(dtpStartDate.Text);
                    editedPackage.PkgStartDate = pkgStartDate;
                    DateTime pkgEndDate = Convert.ToDateTime(dtpEndDate.Text);
                    editedPackage.PkgEndDate = pkgEndDate;
                    editedPackage.PkgDesc = txtPkgDesc.Text;
                    editedPackage.PkgBasePrice = Convert.ToDecimal(txtPkgBasePrice.Text);
                    if (imageName != "")
                    {
                        editedPackage.PkgImage = imageName;
                    }
                    else
                    {
                        editedPackage.PkgImage = lblImage.Text;
                    }
                    editedPackage.IsActive = true;
                    editedPackage.PkgAgencyCommission = Convert.ToDecimal(txtPkgAgcyCom.Text);

                    try
                    {
                        
                        PackageRepository.UpdatePackage(editedPackage);
                        if (imageName != "")
                        {
                            File.Copy(openFileDialog1.FileName, destinationpath, true);
                        }
                        btnUploadImage.Enabled = false;
                        btnUploadImage.Visible = false;
                        imgPicture.Visible = false;
                        imageName = "";

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Package Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // Refresh list
                    populatePackages();

                    break;
                }
                else
                {
                    MessageBox.Show("Please input a Package Name");
                    break;
                }
        }
    }

    private void btnDiscard_Click(object sender, EventArgs e)
    {
        btnUploadImage.Enabled = false;
        btnUploadImage.Visible = false;
        imgPicture.Visible = false;
        populatePackages();
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
        lblSearchIcon.Visible = true;

        EnableEditableFields();

        txtPkgId.ReadOnly = false;

        btnSave.Enabled = false;
        btnAdd.Enabled = false;
        btnDelete.Enabled = false;
        btnEdit.Enabled = false;
        btnDiscard.Enabled = true;
    }


    private void lblSearchIcon_MouseHover(object sender, MouseEventArgs e)
    {
        lblSearchIcon.Cursor = Cursors.Hand;
    }

    private void lblSearchIcon_MouseLeave(object sender, EventArgs e)
    {
        lblSearchIcon.Cursor = Cursors.Default;
    }

    private void lblClearIcon_Click(object sender, EventArgs e)
    {
        ClearAllInputFields();
    }

    private void lblClearIcon_MouseHover(Object sender, MouseEventArgs e)
    {
        lblClearIcon.Cursor = Cursors.Hand;
    }

    private void lblClearIcon_MouseLeave(Object sender, EventArgs e)
    {
        lblClearIcon.Cursor = Cursors.Default;
    }

    private void populatePackages()
    {
        lblSearchIcon.Visible = false;
        txtPkgId.ReadOnly = true;
        txtPkgName.ReadOnly = true;
        txtPkgAgcyCom.ReadOnly = true;
        txtPkgBasePrice.ReadOnly = true;
        txtPkgDesc.ReadOnly = true;
        //txtPkgStartDate.ReadOnly = true;
        //txtPkgEndDate.ReadOnly = true;
        btnAdd.Enabled = true;
        btnDiscard.Enabled = false;
        btnSave.Enabled = false;
        btnEdit.Enabled = true;
        btnDelete.Enabled = true;
        imageName = "";
        dtpEndDate.Format = DateTimePickerFormat.Custom;
        dtpEndDate.CustomFormat = "MM/dd/yyyy";
        dtpEndDate.Enabled = false;
        // Start date formatting
        dtpStartDate.Format = DateTimePickerFormat.Custom;
        dtpStartDate.CustomFormat = "MM/dd/yyyy";
        dtpStartDate.Enabled = false;

        // Clear list
        dgvPackages.Columns.Clear();
        dgvPackages.ReadOnly = true;
        packages = PackageRepository.GetPackages();
        dgvPackages.DataSource = packages;

        // Formatting the column header
        dgvPackages.EnableHeadersVisualStyles = false;
        dgvPackages.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
        dgvPackages.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dgvPackages.ColumnHeadersDefaultCellStyle.BackColor = Color.SlateBlue;
        dgvPackages.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        dgvPackages.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        // Manually change the column width, alignment, and header text
        dgvPackages.Columns[0].HeaderText = "ID";
        dgvPackages.Columns[1].HeaderText = "Package Name";

        // Hides header column
        dgvPackages.RowHeadersVisible = false;

        // Hides additional columns
        dgvPackages.Columns[7].Visible = false;
        dgvPackages.Columns[9].Visible = false;
        dgvPackages.Columns[10].Visible = false;
        dgvPackages.Columns[11].Visible = false;
        // Format certain columns to be currency 
        dgvPackages.Columns[5].DefaultCellStyle.Format = "c";
        dgvPackages.Columns[6].DefaultCellStyle.Format = "c";



        // Unlocks the dgv so it can be click
        dgvPackages.Enabled = true;
    }

    private void EnableEditableFields()
    {
        ClearAllInputFields();
        txtPkgId.ReadOnly = true;
        txtPkgName.ReadOnly = false;
        txtPkgName.Focus();
        //txtPkgStartDate.ReadOnly = false;
        //txtPkgEndDate.ReadOnly = false;
        txtPkgDesc.ReadOnly = false;
        txtPkgBasePrice.ReadOnly = false;
        txtPkgAgcyCom.ReadOnly = false;
        dtpEndDate.Format = DateTimePickerFormat.Custom;
        dtpEndDate.CustomFormat = "MM/dd/yyyy";
        dtpEndDate.Enabled = true;

        dtpEndDate.Format = DateTimePickerFormat.Custom;
        dtpEndDate.CustomFormat = "MM/dd/yyyy";
        dtpEndDate.Enabled = true;

    }

    private void ClearAllInputFields()
    {
        txtPkgId.Clear();
        txtPkgName.Clear();
        //txtPkgStartDate.Clear();
        dtpStartDate.Value = DateTime.Today;
        dtpEndDate.Value = DateTime.Today;
        txtPkgDesc.Clear();
        txtPkgBasePrice.Clear();
        txtPkgAgcyCom.Clear();
        lblImage.Text = string.Empty;
    }

    private static int lastID_PlusOne()
    {
        // Get list of all packages including non-active
        List<Package> packageData = PackageRepository.GetAllPackages();

        // Get the last ID, adds one and returns it
        int lastRowColumnValue = packageData.Last().PackageId;
        lastRowColumnValue++;
        return lastRowColumnValue;
    }

    private bool ValidateRequiredFieldsAndBizLogic()
    {
        return TextBoxValidator.IsPresent(txtPkgId) &&
               TextBoxValidator.IsPresent(txtPkgName) &&
               TextBoxValidator.IsPresent(txtPkgDesc) &&
               TextBoxValidator.IsPresent(txtPkgBasePrice) &&
               //TextBoxValidator.IsPresent(txtPkgStartDate) &&
               //TextBoxValidator.IsPresent(dtpEndDate) &&
               TextBoxValidator.IsPresent(txtPkgAgcyCom) &&
               TextBoxValidator.ValidatePackageEndDate(dtpStartDate, dtpEndDate) &&
               TextBoxValidator.ValidateAgencyCommission(txtPkgAgcyCom, txtPkgBasePrice);
    }

    private void lblSearchIcon_Click_1(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(txtPkgId.Text) && !TextBoxValidator.IsInteger(txtPkgId))
        {
            return;
        }

        var filteredList = packages.Where(package => (string.IsNullOrWhiteSpace(txtPkgId.Text) || package.PackageId == Convert.ToInt32(txtPkgId.Text) &&
        (string.IsNullOrWhiteSpace(txtPkgName.Text) || package.PkgName.ToLower().Contains(txtPkgName.Text.ToLower())))).ToList();

        if (filteredList.Count == 0)
        {
            suppressSelectionChanged = true;
        }

        dgvPackages.DataSource = filteredList;
    }

    private void btnUploadImage_Click(object sender, EventArgs e)
    {
        
        DialogResult result = openFileDialog1.ShowDialog();
        if (result == DialogResult.OK) // Check if the user selected a file
        {   

            var extension = Path.GetExtension(openFileDialog1.FileName);
            var permittedExtensions = new[] { ".jpg", ".png", ".gif", ".jpeg" };
            string localpath = @"C:\Users\acide\Desktop\RAD - Threaded Project Pt 2\Threaded Project - C#\travel-experts-jsp-server-web-app\TravelExpertMVC\wwwroot\images";

            if (string.IsNullOrEmpty(extension) || !permittedExtensions.Contains(extension))
            {
                MessageBox.Show("Please upload an image file");
            }
            else
            {
                
                // Get the file name and create a full path for the destination
                string filename = Path.GetFileName(openFileDialog1.FileName);
                destinationpath = Path.Combine(localpath, filename); // Combine localpath with the filename

                // Copy the file from the openFileDialog location to the destination path
                //File.Copy(openFileDialog1.FileName, destinationPath, true);
                imageName = Path.GetFileName(openFileDialog1.FileName);
                imgPicture.Image = Image.FromFile(openFileDialog1.FileName);
                imgPicture.Visible = true;
            }
        }
    }
}
