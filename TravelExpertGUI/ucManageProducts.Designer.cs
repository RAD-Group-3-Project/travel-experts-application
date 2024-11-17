namespace TravelExpertGUI;

partial class ucManageProducts
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
        txtSupName = new TextBox();
        label1 = new Label();
        txtSupID = new TextBox();
        label2 = new Label();
        btnSearch = new Button();
        lblClearIcon = new Label();
        lblSearchIcon = new Label();
        ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
        SuspendLayout();
        // 
        // btnDisc
        // 
        btnDisc.Enabled = false;
        btnDisc.Location = new Point(469, 375);
        btnDisc.Margin = new Padding(3, 2, 3, 2);
        btnDisc.Name = "btnDisc";
        btnDisc.Size = new Size(143, 22);
        btnDisc.TabIndex = 43;
        btnDisc.Text = "Discard Chan&ges";
        btnDisc.UseVisualStyleBackColor = true;
        // 
        // btnSave
        // 
        btnSave.Enabled = false;
        btnSave.Location = new Point(618, 375);
        btnSave.Margin = new Padding(3, 2, 3, 2);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(143, 22);
        btnSave.TabIndex = 42;
        btnSave.Text = "Save Changes";
        btnSave.UseVisualStyleBackColor = true;
        // 
        // btnDelete
        // 
        btnDelete.ForeColor = Color.FromArgb(192, 0, 0);
        btnDelete.Location = new Point(230, 375);
        btnDelete.Margin = new Padding(3, 2, 3, 2);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(82, 22);
        btnDelete.TabIndex = 47;
        btnDelete.Text = "&Delete";
        btnDelete.UseVisualStyleBackColor = true;
        // 
        // btnEdit
        // 
        btnEdit.Location = new Point(142, 375);
        btnEdit.Margin = new Padding(3, 2, 3, 2);
        btnEdit.Name = "btnEdit";
        btnEdit.Size = new Size(82, 22);
        btnEdit.TabIndex = 46;
        btnEdit.Text = "&Edit";
        btnEdit.UseVisualStyleBackColor = true;
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(40, 375);
        btnAdd.Margin = new Padding(3, 2, 3, 2);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(82, 22);
        btnAdd.TabIndex = 45;
        btnAdd.Text = "&Add";
        btnAdd.UseVisualStyleBackColor = true;
        // 
        // dgvSuppliers
        // 
        dgvSuppliers.BackgroundColor = SystemColors.GradientActiveCaption;
        dgvSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvSuppliers.Location = new Point(40, 121);
        dgvSuppliers.Margin = new Padding(3, 2, 3, 2);
        dgvSuppliers.Name = "dgvSuppliers";
        dgvSuppliers.RowHeadersWidth = 51;
        dgvSuppliers.Size = new Size(721, 233);
        dgvSuppliers.TabIndex = 44;
        // 
        // txtSupName
        // 
        txtSupName.Location = new Point(538, 52);
        txtSupName.Margin = new Padding(3, 2, 3, 2);
        txtSupName.Name = "txtSupName";
        txtSupName.ReadOnly = true;
        txtSupName.Size = new Size(176, 23);
        txtSupName.TabIndex = 53;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(432, 54);
        label1.Name = "label1";
        label1.Size = new Size(90, 15);
        label1.TabIndex = 52;
        label1.Text = "Product Name :";
        // 
        // txtSupID
        // 
        txtSupID.Location = new Point(158, 52);
        txtSupID.Margin = new Padding(3, 2, 3, 2);
        txtSupID.Name = "txtSupID";
        txtSupID.ReadOnly = true;
        txtSupID.Size = new Size(176, 23);
        txtSupID.TabIndex = 51;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(74, 54);
        label2.Name = "label2";
        label2.Size = new Size(69, 15);
        label2.TabIndex = 50;
        label2.Text = "Product ID :";
        // 
        // btnSearch
        // 
        btnSearch.Location = new Point(333, 375);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new Size(111, 23);
        btnSearch.TabIndex = 68;
        btnSearch.Text = "&Search";
        btnSearch.UseVisualStyleBackColor = true;
        // 
        // lblClearIcon
        // 
        lblClearIcon.AutoSize = true;
        lblClearIcon.Font = new Font("Segoe UI", 15F);
        lblClearIcon.Location = new Point(722, 91);
        lblClearIcon.Name = "lblClearIcon";
        lblClearIcon.Size = new Size(39, 28);
        lblClearIcon.TabIndex = 70;
        lblClearIcon.Text = "✖";
        lblClearIcon.Click += lblClearIcon_Click;
        // 
        // lblSearchIcon
        // 
        lblSearchIcon.AutoSize = true;
        lblSearchIcon.Font = new Font("Segoe UI", 15F);
        lblSearchIcon.Location = new Point(685, 91);
        lblSearchIcon.Name = "lblSearchIcon";
        lblSearchIcon.Size = new Size(39, 28);
        lblSearchIcon.TabIndex = 69;
        lblSearchIcon.Text = "🔍";
        lblSearchIcon.Click += this.lblSearchIcon_Click;
        // 
        // ucManageProducts
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.GradientInactiveCaption;
        Controls.Add(lblClearIcon);
        Controls.Add(lblSearchIcon);
        Controls.Add(btnSearch);
        Controls.Add(txtSupName);
        Controls.Add(label1);
        Controls.Add(txtSupID);
        Controls.Add(label2);
        Controls.Add(btnDisc);
        Controls.Add(btnSave);
        Controls.Add(btnDelete);
        Controls.Add(btnEdit);
        Controls.Add(btnAdd);
        Controls.Add(dgvSuppliers);
        Margin = new Padding(3, 2, 3, 2);
        Name = "ucManageProducts";
        Size = new Size(800, 422);
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
    private TextBox txtSupName;
    private Label label1;
    private TextBox txtSupID;
    private Label label2;
    private Button btnSearch;
    private Label lblClearIcon;
    private Label lblSearchIcon;
}
