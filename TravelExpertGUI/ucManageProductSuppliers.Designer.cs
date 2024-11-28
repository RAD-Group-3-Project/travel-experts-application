namespace TravelExpertGUI;

partial class ucManageProductSuppliers
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
        label1 = new Label();
        txtProductSupplierId = new TextBox();
        label2 = new Label();
        label3 = new Label();
        cboProductName = new ComboBox();
        cboSupplierName = new ComboBox();
        dgvProductSupplier = new DataGridView();
        btnSearch = new Button();
        lblClearIcon = new Label();
        lblSearchIcon = new Label();
        lblTableName = new Label();
        ((System.ComponentModel.ISupportInitialize)dgvProductSupplier).BeginInit();
        SuspendLayout();
        // 
        // btnDisc
        // 
        btnDisc.Enabled = false;
        btnDisc.Location = new Point(533, 503);
        btnDisc.Name = "btnDisc";
        btnDisc.Size = new Size(163, 29);
        btnDisc.TabIndex = 47;
        btnDisc.Text = "Discard Chan&ges";
        btnDisc.UseVisualStyleBackColor = true;
        btnDisc.Click += btnDisc_Click;
        // 
        // btnSave
        // 
        btnSave.Enabled = false;
        btnSave.Location = new Point(703, 503);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(163, 29);
        btnSave.TabIndex = 46;
        btnSave.Text = "Save Changes";
        btnSave.UseVisualStyleBackColor = true;
        btnSave.Click += btnSave_Click;
        // 
        // btnDelete
        // 
        btnDelete.ForeColor = Color.FromArgb(192, 0, 0);
        btnDelete.Location = new Point(241, 503);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(79, 29);
        btnDelete.TabIndex = 45;
        btnDelete.Text = "&Delete";
        btnDelete.UseVisualStyleBackColor = true;
        btnDelete.Click += btnDelete_Click;
        // 
        // btnEdit
        // 
        btnEdit.Location = new Point(155, 503);
        btnEdit.Name = "btnEdit";
        btnEdit.Size = new Size(79, 29);
        btnEdit.TabIndex = 44;
        btnEdit.Text = "&Edit";
        btnEdit.UseVisualStyleBackColor = true;
        btnEdit.Click += btnEdit_Click;
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(49, 503);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(79, 29);
        btnAdd.TabIndex = 43;
        btnAdd.Text = "&Add";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(65, 92);
        label1.Name = "label1";
        label1.Size = new Size(139, 20);
        label1.TabIndex = 48;
        label1.Text = "Product Supplier Id:";
        // 
        // txtProductSupplierId
        // 
        txtProductSupplierId.BackColor = SystemColors.Control;
        txtProductSupplierId.Location = new Point(225, 89);
        txtProductSupplierId.Margin = new Padding(3, 4, 3, 4);
        txtProductSupplierId.Name = "txtProductSupplierId";
        txtProductSupplierId.Size = new Size(114, 27);
        txtProductSupplierId.TabIndex = 49;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(65, 144);
        label2.Name = "label2";
        label2.Size = new Size(107, 20);
        label2.TabIndex = 50;
        label2.Text = "Product Name:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(65, 204);
        label3.Name = "label3";
        label3.Size = new Size(111, 20);
        label3.TabIndex = 52;
        label3.Text = "Supplier Name:";
        // 
        // cboProductName
        // 
        cboProductName.BackColor = SystemColors.Control;
        cboProductName.FormattingEnabled = true;
        cboProductName.Location = new Point(225, 144);
        cboProductName.Margin = new Padding(3, 4, 3, 4);
        cboProductName.Name = "cboProductName";
        cboProductName.Size = new Size(236, 28);
        cboProductName.TabIndex = 54;
        // 
        // cboSupplierName
        // 
        cboSupplierName.BackColor = SystemColors.Control;
        cboSupplierName.FormattingEnabled = true;
        cboSupplierName.Location = new Point(225, 201);
        cboSupplierName.Margin = new Padding(3, 4, 3, 4);
        cboSupplierName.Name = "cboSupplierName";
        cboSupplierName.Size = new Size(236, 28);
        cboSupplierName.TabIndex = 55;
        // 
        // dgvProductSupplier
        // 
        dgvProductSupplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvProductSupplier.BackgroundColor = SystemColors.GradientActiveCaption;
        dgvProductSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvProductSupplier.Location = new Point(49, 275);
        dgvProductSupplier.Margin = new Padding(3, 4, 3, 4);
        dgvProductSupplier.Name = "dgvProductSupplier";
        dgvProductSupplier.ReadOnly = true;
        dgvProductSupplier.RowHeadersWidth = 51;
        dgvProductSupplier.Size = new Size(817, 197);
        dgvProductSupplier.TabIndex = 56;
        dgvProductSupplier.SelectionChanged += dgvProductSupplier_SelectionChanged;
        // 
        // btnSearch
        // 
        btnSearch.Location = new Point(365, 501);
        btnSearch.Margin = new Padding(3, 4, 3, 4);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new Size(127, 31);
        btnSearch.TabIndex = 69;
        btnSearch.Text = "&Search";
        btnSearch.UseVisualStyleBackColor = true;
        btnSearch.Click += btnSearch_Click;
        // 
        // lblClearIcon
        // 
        lblClearIcon.AutoSize = true;
        lblClearIcon.Font = new Font("Segoe UI", 15F);
        lblClearIcon.Location = new Point(819, 225);
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
        lblSearchIcon.Location = new Point(776, 225);
        lblSearchIcon.Name = "lblSearchIcon";
        lblSearchIcon.Size = new Size(49, 35);
        lblSearchIcon.TabIndex = 71;
        lblSearchIcon.Text = "🔍";
        lblSearchIcon.Click += lblSearchIcon_Click;
        lblSearchIcon.MouseLeave += lblSearchIcon_MouseLeave;
        lblSearchIcon.MouseHover += lblSearchIcon_MouseHover;
        // 
        // lblTableName
        // 
        lblTableName.AutoSize = true;
        lblTableName.Font = new Font("Segoe UI", 20F);
        lblTableName.Location = new Point(67, 25);
        lblTableName.Name = "lblTableName";
        lblTableName.Size = new Size(195, 46);
        lblTableName.TabIndex = 73;
        lblTableName.Text = "Table Name";
        // 
        // ucManageProductSuppliers
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.GradientInactiveCaption;
        Controls.Add(lblTableName);
        Controls.Add(lblClearIcon);
        Controls.Add(lblSearchIcon);
        Controls.Add(btnSearch);
        Controls.Add(dgvProductSupplier);
        Controls.Add(cboSupplierName);
        Controls.Add(cboProductName);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(txtProductSupplierId);
        Controls.Add(label1);
        Controls.Add(btnDisc);
        Controls.Add(btnSave);
        Controls.Add(btnDelete);
        Controls.Add(btnEdit);
        Controls.Add(btnAdd);
        Margin = new Padding(3, 4, 3, 4);
        Name = "ucManageProductSuppliers";
        Size = new Size(914, 563);
        Load += ucManageProductSuppliers_Load;
        ((System.ComponentModel.ISupportInitialize)dgvProductSupplier).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnDisc;
    private Button btnSave;
    private Button btnDelete;
    private Button btnEdit;
    private Button btnAdd;
    private Label label1;
    private TextBox txtProductSupplierId;
    private Label label2;
    private Label label3;
    private ComboBox cboProductName;
    private ComboBox cboSupplierName;
    private DataGridView dgvProductSupplier;
    private Button btnSearch;
    private Label lblClearIcon;
    private Label lblSearchIcon;
    private Label lblTableName;
}
