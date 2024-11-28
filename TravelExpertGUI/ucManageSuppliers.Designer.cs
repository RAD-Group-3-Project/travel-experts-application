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
        lblTableName = new Label();
        ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
        SuspendLayout();
        // 
        // btnDisc
        // 
        btnDisc.Enabled = false;
        btnDisc.Location = new Point(523, 500);
        btnDisc.Name = "btnDisc";
        btnDisc.Size = new Size(163, 29);
        btnDisc.TabIndex = 37;
        btnDisc.Text = "Discard Chan&ges";
        btnDisc.UseVisualStyleBackColor = true;
        btnDisc.Click += btnDisc_Click;
        // 
        // btnSave
        // 
        btnSave.Enabled = false;
        btnSave.Location = new Point(694, 500);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(163, 29);
        btnSave.TabIndex = 36;
        btnSave.Text = "Save Changes";
        btnSave.UseVisualStyleBackColor = true;
        btnSave.Click += btnSave_Click;
        // 
        // btnDelete
        // 
        btnDelete.ForeColor = Color.FromArgb(192, 0, 0);
        btnDelete.Location = new Point(251, 500);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(79, 29);
        btnDelete.TabIndex = 41;
        btnDelete.Text = "&Delete";
        btnDelete.UseVisualStyleBackColor = true;
        btnDelete.Click += btnDelete_Click;
        // 
        // btnEdit
        // 
        btnEdit.Location = new Point(166, 500);
        btnEdit.Name = "btnEdit";
        btnEdit.Size = new Size(79, 29);
        btnEdit.TabIndex = 40;
        btnEdit.Text = "&Edit";
        btnEdit.UseVisualStyleBackColor = true;
        btnEdit.Click += btnEdit_Click;
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(57, 500);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(79, 29);
        btnAdd.TabIndex = 39;
        btnAdd.Text = "&Add";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // dgvSuppliers
        // 
        dgvSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvSuppliers.BackgroundColor = SystemColors.GradientActiveCaption;
        dgvSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvSuppliers.Location = new Point(57, 204);
        dgvSuppliers.Name = "dgvSuppliers";
        dgvSuppliers.ReadOnly = true;
        dgvSuppliers.RowHeadersWidth = 51;
        dgvSuppliers.Size = new Size(800, 275);
        dgvSuppliers.TabIndex = 38;
        dgvSuppliers.SelectionChanged += dgvSuppliers_SelectionChanged;
        // 
        // lblSupID
        // 
        lblSupID.AutoSize = true;
        lblSupID.Location = new Point(57, 103);
        lblSupID.Name = "lblSupID";
        lblSupID.Size = new Size(90, 20);
        lblSupID.TabIndex = 42;
        lblSupID.Text = "Supplier ID :";
        // 
        // txtSupID
        // 
        txtSupID.Location = new Point(153, 100);
        txtSupID.Name = "txtSupID";
        txtSupID.ReadOnly = true;
        txtSupID.Size = new Size(201, 27);
        txtSupID.TabIndex = 43;
        // 
        // lblSupName
        // 
        lblSupName.AutoSize = true;
        lblSupName.Location = new Point(466, 103);
        lblSupName.Name = "lblSupName";
        lblSupName.Size = new Size(115, 20);
        lblSupName.TabIndex = 44;
        lblSupName.Text = "Supplier Name :";
        // 
        // txtSupName
        // 
        txtSupName.Location = new Point(587, 100);
        txtSupName.Name = "txtSupName";
        txtSupName.ReadOnly = true;
        txtSupName.Size = new Size(201, 27);
        txtSupName.TabIndex = 45;
        // 
        // lblClearIcon
        // 
        lblClearIcon.AutoSize = true;
        lblClearIcon.Font = new Font("Segoe UI", 15F);
        lblClearIcon.Location = new Point(808, 151);
        lblClearIcon.Name = "lblClearIcon";
        lblClearIcon.Size = new Size(49, 35);
        lblClearIcon.TabIndex = 72;
        lblClearIcon.Text = "✖";
        lblClearIcon.Click += lblClearIcon_Click;
        lblClearIcon.MouseLeave += lblClearIcon_MouseLeave;
        lblClearIcon.MouseHover += lblClearIcon_MouseHover;
        // 
        // lblSearchIcon
        // 
        lblSearchIcon.AutoSize = true;
        lblSearchIcon.Font = new Font("Segoe UI", 15F);
        lblSearchIcon.Location = new Point(766, 151);
        lblSearchIcon.Name = "lblSearchIcon";
        lblSearchIcon.Size = new Size(49, 35);
        lblSearchIcon.TabIndex = 71;
        lblSearchIcon.Text = "🔍";
        lblSearchIcon.Click += lblSearchIcon_Click;
        lblSearchIcon.MouseLeave += lblSearchIcon_MouseLeave;
        lblSearchIcon.MouseHover += lblSearchIcon_MouseHover;
        // 
        // btnSearch
        // 
        btnSearch.Location = new Point(363, 500);
        btnSearch.Margin = new Padding(3, 4, 3, 4);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new Size(127, 31);
        btnSearch.TabIndex = 73;
        btnSearch.Text = "&Search";
        btnSearch.UseVisualStyleBackColor = true;
        btnSearch.Click += btnSearch_Click;
        // 
        // lblTableName
        // 
        lblTableName.AutoSize = true;
        lblTableName.Font = new Font("Segoe UI", 20F);
        lblTableName.Location = new Point(57, 39);
        lblTableName.Name = "lblTableName";
        lblTableName.Size = new Size(195, 46);
        lblTableName.TabIndex = 74;
        lblTableName.Text = "Table Name";
        // 
        // ucManageSuppliers
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.GradientInactiveCaption;
        Controls.Add(lblTableName);
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
        Name = "ucManageSuppliers";
        Size = new Size(914, 563);
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
    private Label lblTableName;
}
