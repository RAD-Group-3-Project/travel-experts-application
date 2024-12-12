using Azure.Storage.Blobs;
using System.Configuration;
using System.Data;
using TravelExpertData.Models;
using TravelExpertData.Repositories;
using TravelExpertGUI.Helpers;

namespace TravelExpertGUI;
public partial class ucManagePackages : UserControl
{
    private List<Package> packages = null;
    private bool suppressSelectionChanged;
    private string function;

    // Image upload
    private string imageName;
    private string imageFullPath;
    private const string CHRIS_LOCAL_PATH =
        @"C:\Users\acide\Desktop\RAD - Threaded Project Pt 2\Threaded Project - C#\travel-experts-jsp-server-web-app\TravelExpertMVC\wwwroot\images";

    private string blobConnectionString;
    private string containerName;

    public ucManagePackages()
    {
        InitializeComponent();

        blobConnectionString = ConfigurationManager.ConnectionStrings["AzureStorageConnection"].ConnectionString;
        if (string.IsNullOrEmpty(blobConnectionString))
        {
            MessageBox.Show("Azure Blob Storage connection string is missing. Please add it to the App.config file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        containerName = "travel-expert-main";
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
            txtPkgStartDate.Text = startDate.ToString("yyyy-MM-dd");
            DateTime endDate = Convert.ToDateTime(dgvPackages.CurrentRow.Cells["PkgEndDate"].Value);
            txtPkgEndDate.Text = endDate.ToString("yyyy-MM-dd");
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
        txtPkgStartDate.ReadOnly = false;
        txtPkgEndDate.ReadOnly = false;
        txtPkgName.Focus();
        btnAdd.Enabled = false;
        btnEdit.Enabled = false;
        btnDelete.Enabled = false;
        btnSave.Enabled = true;
        btnDiscard.Enabled = true;

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
        txtPkgStartDate.ReadOnly = false;
        txtPkgEndDate.ReadOnly = false;
        txtPkgDesc.ReadOnly = false;
        txtPkgBasePrice.ReadOnly = false;
        txtPkgAgcyCom.ReadOnly = false;
        btnAdd.Enabled = false;
        btnEdit.Enabled = false;
        btnDelete.Enabled = false;
        btnSave.Enabled = true;
        btnDiscard.Enabled = true;
        function = "EDIT";

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
        try
        {
            string basePr = txtPkgBasePrice.Text;
            string basePriceFormat = basePr.Replace("$", "");
            txtPkgBasePrice.Text = basePriceFormat;
            string baseComm = txtPkgAgcyCom.Text;
            string baseCommFormat = baseComm.Replace("$", "");
            txtPkgAgcyCom.Text = baseCommFormat;

            if (!ValidateRequiredFieldsAndBizLogic())
            {
                return;
            }

            // set the package properties
            var package = new Package
            {
                PkgName = txtPkgName.Text,
                PkgStartDate = Convert.ToDateTime(txtPkgStartDate.Text),
                PkgEndDate = Convert.ToDateTime(txtPkgEndDate.Text),
                PkgDesc = txtPkgDesc.Text,
                PkgBasePrice = Convert.ToDecimal(txtPkgBasePrice.Text),
                PkgAgencyCommission = Convert.ToDecimal(txtPkgAgcyCom.Text),
                IsActive = true
            };

            string resultUrl;
            switch (function)
            {
                case "ADD":

                    if (!string.IsNullOrEmpty(imageName) && File.Exists(imageFullPath))
                    {
                        package.PkgImage = imageName;
                    }
                    else
                    {
                        package.PkgImage = "defaultPackage.jpg";
                    }

                    // Upload the image to Azure Blob Storage
                    resultUrl = UploadImageToBlob(package.PackageId.ToString(), package.PkgName, imageName, imageFullPath);
                    if (!string.IsNullOrEmpty(resultUrl))
                    {
                        package.PkgImage = resultUrl;
                    }

                    // Add the package to the database
                    PackageRepository.AddPackage(package);

                    break;

                case "EDIT":

                    if (!string.IsNullOrEmpty(imageName) && File.Exists(imageFullPath))
                    {
                        package.PkgImage = imageName;
                    }
                    else
                    {
                        package.PkgImage = lblImage.Text;
                    }

                    package.PackageId = Convert.ToInt32(txtPkgId.Text);

                    resultUrl = UploadImageToBlob(package.PackageId.ToString(), package.PkgName, imageName, imageFullPath);
                    if (!string.IsNullOrEmpty(resultUrl))
                    {
                        package.PkgImage = resultUrl;
                    }

                    // Update the package in the database
                    PackageRepository.UpdatePackage(package);

                    break;
            }

            // Refresh list
            populatePackages();

            // reset
            btnUploadImage.Enabled = false;
            btnUploadImage.Visible = false;
            imgPicture.Visible = false;
            imageName = "";

        }
        catch (Exception exception)
        {
            MessageBox.Show(
                $"Error: {exception.Message}",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );

            // Refresh list
            populatePackages();

            // reset
            btnUploadImage.Enabled = false;
            btnUploadImage.Visible = false;
            imgPicture.Visible = false;
            imageName = "";
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
        txtPkgStartDate.ReadOnly = true;
        txtPkgEndDate.ReadOnly = true;
        btnAdd.Enabled = true;
        btnDiscard.Enabled = false;
        btnSave.Enabled = false;
        btnEdit.Enabled = true;
        btnDelete.Enabled = true;
        imageName = "";

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
        txtPkgStartDate.ReadOnly = false;
        txtPkgEndDate.ReadOnly = false;
        txtPkgDesc.ReadOnly = false;
        txtPkgBasePrice.ReadOnly = false;
        txtPkgAgcyCom.ReadOnly = false;
    }

    private void ClearAllInputFields()
    {
        txtPkgId.Clear();
        txtPkgName.Clear();
        txtPkgStartDate.Clear();
        txtPkgEndDate.Clear();
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
               TextBoxValidator.IsPresent(txtPkgStartDate) &&
               TextBoxValidator.IsPresent(txtPkgEndDate) &&
               TextBoxValidator.IsPresent(txtPkgAgcyCom) &&
               TextBoxValidator.ValidatePackageEndDate(txtPkgStartDate, txtPkgEndDate) &&
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

            if (string.IsNullOrEmpty(extension) || !permittedExtensions.Contains(extension))
            {
                MessageBox.Show(
                    "Please upload an image file",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            imageName = Path.GetFileName(openFileDialog1.FileName);
            imageFullPath = openFileDialog1.FileName;
            imgPicture.Image = Image.FromFile(imageFullPath);
            imgPicture.Visible = true;
        }
    }

    /// <summary>
    /// Uploads an image file to Azure Blob Storage and returns the URL of the uploaded image.
    /// </summary>
    /// <param name="filename">The name of the file to be uploaded.</param>
    /// <param name="destinationPath">The destination path of the file to be uploaded.</param>
    /// <returns>The URL of the uploaded image.</returns>
    private string UploadImageToBlob(string packageId, string packageName, string filename, string destinationPath)
    {
        var blobServiceClient = new BlobServiceClient(blobConnectionString);
        var blobContainerClient = blobServiceClient.GetBlobContainerClient(containerName);
        var blobClient = blobContainerClient.GetBlobClient(GenerateBlobName(packageId, packageName, Path.GetExtension(destinationPath)));
        using (var fileStream = File.OpenRead(destinationPath))
        {
            var res = blobClient.Upload(fileStream, true);

            if (res.GetRawResponse().Status != 201)
            {
                MessageBox.Show(
                    "Got some error during the uploading the image. Save to local machine instead",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                // Copy the image to Chris's local path
                var chrisImagePath = Path.Combine(CHRIS_LOCAL_PATH, filename);
                File.Copy(openFileDialog1.FileName, chrisImagePath, true);

                return string.Empty;
            }

            MessageBox.Show(
                "Image uploaded successfully to Azure Blob Storage.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            return blobClient.Uri.ToString();
        }
    }

    private string GenerateSlug(string packageName)
    {
        return string.Join("-", packageName
            .ToLower()
            .Split(new[] { ' ', '_', ',' }, StringSplitOptions.RemoveEmptyEntries));
    }

    private string GenerateBlobName(string packageId, string packageName, string fileExtension)
    {
        string timestamp = DateTime.UtcNow.ToString("yyyyMMdd-HHmmss");
        string slug = GenerateSlug(packageName);
        return $"{packageId}/{timestamp}-{slug}{fileExtension}";
    }

}
