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
        ((System.ComponentModel.ISupportInitialize)dgvProductSupplier).BeginInit();
        SuspendLayout();
        // 
        // btnDisc
        // 
        btnDisc.Enabled = false;
        btnDisc.Location = new Point(384, 377);
        btnDisc.Margin = new Padding(3, 2, 3, 2);
        btnDisc.Name = "btnDisc";
        btnDisc.Size = new Size(193, 29);
        btnDisc.TabIndex = 47;
        btnDisc.Text = "Discard Chan&ges";
        btnDisc.UseVisualStyleBackColor = true;
        btnDisc.Click += btnDisc_Click;
        // 
        // btnSave
        // 
        btnSave.Enabled = false;
        btnSave.Location = new Point(583, 377);
        btnSave.Margin = new Padding(3, 2, 3, 2);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(193, 29);
        btnSave.TabIndex = 46;
        btnSave.Text = "Save Changes";
        btnSave.UseVisualStyleBackColor = true;
        btnSave.Click += btnSave_Click;
        // 
        // btnDelete
        // 
        btnDelete.Location = new Point(272, 377);
        btnDelete.Margin = new Padding(3, 2, 3, 2);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(94, 29);
        btnDelete.TabIndex = 45;
        btnDelete.Text = "&Delete";
        btnDelete.UseVisualStyleBackColor = true;
        btnDelete.Click += btnDelete_Click;
        // 
        // btnEdit
        // 
        btnEdit.Location = new Point(160, 377);
        btnEdit.Margin = new Padding(3, 2, 3, 2);
        btnEdit.Name = "btnEdit";
        btnEdit.Size = new Size(94, 29);
        btnEdit.TabIndex = 44;
        btnEdit.Text = "&Edit";
        btnEdit.UseVisualStyleBackColor = true;
        btnEdit.Click += btnEdit_Click;
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(48, 377);
        btnAdd.Margin = new Padding(3, 2, 3, 2);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(94, 29);
        btnAdd.TabIndex = 43;
        btnAdd.Text = "&Add";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(67, 60);
        label1.Name = "label1";
        label1.Size = new Size(139, 20);
        label1.TabIndex = 48;
        label1.Text = "Product Supplier Id:";
        // 
        // txtProductSupplierId
        // 
        txtProductSupplierId.BackColor = SystemColors.Control;
        txtProductSupplierId.Location = new Point(178, 45);
        txtProductSupplierId.Name = "txtProductSupplierId";
        txtProductSupplierId.Size = new Size(234, 27);
        txtProductSupplierId.TabIndex = 49;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(67, 116);
        label2.Name = "label2";
        label2.Size = new Size(107, 20);
        label2.TabIndex = 50;
        label2.Text = "Product Name:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(67, 176);
        label3.Name = "label3";
        label3.Size = new Size(111, 20);
        label3.TabIndex = 52;
        label3.Text = "Supplier Name:";
        // 
        // cboProductName
        // 
        cboProductName.BackColor = SystemColors.Control;
        cboProductName.FormattingEnabled = true;
        cboProductName.Location = new Point(212, 113);
        cboProductName.Margin = new Padding(3, 4, 3, 4);
        cboProductName.Name = "cboProductName";
        cboProductName.Size = new Size(100, 23);
        cboProductName.TabIndex = 54;
        // 
        // cboSupplierName
        // 
        cboSupplierName.BackColor = SystemColors.Control;
        cboSupplierName.FormattingEnabled = true;
        cboSupplierName.Location = new Point(212, 173);
        cboSupplierName.Margin = new Padding(3, 4, 3, 4);
        cboSupplierName.Name = "cboSupplierName";
        cboSupplierName.Size = new Size(100, 23);
        cboSupplierName.TabIndex = 55;
        // 
        // dgvProductSupplier
        // 
        dgvProductSupplier.BackgroundColor = SystemColors.GradientActiveCaption;
        dgvProductSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvProductSupplier.Location = new Point(48, 179);
        dgvProductSupplier.Name = "dgvProductSupplier";
        dgvProductSupplier.Size = new Size(704, 175);
        dgvProductSupplier.TabIndex = 56;
        dgvProductSupplier.SelectionChanged += dgvProductSupplier_SelectionChanged;
        // 
        // ucManageProductSuppliers
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.GradientInactiveCaption;
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
        Size = new Size(914, 571);
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
}
