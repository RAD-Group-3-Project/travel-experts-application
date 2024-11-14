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

namespace TravelExpertGUI;
public partial class frmMain : Form
{
    public frmMain()
    {
        InitializeComponent();
    }
    public CurrentUser currentuser = new();

    private void frmMain_Load(object sender, EventArgs e)
    {
        List<ToolStripMenuItem> agentMenuItems = new List<ToolStripMenuItem>();
        List<ToolStripMenuItem> adminMenuItems = new List<ToolStripMenuItem>();

        InitTableList(agentMenuItems, adminMenuItems);

        string user = validateUser();
        switch (user.ToUpper())
        {
            case "ADMIN":
                mnuDatabase.DropDownItems.AddRange(adminMenuItems.ToArray());
                break;
            case "AGENT":
                mnuDatabase.DropDownItems.AddRange(agentMenuItems.ToArray());
                break;
        }

        // add welcome message
        contentPanel.Controls.Clear();
        contentPanel.Controls.Add(new ucWelcomeMessage() { currentuser = currentuser});
    }
    /// <summary>
    /// Checks if our user is an admin or not
    /// </summary>
    /// <returns>ADMIN or AGENT</returns>
    private string validateUser()
    {
        string result = "AGENT";
        if (currentuser.IS_Admin)
        {
            result = "ADMIN";
            return result;
        }
        else 
        {
            return result;    
        }
    }

    private void InitTableList(List<ToolStripMenuItem> agentMenuItems, List<ToolStripMenuItem> adminMenuItems)
    {
        string[] agentTables = new[] { "Packages", "Products", "Products Suppliers", "Suppliers", "Packages Products Suppliers" };
        string[] adminTables = new[] { "Packages", "Products", "Products Suppliers", "Suppliers", "Packages Products Suppliers", "Agents", "Agencies", };

        foreach (string agentTable in agentTables)
        {
            ToolStripMenuItem menuItem = new ToolStripMenuItem(agentTable);
            menuItem.Click += MenuItem_Click;
            agentMenuItems.Add(menuItem);
        }

        foreach (string adminTable in adminTables)
        {
            ToolStripMenuItem menuItem = new ToolStripMenuItem(adminTable);
            menuItem.Click += MenuItem_Click;
            adminMenuItems.Add(menuItem);
        }
    }

    private void MenuItem_Click(object sender, EventArgs e)
    {
        if (sender is ToolStripMenuItem menuItem)
        {
            // Get table name from menu item text
            string tableName = menuItem.Text;

            // Clear existing controls in the panel
            contentPanel.Controls.Clear();

            UserControl controlToLoad = null;

            switch (tableName)
            {
                case "Packages":
                    controlToLoad = new ucManagePackages(); 
                    break;
                case "Products":
                    //controlToLoad = new ucManageProducts(); 
                    break;
                case "Products Suppliers":
                    controlToLoad = new ucManageProductSuppliers();
                    break;
                case "Suppliers":
                    controlToLoad = new ucManageSuppliers();
                    break;
                case "Packages Products Suppliers":
                    // TODO: Implement the ucManagePackagesProductsSuppliers control
                    // controlToLoad = new ucManagePackagesProductsSuppliers();
                    break;
                case "Agents":
                    controlToLoad = new ucManageAgents();
                    break;
                case "Agencies":
                    // TODO: Implement the ucManageAgencies control
                     controlToLoad = new ucManageAgencies();
                    break;
                default:
                    Debug.WriteLine($"Couldn't find any table in Switch case: table name {tableName}");
                    break;
            }

            if (controlToLoad != null)
            {
                controlToLoad.Dock = DockStyle.Fill; // Fill the panel
                contentPanel.Controls.Add(controlToLoad); 
            }
        }
    }

    private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
    {
        Application.Exit(); // Ensure the entire application closes
    }

}
