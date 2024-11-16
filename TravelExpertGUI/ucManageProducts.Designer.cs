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
        ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
        SuspendLayout();
        // 
        // btnDisc
        // 
        btnDisc.Enabled = false;
        btnDisc.Location = new Point(476, 500);
        btnDisc.Name = "btnDisc";
        btnDisc.Size = new Size(189, 29);
        btnDisc.TabIndex = 43;
        btnDisc.Text = "Discard Chan&ges";
        btnDisc.UseVisualStyleBackColor = true;
        // 
        // btnSave
        // 
        btnSave.Enabled = false;
        btnSave.Location = new Point(681, 500);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(189, 29);
        btnSave.TabIndex = 42;
        btnSave.Text = "Save Changes";
        btnSave.UseVisualStyleBackColor = true;
        // 
        // btnDelete
        // 
        btnDelete.ForeColor = Color.FromArgb(192, 0, 0);
        btnDelete.Location = new Point(313, 500);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(94, 29);
        btnDelete.TabIndex = 47;
        btnDelete.Text = "&Delete";
        btnDelete.UseVisualStyleBackColor = true;
        // 
        // btnEdit
        // 
        btnEdit.Location = new Point(201, 500);
        btnEdit.Name = "btnEdit";
        btnEdit.Size = new Size(94, 29);
        btnEdit.TabIndex = 46;
        btnEdit.Text = "&Edit";
        btnEdit.UseVisualStyleBackColor = true;
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(46, 500);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(94, 29);
        btnAdd.TabIndex = 45;
        btnAdd.Text = "&Add";
        btnAdd.UseVisualStyleBackColor = true;
        // 
        // dgvSuppliers
        // 
        dgvSuppliers.BackgroundColor = SystemColors.GradientActiveCaption;
        dgvSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvSuppliers.Location = new Point(46, 137);
        dgvSuppliers.Name = "dgvSuppliers";
        dgvSuppliers.RowHeadersWidth = 51;
        dgvSuppliers.Size = new Size(824, 335);
        dgvSuppliers.TabIndex = 44;
        // 
        // txtSupName
        // 
        txtSupName.Location = new Point(615, 69);
        txtSupName.Name = "txtSupName";
        txtSupName.ReadOnly = true;
        txtSupName.Size = new Size(201, 27);
        txtSupName.TabIndex = 53;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(494, 72);
        label1.Name = "label1";
        label1.Size = new Size(111, 20);
        label1.TabIndex = 52;
        label1.Text = "Product Name :";
        // 
        // txtSupID
        // 
        txtSupID.Location = new Point(181, 69);
        txtSupID.Name = "txtSupID";
        txtSupID.ReadOnly = true;
        txtSupID.Size = new Size(201, 27);
        txtSupID.TabIndex = 51;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(85, 72);
        label2.Name = "label2";
        label2.Size = new Size(86, 20);
        label2.TabIndex = 50;
        label2.Text = "Product ID :";
        // 
        // ucManageProducts
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.GradientInactiveCaption;
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
        Name = "ucManageProducts";
        Size = new Size(914, 562);
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
}
