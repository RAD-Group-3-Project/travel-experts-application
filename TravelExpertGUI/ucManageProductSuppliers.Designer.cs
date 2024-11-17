﻿namespace TravelExpertGUI;

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
        ((System.ComponentModel.ISupportInitialize)dgvProductSupplier).BeginInit();
        SuspendLayout();
        // 
        // btnDisc
        // 
        btnDisc.Enabled = false;
        btnDisc.Location = new Point(466, 377);
        btnDisc.Margin = new Padding(3, 2, 3, 2);
        btnDisc.Name = "btnDisc";
        btnDisc.Size = new Size(143, 22);
        btnDisc.TabIndex = 47;
        btnDisc.Text = "Discard Chan&ges";
        btnDisc.UseVisualStyleBackColor = true;
        btnDisc.Click += btnDisc_Click;
        // 
        // btnSave
        // 
        btnSave.Enabled = false;
        btnSave.Location = new Point(615, 377);
        btnSave.Margin = new Padding(3, 2, 3, 2);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(143, 22);
        btnSave.TabIndex = 46;
        btnSave.Text = "Save Changes";
        btnSave.UseVisualStyleBackColor = true;
        btnSave.Click += btnSave_Click;
        // 
        // btnDelete
        // 
        btnDelete.ForeColor = Color.FromArgb(192, 0, 0);
        btnDelete.Location = new Point(211, 377);
        btnDelete.Margin = new Padding(3, 2, 3, 2);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(69, 22);
        btnDelete.TabIndex = 45;
        btnDelete.Text = "&Delete";
        btnDelete.UseVisualStyleBackColor = true;
        btnDelete.Click += btnDelete_Click;
        // 
        // btnEdit
        // 
        btnEdit.Location = new Point(136, 377);
        btnEdit.Margin = new Padding(3, 2, 3, 2);
        btnEdit.Name = "btnEdit";
        btnEdit.Size = new Size(69, 22);
        btnEdit.TabIndex = 44;
        btnEdit.Text = "&Edit";
        btnEdit.UseVisualStyleBackColor = true;
        btnEdit.Click += btnEdit_Click;
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(43, 377);
        btnAdd.Margin = new Padding(3, 2, 3, 2);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(69, 22);
        btnAdd.TabIndex = 43;
        btnAdd.Text = "&Add";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(59, 48);
        label1.Name = "label1";
        label1.Size = new Size(111, 15);
        label1.TabIndex = 48;
        label1.Text = "Product Supplier Id:";
        // 
        // txtProductSupplierId
        // 
        txtProductSupplierId.BackColor = SystemColors.Control;
        txtProductSupplierId.Location = new Point(199, 46);
        txtProductSupplierId.Name = "txtProductSupplierId";
        txtProductSupplierId.Size = new Size(100, 23);
        txtProductSupplierId.TabIndex = 49;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(59, 87);
        label2.Name = "label2";
        label2.Size = new Size(87, 15);
        label2.TabIndex = 50;
        label2.Text = "Product Name:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(59, 132);
        label3.Name = "label3";
        label3.Size = new Size(88, 15);
        label3.TabIndex = 52;
        label3.Text = "Supplier Name:";
        // 
        // cboProductName
        // 
        cboProductName.BackColor = SystemColors.Control;
        cboProductName.FormattingEnabled = true;
        cboProductName.Location = new Point(199, 87);
        cboProductName.Name = "cboProductName";
        cboProductName.Size = new Size(207, 23);
        cboProductName.TabIndex = 54;
        // 
        // cboSupplierName
        // 
        cboSupplierName.BackColor = SystemColors.Control;
        cboSupplierName.FormattingEnabled = true;
        cboSupplierName.Location = new Point(199, 130);
        cboSupplierName.Name = "cboSupplierName";
        cboSupplierName.Size = new Size(207, 23);
        cboSupplierName.TabIndex = 55;
        // 
        // dgvProductSupplier
        // 
        dgvProductSupplier.BackgroundColor = SystemColors.GradientActiveCaption;
        dgvProductSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvProductSupplier.Location = new Point(43, 179);
        dgvProductSupplier.Name = "dgvProductSupplier";
        dgvProductSupplier.RowHeadersWidth = 51;
        dgvProductSupplier.Size = new Size(715, 175);
        dgvProductSupplier.TabIndex = 56;
        dgvProductSupplier.SelectionChanged += dgvProductSupplier_SelectionChanged;
        // 
        // btnSearch
        // 
        btnSearch.Location = new Point(319, 376);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new Size(111, 23);
        btnSearch.TabIndex = 69;
        btnSearch.Text = "&Search";
        btnSearch.UseVisualStyleBackColor = true;
        // 
        // lblClearIcon
        // 
        lblClearIcon.AutoSize = true;
        lblClearIcon.Font = new Font("Segoe UI", 15F);
        lblClearIcon.Location = new Point(718, 148);
        lblClearIcon.Name = "lblClearIcon";
        lblClearIcon.Size = new Size(39, 28);
        lblClearIcon.TabIndex = 72;
        lblClearIcon.Text = "✖";
        // 
        // lblSearchIcon
        // 
        lblSearchIcon.AutoSize = true;
        lblSearchIcon.Font = new Font("Segoe UI", 15F);
        lblSearchIcon.Location = new Point(681, 148);
        lblSearchIcon.Name = "lblSearchIcon";
        lblSearchIcon.Size = new Size(39, 28);
        lblSearchIcon.TabIndex = 71;
        lblSearchIcon.Text = "🔍";
        // 
        // ucManageProductSuppliers
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.GradientInactiveCaption;
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
        Name = "ucManageProductSuppliers";
        Size = new Size(800, 422);
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
}
