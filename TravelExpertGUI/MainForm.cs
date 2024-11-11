using TravelExpertData;
using TravelExpertData.Data;
using TravelExpertData.Models;

namespace TravelExpertGUI;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void managePackagesToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ManagePackagesForm packagesForm = new ManagePackagesForm();
        packagesForm.Show();
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        this.Close();
    }


    private void MainForm_Load(object sender, EventArgs e)
    {

    }

    private void manageProductsToolStripMenuItem_Click_1(object sender, EventArgs e)
    {
        ManageProductsForm productsForm = new ManageProductsForm();
        productsForm.Show();
    }

    private void loginToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void agenciesToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void manageSuppliersToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ManageSuppliersForm suppliersForm = new ManageSuppliersForm();
        suppliersForm.Show();
    }
}
