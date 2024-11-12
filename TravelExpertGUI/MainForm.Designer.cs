namespace TravelExpertGUI;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        menuStrip1 = new MenuStrip();
        homeToolStripMenuItem = new ToolStripMenuItem();
        loginToolStripMenuItem = new ToolStripMenuItem();
        agenciesToolStripMenuItem1 = new ToolStripMenuItem();
        managePackagesToolStripMenuItem = new ToolStripMenuItem();
        editToolStripMenuItem = new ToolStripMenuItem();
        editToolStripMenuItem1 = new ToolStripMenuItem();
        deleteToolStripMenuItem = new ToolStripMenuItem();
        manageProductsToolStripMenuItem = new ToolStripMenuItem();
        viewToolStripMenuItem = new ToolStripMenuItem();
        edietToolStripMenuItem = new ToolStripMenuItem();
        deleteToolStripMenuItem1 = new ToolStripMenuItem();
        manageSuppliersToolStripMenuItem = new ToolStripMenuItem();
        viewToolStripMenuItem1 = new ToolStripMenuItem();
        editToolStripMenuItem2 = new ToolStripMenuItem();
        deleteToolStripMenuItem2 = new ToolStripMenuItem();
        searchToolStripMenuItem = new ToolStripMenuItem();
        panel1 = new Panel();
        txtTest = new TextBox();
        menuStrip1.SuspendLayout();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // menuStrip1
        // 
        menuStrip1.BackColor = Color.LightGray;
        menuStrip1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        menuStrip1.ImageScalingSize = new Size(20, 20);
        menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, managePackagesToolStripMenuItem, manageProductsToolStripMenuItem, manageSuppliersToolStripMenuItem, searchToolStripMenuItem });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Padding = new Padding(7, 3, 0, 3);
        menuStrip1.Size = new Size(786, 30);
        menuStrip1.TabIndex = 0;
        menuStrip1.Text = "menuStrip1";
        // 
        // homeToolStripMenuItem
        // 
        homeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loginToolStripMenuItem, agenciesToolStripMenuItem1 });
        homeToolStripMenuItem.Name = "homeToolStripMenuItem";
        homeToolStripMenuItem.Size = new Size(62, 24);
        homeToolStripMenuItem.Text = "Login";
        // 
        // loginToolStripMenuItem
        // 
        loginToolStripMenuItem.Name = "loginToolStripMenuItem";
        loginToolStripMenuItem.Size = new Size(155, 26);
        loginToolStripMenuItem.Text = "Agents";
        loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
        // 
        // agenciesToolStripMenuItem1
        // 
        agenciesToolStripMenuItem1.Name = "agenciesToolStripMenuItem1";
        agenciesToolStripMenuItem1.Size = new Size(155, 26);
        agenciesToolStripMenuItem1.Text = "Agencies";
        // 
        // managePackagesToolStripMenuItem
        // 
        managePackagesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { editToolStripMenuItem, editToolStripMenuItem1, deleteToolStripMenuItem });
        managePackagesToolStripMenuItem.Name = "managePackagesToolStripMenuItem";
        managePackagesToolStripMenuItem.Size = new Size(147, 24);
        managePackagesToolStripMenuItem.Text = "Manage Packages";
        managePackagesToolStripMenuItem.Click += managePackagesToolStripMenuItem_Click;
        // 
        // editToolStripMenuItem
        // 
        editToolStripMenuItem.Name = "editToolStripMenuItem";
        editToolStripMenuItem.Size = new Size(137, 26);
        editToolStripMenuItem.Text = "View";
        // 
        // editToolStripMenuItem1
        // 
        editToolStripMenuItem1.Name = "editToolStripMenuItem1";
        editToolStripMenuItem1.Size = new Size(137, 26);
        editToolStripMenuItem1.Text = "Edit";
        // 
        // deleteToolStripMenuItem
        // 
        deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
        deleteToolStripMenuItem.Size = new Size(137, 26);
        deleteToolStripMenuItem.Text = "Delete";
        // 
        // manageProductsToolStripMenuItem
        // 
        manageProductsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewToolStripMenuItem, edietToolStripMenuItem, deleteToolStripMenuItem1 });
        manageProductsToolStripMenuItem.Name = "manageProductsToolStripMenuItem";
        manageProductsToolStripMenuItem.Size = new Size(145, 24);
        manageProductsToolStripMenuItem.Text = "Manage Products";
        manageProductsToolStripMenuItem.Click += manageProductsToolStripMenuItem_Click_1;
        // 
        // viewToolStripMenuItem
        // 
        viewToolStripMenuItem.Name = "viewToolStripMenuItem";
        viewToolStripMenuItem.Size = new Size(137, 26);
        viewToolStripMenuItem.Text = "View";
        // 
        // edietToolStripMenuItem
        // 
        edietToolStripMenuItem.Name = "edietToolStripMenuItem";
        edietToolStripMenuItem.Size = new Size(137, 26);
        edietToolStripMenuItem.Text = "Edit";
        // 
        // deleteToolStripMenuItem1
        // 
        deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
        deleteToolStripMenuItem1.Size = new Size(137, 26);
        deleteToolStripMenuItem1.Text = "Delete";
        // 
        // manageSuppliersToolStripMenuItem
        // 
        manageSuppliersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewToolStripMenuItem1, editToolStripMenuItem2, deleteToolStripMenuItem2 });
        manageSuppliersToolStripMenuItem.Name = "manageSuppliersToolStripMenuItem";
        manageSuppliersToolStripMenuItem.Size = new Size(147, 24);
        manageSuppliersToolStripMenuItem.Text = "Manage Suppliers";
        manageSuppliersToolStripMenuItem.Click += manageSuppliersToolStripMenuItem_Click;
        // 
        // viewToolStripMenuItem1
        // 
        viewToolStripMenuItem1.Name = "viewToolStripMenuItem1";
        viewToolStripMenuItem1.Size = new Size(137, 26);
        viewToolStripMenuItem1.Text = "View";
        // 
        // editToolStripMenuItem2
        // 
        editToolStripMenuItem2.Name = "editToolStripMenuItem2";
        editToolStripMenuItem2.Size = new Size(137, 26);
        editToolStripMenuItem2.Text = "Edit";
        // 
        // deleteToolStripMenuItem2
        // 
        deleteToolStripMenuItem2.Name = "deleteToolStripMenuItem2";
        deleteToolStripMenuItem2.Size = new Size(137, 26);
        deleteToolStripMenuItem2.Text = "Delete";
        // 
        // searchToolStripMenuItem
        // 
        searchToolStripMenuItem.Name = "searchToolStripMenuItem";
        searchToolStripMenuItem.Size = new Size(69, 24);
        searchToolStripMenuItem.Text = "Search";
        // 
        // panel1
        // 
        panel1.Controls.Add(txtTest);
        panel1.Location = new Point(0, 36);
        panel1.Margin = new Padding(3, 4, 3, 4);
        panel1.Name = "panel1";
        panel1.Size = new Size(786, 377);
        panel1.TabIndex = 1;
        // 
        // txtTest
        // 
        txtTest.Location = new Point(279, 94);
        txtTest.Name = "txtTest";
        txtTest.Size = new Size(125, 27);
        txtTest.TabIndex = 0;
        txtTest.Visible = false;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.GradientInactiveCaption;
        ClientSize = new Size(786, 416);
        Controls.Add(panel1);
        Controls.Add(menuStrip1);
        FormBorderStyle = FormBorderStyle.None;
        MainMenuStrip = menuStrip1;
        Margin = new Padding(3, 4, 3, 4);
        Name = "MainForm";
        ShowIcon = false;
        StartPosition = FormStartPosition.CenterScreen;
        Load += MainForm_Load;
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private MenuStrip menuStrip1;
    private ToolStripMenuItem homeToolStripMenuItem;
    private ToolStripMenuItem managePackagesToolStripMenuItem;
    private ToolStripMenuItem manageProductsToolStripMenuItem;
    private ToolStripMenuItem loginToolStripMenuItem;
    private ToolStripMenuItem manageSuppliersToolStripMenuItem;
    private ToolStripMenuItem searchToolStripMenuItem;
    private ToolStripMenuItem editToolStripMenuItem;
    private ToolStripMenuItem editToolStripMenuItem1;
    private ToolStripMenuItem deleteToolStripMenuItem;
    private ToolStripMenuItem agenciesToolStripMenuItem1;
    private ToolStripMenuItem viewToolStripMenuItem;
    private ToolStripMenuItem edietToolStripMenuItem;
    private ToolStripMenuItem deleteToolStripMenuItem1;
    private ToolStripMenuItem viewToolStripMenuItem1;
    private ToolStripMenuItem editToolStripMenuItem2;
    private ToolStripMenuItem deleteToolStripMenuItem2;
    private Panel panel1;
    private TextBox txtTest;
}
