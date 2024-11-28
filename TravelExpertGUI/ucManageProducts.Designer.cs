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
        dgvProducts = new DataGridView();
        txtProdName = new TextBox();
        label1 = new Label();
        txtProdId = new TextBox();
        label2 = new Label();
        btnSearch = new Button();
        lblClearIcon = new Label();
        lblSearchIcon = new Label();
        lblTableName = new Label();
        ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
        SuspendLayout();
        // 
        // btnDisc
        // 
        btnDisc.Enabled = false;
        btnDisc.Location = new Point(536, 500);
        btnDisc.Name = "btnDisc";
        btnDisc.Size = new Size(163, 29);
        btnDisc.TabIndex = 43;
        btnDisc.Text = "Discard Chan&ges";
        btnDisc.UseVisualStyleBackColor = true;
        btnDisc.Click += btnDisc_Click;
        // 
        // btnSave
        // 
        btnSave.Enabled = false;
        btnSave.Location = new Point(706, 500);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(163, 29);
        btnSave.TabIndex = 42;
        btnSave.Text = "Save Changes";
        btnSave.UseVisualStyleBackColor = true;
        btnSave.Click += btnSave_Click;
        // 
        // btnDelete
        // 
        btnDelete.ForeColor = Color.FromArgb(192, 0, 0);
        btnDelete.Location = new Point(263, 500);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(94, 29);
        btnDelete.TabIndex = 47;
        btnDelete.Text = "&Delete";
        btnDelete.UseVisualStyleBackColor = true;
        btnDelete.Click += btnDelete_Click;
        // 
        // btnEdit
        // 
        btnEdit.Location = new Point(162, 500);
        btnEdit.Name = "btnEdit";
        btnEdit.Size = new Size(94, 29);
        btnEdit.TabIndex = 46;
        btnEdit.Text = "&Edit";
        btnEdit.UseVisualStyleBackColor = true;
        btnEdit.Click += btnEdit_Click;
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(46, 500);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(94, 29);
        btnAdd.TabIndex = 45;
        btnAdd.Text = "&Add";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // dgvProducts
        // 
        dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvProducts.BackgroundColor = SystemColors.GradientActiveCaption;
        dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvProducts.Location = new Point(46, 211);
        dgvProducts.Name = "dgvProducts";
        dgvProducts.ReadOnly = true;
        dgvProducts.RowHeadersWidth = 51;
        dgvProducts.Size = new Size(824, 261);
        dgvProducts.TabIndex = 44;
        dgvProducts.SelectionChanged += dgvProducts_SelectionChanged;
        // 
        // txtProdName
        // 
        txtProdName.Location = new Point(575, 103);
        txtProdName.Name = "txtProdName";
        txtProdName.ReadOnly = true;
        txtProdName.Size = new Size(201, 27);
        txtProdName.TabIndex = 53;
        txtProdName.TextChanged += txtProdName_TextChanged;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(454, 106);
        label1.Name = "label1";
        label1.Size = new Size(111, 20);
        label1.TabIndex = 52;
        label1.Text = "Product Name :";
        // 
        // txtProdId
        // 
        txtProdId.Location = new Point(141, 103);
        txtProdId.Name = "txtProdId";
        txtProdId.ReadOnly = true;
        txtProdId.Size = new Size(201, 27);
        txtProdId.TabIndex = 51;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(45, 106);
        label2.Name = "label2";
        label2.Size = new Size(86, 20);
        label2.TabIndex = 50;
        label2.Text = "Product ID :";
        // 
        // btnSearch
        // 
        btnSearch.Location = new Point(381, 500);
        btnSearch.Margin = new Padding(3, 4, 3, 4);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new Size(127, 31);
        btnSearch.TabIndex = 68;
        btnSearch.Text = "&Search";
        btnSearch.UseVisualStyleBackColor = true;
        btnSearch.Click += btnSearch_Click;
        // 
        // lblClearIcon
        // 
        lblClearIcon.AutoSize = true;
        lblClearIcon.Font = new Font("Segoe UI", 15F);
        lblClearIcon.Location = new Point(821, 155);
        lblClearIcon.Name = "lblClearIcon";
        lblClearIcon.Size = new Size(49, 35);
        lblClearIcon.TabIndex = 70;
        lblClearIcon.Text = "✖";
        lblClearIcon.Click += lblClearIcon_Click;
        // 
        // lblSearchIcon
        // 
        lblSearchIcon.AutoSize = true;
        lblSearchIcon.Font = new Font("Segoe UI", 15F);
        lblSearchIcon.Location = new Point(779, 155);
        lblSearchIcon.Name = "lblSearchIcon";
        lblSearchIcon.Size = new Size(49, 35);
        lblSearchIcon.TabIndex = 69;
        lblSearchIcon.Text = "🔍";
        lblSearchIcon.Click += lblSearchIcon_Click;
        // 
        // lblTableName
        // 
        lblTableName.AutoSize = true;
        lblTableName.Font = new Font("Segoe UI", 20F);
        lblTableName.Location = new Point(46, 39);
        lblTableName.Name = "lblTableName";
        lblTableName.Size = new Size(195, 46);
        lblTableName.TabIndex = 74;
        lblTableName.Text = "Table Name";
        // 
        // ucManageProducts
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.GradientInactiveCaption;
        Controls.Add(lblTableName);
        Controls.Add(lblClearIcon);
        Controls.Add(lblSearchIcon);
        Controls.Add(btnSearch);
        Controls.Add(txtProdName);
        Controls.Add(label1);
        Controls.Add(txtProdId);
        Controls.Add(label2);
        Controls.Add(btnDisc);
        Controls.Add(btnSave);
        Controls.Add(btnDelete);
        Controls.Add(btnEdit);
        Controls.Add(btnAdd);
        Controls.Add(dgvProducts);
        Name = "ucManageProducts";
        Size = new Size(914, 563);
        Load += ucManageProducts_Load_1;
        ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnDisc;
    private Button btnSave;
    private Button btnDelete;
    private Button btnEdit;
    private Button btnAdd;
    private DataGridView dgvProducts;
    private TextBox txtProdName;
    private Label label1;
    private TextBox txtProdId;
    private Label label2;
    private Button btnSearch;
    private Label lblClearIcon;
    private Label lblSearchIcon;
    private Label lblTableName;
}
