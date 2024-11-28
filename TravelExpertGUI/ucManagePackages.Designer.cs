namespace TravelExpertGUI;

partial class ucManagePackages
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
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        label5 = new Label();
        label6 = new Label();
        label7 = new Label();
        dgvPackages = new DataGridView();
        btnAdd = new Button();
        btnEdit = new Button();
        btnDelete = new Button();
        btnDiscard = new Button();
        btnSave = new Button();
        lblClearIcon = new Label();
        lblSearchIcon = new Label();
        btnSearch = new Button();
        txtPkgStartDate = new TextBox();
        txtPkgEndDate = new TextBox();
        txtPkgId = new TextBox();
        txtPkgName = new TextBox();
        txtPkgDesc = new TextBox();
        txtPkgBasePrice = new TextBox();
        txtPkgAgcyCom = new TextBox();
        ((System.ComponentModel.ISupportInitialize)dgvPackages).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(73, 51);
        label1.Name = "label1";
        label1.Size = new Size(83, 20);
        label1.TabIndex = 0;
        label1.Text = "Package Id:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(73, 87);
        label2.Name = "label2";
        label2.Size = new Size(110, 20);
        label2.TabIndex = 2;
        label2.Text = "Package Name:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(73, 127);
        label3.Name = "label3";
        label3.Size = new Size(137, 20);
        label3.TabIndex = 4;
        label3.Text = "Package Start Date:";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(73, 165);
        label4.Name = "label4";
        label4.Size = new Size(131, 20);
        label4.TabIndex = 6;
        label4.Text = "Package End Date:";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(73, 203);
        label5.Name = "label5";
        label5.Size = new Size(146, 20);
        label5.TabIndex = 8;
        label5.Text = "Package Description:";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(456, 55);
        label6.Name = "label6";
        label6.Size = new Size(137, 20);
        label6.TabIndex = 10;
        label6.Text = "Package Base Price:";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(456, 95);
        label7.Name = "label7";
        label7.Size = new Size(204, 20);
        label7.TabIndex = 12;
        label7.Text = "Package Agency Commission:";
        // 
        // dgvPackages
        // 
        dgvPackages.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvPackages.BackgroundColor = SystemColors.GradientActiveCaption;
        dgvPackages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvPackages.Location = new Point(49, 249);
        dgvPackages.Name = "dgvPackages";
        dgvPackages.RowHeadersWidth = 51;
        dgvPackages.Size = new Size(802, 236);
        dgvPackages.TabIndex = 14;
        dgvPackages.SelectionChanged += dgvPackages_SelectionChanged;
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(49, 507);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(79, 29);
        btnAdd.TabIndex = 15;
        btnAdd.Text = "&Add";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // btnEdit
        // 
        btnEdit.Location = new Point(157, 507);
        btnEdit.Name = "btnEdit";
        btnEdit.Size = new Size(79, 29);
        btnEdit.TabIndex = 16;
        btnEdit.Text = "&Edit";
        btnEdit.UseVisualStyleBackColor = true;
        btnEdit.Click += btnEdit_Click;
        // 
        // btnDelete
        // 
        btnDelete.ForeColor = Color.FromArgb(192, 0, 0);
        btnDelete.Location = new Point(242, 507);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(79, 29);
        btnDelete.TabIndex = 17;
        btnDelete.Text = "&Delete";
        btnDelete.UseVisualStyleBackColor = true;
        btnDelete.Click += btnDelete_Click;
        // 
        // btnDiscard
        // 
        btnDiscard.Enabled = false;
        btnDiscard.Location = new Point(517, 507);
        btnDiscard.Name = "btnDiscard";
        btnDiscard.Size = new Size(163, 29);
        btnDiscard.TabIndex = 58;
        btnDiscard.Text = "Discard Chan&ges";
        btnDiscard.UseVisualStyleBackColor = true;
        btnDiscard.Click += btnDiscard_Click;
        // 
        // btnSave
        // 
        btnSave.Enabled = false;
        btnSave.Location = new Point(687, 507);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(163, 29);
        btnSave.TabIndex = 57;
        btnSave.Text = "&Save Changes";
        btnSave.UseVisualStyleBackColor = true;
        btnSave.Click += btnSave_Click;
        // 
        // lblClearIcon
        // 
        lblClearIcon.AutoSize = true;
        lblClearIcon.Font = new Font("Segoe UI", 15F);
        lblClearIcon.Location = new Point(806, 203);
        lblClearIcon.Name = "lblClearIcon";
        lblClearIcon.Size = new Size(49, 35);
        lblClearIcon.TabIndex = 60;
        lblClearIcon.Text = "✖";
        lblClearIcon.Click += lblClearIcon_Click;
        // 
        // lblSearchIcon
        // 
        lblSearchIcon.AutoSize = true;
        lblSearchIcon.Font = new Font("Segoe UI", 15F);
        lblSearchIcon.Location = new Point(763, 203);
        lblSearchIcon.Name = "lblSearchIcon";
        lblSearchIcon.Size = new Size(49, 35);
        lblSearchIcon.TabIndex = 59;
        lblSearchIcon.Text = "🔍";
        lblSearchIcon.Click += lblSearchIcon_Click_1;
        // 
        // btnSearch
        // 
        btnSearch.Location = new Point(355, 507);
        btnSearch.Margin = new Padding(3, 4, 3, 4);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new Size(127, 31);
        btnSearch.TabIndex = 68;
        btnSearch.Text = "&Search";
        btnSearch.UseVisualStyleBackColor = true;
        btnSearch.Click += btnSearch_Click;
        // 
        // txtPkgStartDate
        // 
        txtPkgStartDate.Location = new Point(222, 124);
        txtPkgStartDate.Name = "txtPkgStartDate";
        txtPkgStartDate.ReadOnly = true;
        txtPkgStartDate.Size = new Size(125, 27);
        txtPkgStartDate.TabIndex = 69;
        // 
        // txtPkgEndDate
        // 
        txtPkgEndDate.Location = new Point(222, 162);
        txtPkgEndDate.Name = "txtPkgEndDate";
        txtPkgEndDate.ReadOnly = true;
        txtPkgEndDate.Size = new Size(125, 27);
        txtPkgEndDate.TabIndex = 70;
        // 
        // txtPkgId
        // 
        txtPkgId.Location = new Point(222, 48);
        txtPkgId.Name = "txtPkgId";
        txtPkgId.ReadOnly = true;
        txtPkgId.Size = new Size(125, 27);
        txtPkgId.TabIndex = 71;
        // 
        // txtPkgName
        // 
        txtPkgName.Location = new Point(222, 84);
        txtPkgName.Name = "txtPkgName";
        txtPkgName.ReadOnly = true;
        txtPkgName.Size = new Size(125, 27);
        txtPkgName.TabIndex = 72;
        // 
        // txtPkgDesc
        // 
        txtPkgDesc.Location = new Point(225, 200);
        txtPkgDesc.Name = "txtPkgDesc";
        txtPkgDesc.ReadOnly = true;
        txtPkgDesc.Size = new Size(125, 27);
        txtPkgDesc.TabIndex = 73;
        // 
        // txtPkgBasePrice
        // 
        txtPkgBasePrice.Location = new Point(677, 48);
        txtPkgBasePrice.Name = "txtPkgBasePrice";
        txtPkgBasePrice.ReadOnly = true;
        txtPkgBasePrice.Size = new Size(125, 27);
        txtPkgBasePrice.TabIndex = 74;
        // 
        // txtPkgAgcyCom
        // 
        txtPkgAgcyCom.Location = new Point(677, 92);
        txtPkgAgcyCom.Name = "txtPkgAgcyCom";
        txtPkgAgcyCom.ReadOnly = true;
        txtPkgAgcyCom.Size = new Size(125, 27);
        txtPkgAgcyCom.TabIndex = 75;
        // 
        // ucManagePackages
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.GradientInactiveCaption;
        Controls.Add(txtPkgAgcyCom);
        Controls.Add(txtPkgBasePrice);
        Controls.Add(txtPkgDesc);
        Controls.Add(txtPkgName);
        Controls.Add(txtPkgId);
        Controls.Add(txtPkgEndDate);
        Controls.Add(txtPkgStartDate);
        Controls.Add(btnSearch);
        Controls.Add(lblClearIcon);
        Controls.Add(lblSearchIcon);
        Controls.Add(btnDiscard);
        Controls.Add(btnSave);
        Controls.Add(btnDelete);
        Controls.Add(btnEdit);
        Controls.Add(btnAdd);
        Controls.Add(dgvPackages);
        Controls.Add(label7);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Name = "ucManagePackages";
        Size = new Size(914, 563);
        Load += ucManagePackages_Load;
        ((System.ComponentModel.ISupportInitialize)dgvPackages).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private Label label7;
    private DataGridView dgvPackages;
    private Button btnAdd;
    private Button btnEdit;
    private Button btnDelete;
    private Button btnDiscard;
    private Button btnSave;
    private Label lblClearIcon;
    private Label lblSearchIcon;
    private Button btnSearch;
    private TextBox txtPkgStartDate;
    private TextBox txtPkgEndDate;
    private TextBox txtPkgId;
    private TextBox txtPkgName;
    private TextBox txtPkgDesc;
    private TextBox txtPkgBasePrice;
    private TextBox txtPkgAgcyCom;
}
