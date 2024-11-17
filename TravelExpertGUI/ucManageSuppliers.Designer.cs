namespace TravelExpertGUI;

partial class ucManageSuppliers
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        btnDisc = new Button();
        btnSave = new Button();
        btnDelete = new Button();
        btnEdit = new Button();
        btnAdd = new Button();
        dgvSuppliers = new DataGridView();
        lblSupID = new Label();
        txtSupID = new TextBox();
        lblSupName = new Label();
        txtSupName = new TextBox();
        lblClearIcon = new Label();
        lblSearchIcon = new Label();
        btnSearch = new Button();
        ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
        SuspendLayout();
        // 
        // btnDisc
        // 
        btnDisc.Enabled = false;
        btnDisc.Location = new Point(458, 375);
        btnDisc.Margin = new Padding(3, 2, 3, 2);
        btnDisc.Name = "btnDisc";
        btnDisc.Size = new Size(143, 22);
        btnDisc.TabIndex = 37;
        btnDisc.Text = "Discard Chan&ges";
        btnDisc.UseVisualStyleBackColor = true;
        btnDisc.Click += btnDisc_Click;
        // 
        // btnSave
        // 
        btnSave.Enabled = false;
        btnSave.Location = new Point(607, 375);
        btnSave.Margin = new Padding(3, 2, 3, 2);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(143, 22);
        btnSave.TabIndex = 36;
        btnSave.Text = "Save Changes";
        btnSave.UseVisualStyleBackColor = true;
        btnSave.Click += btnSave_Click;
        // 
        // btnDelete
        // 
        btnDelete.ForeColor = Color.FromArgb(192, 0, 0);
        btnDelete.Location = new Point(220, 375);
        btnDelete.Margin = new Padding(3, 2, 3, 2);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(69, 22);
        btnDelete.TabIndex = 41;
        btnDelete.Text = "&Delete";
        btnDelete.UseVisualStyleBackColor = true;
        btnDelete.Click += btnDelete_Click;
        // 
        // btnEdit
        // 
        btnEdit.Location = new Point(145, 375);
        btnEdit.Margin = new Padding(3, 2, 3, 2);
        btnEdit.Name = "btnEdit";
        btnEdit.Size = new Size(69, 22);
        btnEdit.TabIndex = 40;
        btnEdit.Text = "&Edit";
        btnEdit.UseVisualStyleBackColor = true;
        btnEdit.Click += btnEdit_Click;
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(50, 375);
        btnAdd.Margin = new Padding(3, 2, 3, 2);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(69, 22);
        btnAdd.TabIndex = 39;
        btnAdd.Text = "&Add";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // dgvSuppliers
        // 
        dgvSuppliers.BackgroundColor = SystemColors.GradientActiveCaption;
        dgvSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvSuppliers.Location = new Point(50, 125);
        dgvSuppliers.Margin = new Padding(3, 2, 3, 2);
        dgvSuppliers.Name = "dgvSuppliers";
        dgvSuppliers.RowHeadersWidth = 51;
        dgvSuppliers.Size = new Size(700, 234);
        dgvSuppliers.TabIndex = 38;
        dgvSuppliers.SelectionChanged += dgvSuppliers_SelectionChanged;
        // 
        // lblSupID
        // 
        lblSupID.AutoSize = true;
        lblSupID.Location = new Point(81, 50);
        lblSupID.Name = "lblSupID";
        lblSupID.Size = new Size(70, 15);
        lblSupID.TabIndex = 42;
        lblSupID.Text = "Supplier ID :";
        // 
        // txtSupID
        // 
        txtSupID.Location = new Point(165, 48);
        txtSupID.Margin = new Padding(3, 2, 3, 2);
        txtSupID.Name = "txtSupID";
        txtSupID.ReadOnly = true;
        txtSupID.Size = new Size(176, 23);
        txtSupID.TabIndex = 43;
        // 
        // lblSupName
        // 
        lblSupName.AutoSize = true;
        lblSupName.Location = new Point(439, 50);
        lblSupName.Name = "lblSupName";
        lblSupName.Size = new Size(91, 15);
        lblSupName.TabIndex = 44;
        lblSupName.Text = "Supplier Name :";
        // 
        // txtSupName
        // 
        txtSupName.Location = new Point(545, 48);
        txtSupName.Margin = new Padding(3, 2, 3, 2);
        txtSupName.Name = "txtSupName";
        txtSupName.ReadOnly = true;
        txtSupName.Size = new Size(176, 23);
        txtSupName.TabIndex = 45;
        // 
        // lblClearIcon
        // 
        lblClearIcon.AutoSize = true;
        lblClearIcon.Font = new Font("Segoe UI", 15F);
        lblClearIcon.Location = new Point(710, 95);
        lblClearIcon.Name = "lblClearIcon";
        lblClearIcon.Size = new Size(39, 28);
        lblClearIcon.TabIndex = 72;
        lblClearIcon.Text = "✖";
        // 
        // lblSearchIcon
        // 
        lblSearchIcon.AutoSize = true;
        lblSearchIcon.Font = new Font("Segoe UI", 15F);
        lblSearchIcon.Location = new Point(673, 95);
        lblSearchIcon.Name = "lblSearchIcon";
        lblSearchIcon.Size = new Size(39, 28);
        lblSearchIcon.TabIndex = 71;
        lblSearchIcon.Text = "🔍";
        // 
        // btnSearch
        // 
        btnSearch.Location = new Point(318, 375);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new Size(111, 23);
        btnSearch.TabIndex = 73;
        btnSearch.Text = "&Search";
        btnSearch.UseVisualStyleBackColor = true;
        // 
        // ucManageSuppliers
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.GradientInactiveCaption;
        Controls.Add(btnSearch);
        Controls.Add(lblClearIcon);
        Controls.Add(lblSearchIcon);
        Controls.Add(txtSupName);
        Controls.Add(lblSupName);
        Controls.Add(txtSupID);
        Controls.Add(lblSupID);
        Controls.Add(btnDisc);
        Controls.Add(btnSave);
        Controls.Add(btnDelete);
        Controls.Add(btnEdit);
        Controls.Add(btnAdd);
        Controls.Add(dgvSuppliers);
        Margin = new Padding(3, 2, 3, 2);
        Name = "ucManageSuppliers";
        Size = new Size(800, 422);
        Load += ucManageSuppliers_Load;
        ((System.ComponentModel.ISupportInitialize)dgvSuppliers).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnDisc;
    private Button btnSave;
    private Button btnDelete;
    private Button btnEdit;
    private Button btnAdd;
    private DataGridView dgvSuppliers;
    private Label lblSupID;
    private TextBox txtSupID;
    private Label lblSupName;
    private TextBox txtSupName;
    private Label lblClearIcon;
    private Label lblSearchIcon;
    private Button btnSearch;
}
