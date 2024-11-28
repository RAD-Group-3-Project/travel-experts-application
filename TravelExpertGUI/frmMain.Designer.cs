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
        toolStripMenuItem1 = new ToolStripMenuItem();
        exitToolStripMenuItem = new ToolStripMenuItem();
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
        menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, mnuUser, mnuDatabase });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Padding = new Padding(7, 3, 0, 3);
        menuStrip1.Size = new Size(914, 65);
        menuStrip1.TabIndex = 0;
        menuStrip1.Text = "menuStrip1";
        // 
        // toolStripMenuItem1
        // 
        toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
        toolStripMenuItem1.Name = "toolStripMenuItem1";
        toolStripMenuItem1.Size = new Size(55, 59);
        toolStripMenuItem1.Text = "File";
        // 
        // exitToolStripMenuItem
        // 
        exitToolStripMenuItem.Name = "exitToolStripMenuItem";
        exitToolStripMenuItem.Size = new Size(128, 30);
        exitToolStripMenuItem.Text = "Exit";
        exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
        // 
        // mnuUser
        // 
        mnuUser.DropDownItems.AddRange(new ToolStripItem[] { profileToolStripMenuItem, changePasswordToolStripMenuItem, signOutToolStripMenuItem });
        mnuUser.Name = "mnuUser";
        mnuUser.Size = new Size(64, 59);
        mnuUser.Text = "User";
        // 
        // profileToolStripMenuItem
        // 
        profileToolStripMenuItem.Name = "profileToolStripMenuItem";
        profileToolStripMenuItem.Size = new Size(248, 30);
        profileToolStripMenuItem.Text = "Profile";
        profileToolStripMenuItem.Click += profileToolStripMenuItem_Click;
        // 
        // changePasswordToolStripMenuItem
        // 
        changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
        changePasswordToolStripMenuItem.Size = new Size(248, 30);
        changePasswordToolStripMenuItem.Text = "Change password";
        // 
        // signOutToolStripMenuItem
        // 
        signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
        signOutToolStripMenuItem.Size = new Size(248, 30);
        signOutToolStripMenuItem.Text = "Sign out";
        signOutToolStripMenuItem.Click += signOutToolStripMenuItem_Click;
        // 
        // mnuDatabase
        // 
        mnuDatabase.Name = "mnuDatabase";
        mnuDatabase.Size = new Size(104, 59);
        mnuDatabase.Text = "Database";
        // 
        // contentPanel
        // 
        contentPanel.BackColor = SystemColors.GradientInactiveCaption;
        contentPanel.BackgroundImage = Properties.Resources.travel_expert_logo;
        contentPanel.BackgroundImageLayout = ImageLayout.Zoom;
        contentPanel.Location = new Point(0, 68);
        contentPanel.Name = "contentPanel";
        contentPanel.Size = new Size(914, 560);
        contentPanel.TabIndex = 1;
        // 
        // frmMain
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(914, 627);
        ControlBox = false;
        Controls.Add(contentPanel);
        Controls.Add(menuStrip1);
        FormBorderStyle = FormBorderStyle.None;
        MainMenuStrip = menuStrip1;
        Margin = new Padding(3, 4, 3, 4);
        Name = "frmMain";
        ShowIcon = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Travel Expert Management";
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
    private ToolStripMenuItem toolStripMenuItem1;
    private ToolStripMenuItem exitToolStripMenuItem;
}