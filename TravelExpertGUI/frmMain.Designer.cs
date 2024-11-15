namespace TravelExpertGUI;

partial class frmMain
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        menuStrip1 = new MenuStrip();
        mnuUser = new ToolStripMenuItem();
        profileToolStripMenuItem = new ToolStripMenuItem();
        changePasswordToolStripMenuItem = new ToolStripMenuItem();
        signOutToolStripMenuItem = new ToolStripMenuItem();
        mnuDatabase = new ToolStripMenuItem();
        contentPanel = new Panel();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // menuStrip1
        // 
        menuStrip1.AutoSize = false;
        menuStrip1.BackColor = Color.DodgerBlue;
        menuStrip1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        menuStrip1.ImageScalingSize = new Size(20, 20);
        menuStrip1.Items.AddRange(new ToolStripItem[] { mnuUser, mnuDatabase });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(800, 49);
        menuStrip1.TabIndex = 0;
        menuStrip1.Text = "menuStrip1";
        // 
        // mnuUser
        // 
        mnuUser.DropDownItems.AddRange(new ToolStripItem[] { profileToolStripMenuItem, changePasswordToolStripMenuItem, signOutToolStripMenuItem });
        mnuUser.Name = "mnuUser";
        mnuUser.Size = new Size(42, 20);
        mnuUser.Text = "User";
        // 
        // profileToolStripMenuItem
        // 
        profileToolStripMenuItem.Name = "profileToolStripMenuItem";
        profileToolStripMenuItem.Size = new Size(168, 22);
        profileToolStripMenuItem.Text = "Profile";
        // 
        // changePasswordToolStripMenuItem
        // 
        changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
        changePasswordToolStripMenuItem.Size = new Size(168, 22);
        changePasswordToolStripMenuItem.Text = "Change password";
        // 
        // signOutToolStripMenuItem
        // 
        signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
        signOutToolStripMenuItem.Size = new Size(168, 22);
        signOutToolStripMenuItem.Text = "Sign out";
        // 
        // mnuDatabase
        // 
        mnuDatabase.Name = "mnuDatabase";
        mnuDatabase.Size = new Size(67, 20);
        mnuDatabase.Text = "Database";
        // 
        // contentPanel
        // 
        contentPanel.BackColor = SystemColors.GradientInactiveCaption;
        contentPanel.BackgroundImage = Properties.Resources.travel_expert_logo;
        contentPanel.BackgroundImageLayout = ImageLayout.Zoom;
        contentPanel.Location = new Point(0, 51);
        contentPanel.Margin = new Padding(3, 2, 3, 2);
        contentPanel.Name = "contentPanel";
        contentPanel.Size = new Size(800, 402);
        contentPanel.TabIndex = 1;
        // 
        // frmMain
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        ControlBox = false;
        Controls.Add(contentPanel);
        Controls.Add(menuStrip1);
        FormBorderStyle = FormBorderStyle.None;
        MainMenuStrip = menuStrip1;
        Name = "frmMain";
        ShowIcon = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Travel Expert Management";
        TopMost = true;
        FormClosed += frmMain_FormClosed;
        Load += frmMain_Load;
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private MenuStrip menuStrip1;
    private ToolStripMenuItem mnuUser;
    private ToolStripMenuItem profileToolStripMenuItem;
    private ToolStripMenuItem changePasswordToolStripMenuItem;
    private ToolStripMenuItem signOutToolStripMenuItem;
    private ToolStripMenuItem mnuDatabase;
    private Panel contentPanel;
}