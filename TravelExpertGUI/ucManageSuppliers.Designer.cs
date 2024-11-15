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
        ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
        SuspendLayout();
        // 
        // btnDisc
        // 
        btnDisc.Enabled = false;
        btnDisc.Location = new Point(441, 500);
        btnDisc.Name = "btnDisc";
        btnDisc.Size = new Size(193, 29);
        btnDisc.TabIndex = 37;
        btnDisc.Text = "Discard Chan&ges";
        btnDisc.UseVisualStyleBackColor = true;
        btnDisc.Click += btnDisc_Click;
        // 
        // btnSave
        // 
        btnSave.Enabled = false;
        btnSave.Location = new Point(669, 500);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(193, 29);
        btnSave.TabIndex = 36;
        btnSave.Text = "Save Changes";
        btnSave.UseVisualStyleBackColor = true;
        btnSave.Click += btnSave_Click;
        // 
        // btnDelete
        // 
        btnDelete.Location = new Point(313, 500);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(94, 29);
        btnDelete.TabIndex = 41;
        btnDelete.Text = "&Delete";
        btnDelete.UseVisualStyleBackColor = true;
        btnDelete.Click += btnDelete_Click;
        // 
        // btnEdit
        // 
        btnEdit.Location = new Point(185, 500);
        btnEdit.Name = "btnEdit";
        btnEdit.Size = new Size(94, 29);
        btnEdit.TabIndex = 40;
        btnEdit.Text = "&Edit";
        btnEdit.UseVisualStyleBackColor = true;
        btnEdit.Click += btnEdit_Click;
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(57, 500);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(94, 29);
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
        dgvSuppliers.Location = new Point(53, 144);
        dgvSuppliers.Name = "dgvSuppliers";
        dgvSuppliers.RowHeadersWidth = 51;
        dgvSuppliers.Size = new Size(809, 335);
        dgvSuppliers.TabIndex = 38;
        dgvSuppliers.SelectionChanged += dgvSuppliers_SelectionChanged;
        // 
        // lblSupID
        // 
        lblSupID.AutoSize = true;
        lblSupID.Location = new Point(93, 67);
        lblSupID.Name = "lblSupID";
        lblSupID.Size = new Size(90, 20);
        lblSupID.TabIndex = 42;
        lblSupID.Text = "Supplier ID :";
        // 
        // txtSupID
        // 
        txtSupID.Location = new Point(189, 64);
        txtSupID.Name = "txtSupID";
        txtSupID.ReadOnly = true;
        txtSupID.Size = new Size(201, 27);
        txtSupID.TabIndex = 43;
        // 
        // lblSupName
        // 
        lblSupName.AutoSize = true;
        lblSupName.Location = new Point(502, 67);
        lblSupName.Name = "lblSupName";
        lblSupName.Size = new Size(115, 20);
        lblSupName.TabIndex = 44;
        lblSupName.Text = "Supplier Name :";
        // 
        // txtSupName
        // 
        txtSupName.Location = new Point(623, 64);
        txtSupName.Name = "txtSupName";
        txtSupName.ReadOnly = true;
        txtSupName.Size = new Size(201, 27);
        txtSupName.TabIndex = 45;
        // 
        // ucManageSuppliers
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.GradientInactiveCaption;
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
        Size = new Size(914, 571);
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
}
