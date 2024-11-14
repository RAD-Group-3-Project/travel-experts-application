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
        txtPkgId = new TextBox();
        txtPkgName = new TextBox();
        label2 = new Label();
        txtPkgStartDate = new TextBox();
        label3 = new Label();
        txtPkgEndDate = new TextBox();
        label4 = new Label();
        txtPkgDesc = new TextBox();
        label5 = new Label();
        label6 = new Label();
        txtPkgBasePrice = new TextBox();
        label7 = new Label();
        txtPkgAgcyCom = new TextBox();
        dataGridView1 = new DataGridView();
        btnAdd = new Button();
        btnEdit = new Button();
        btnDelete = new Button();
        btnDiscard = new Button();
        btnSave = new Button();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(64, 38);
        label1.Name = "label1";
        label1.Size = new Size(67, 15);
        label1.TabIndex = 0;
        label1.Text = "Package Id:";
        // 
        // txtPkgId
        // 
        txtPkgId.BackColor = SystemColors.Control;
        txtPkgId.Location = new Point(194, 35);
        txtPkgId.Margin = new Padding(3, 2, 3, 2);
        txtPkgId.Name = "txtPkgId";
        txtPkgId.Size = new Size(110, 23);
        txtPkgId.TabIndex = 1;
        // 
        // txtPkgName
        // 
        txtPkgName.BackColor = SystemColors.Control;
        txtPkgName.Location = new Point(194, 63);
        txtPkgName.Margin = new Padding(3, 2, 3, 2);
        txtPkgName.Name = "txtPkgName";
        txtPkgName.Size = new Size(110, 23);
        txtPkgName.TabIndex = 3;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(64, 65);
        label2.Name = "label2";
        label2.Size = new Size(89, 15);
        label2.TabIndex = 2;
        label2.Text = "Package Name:";
        // 
        // txtPkgStartDate
        // 
        txtPkgStartDate.BackColor = SystemColors.Control;
        txtPkgStartDate.Location = new Point(194, 91);
        txtPkgStartDate.Margin = new Padding(3, 2, 3, 2);
        txtPkgStartDate.Name = "txtPkgStartDate";
        txtPkgStartDate.Size = new Size(110, 23);
        txtPkgStartDate.TabIndex = 5;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(64, 95);
        label3.Name = "label3";
        label3.Size = new Size(108, 15);
        label3.TabIndex = 4;
        label3.Text = "Package Start Date:";
        // 
        // txtPkgEndDate
        // 
        txtPkgEndDate.BackColor = SystemColors.Control;
        txtPkgEndDate.Location = new Point(194, 119);
        txtPkgEndDate.Margin = new Padding(3, 2, 3, 2);
        txtPkgEndDate.Name = "txtPkgEndDate";
        txtPkgEndDate.Size = new Size(110, 23);
        txtPkgEndDate.TabIndex = 7;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(64, 124);
        label4.Name = "label4";
        label4.Size = new Size(104, 15);
        label4.TabIndex = 6;
        label4.Text = "Package End Date:";
        // 
        // txtPkgDesc
        // 
        txtPkgDesc.BackColor = SystemColors.Control;
        txtPkgDesc.Location = new Point(194, 147);
        txtPkgDesc.Margin = new Padding(3, 2, 3, 2);
        txtPkgDesc.Name = "txtPkgDesc";
        txtPkgDesc.Size = new Size(110, 23);
        txtPkgDesc.TabIndex = 9;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(64, 152);
        label5.Name = "label5";
        label5.Size = new Size(117, 15);
        label5.TabIndex = 8;
        label5.Text = "Package Description:";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(399, 41);
        label6.Name = "label6";
        label6.Size = new Size(110, 15);
        label6.TabIndex = 10;
        label6.Text = "Package Base Price:";
        // 
        // txtPkgBasePrice
        // 
        txtPkgBasePrice.BackColor = SystemColors.Control;
        txtPkgBasePrice.Location = new Point(582, 38);
        txtPkgBasePrice.Margin = new Padding(3, 2, 3, 2);
        txtPkgBasePrice.Name = "txtPkgBasePrice";
        txtPkgBasePrice.Size = new Size(110, 23);
        txtPkgBasePrice.TabIndex = 11;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(399, 71);
        label7.Name = "label7";
        label7.Size = new Size(167, 15);
        label7.TabIndex = 12;
        label7.Text = "Package Agency Commission:";
        // 
        // txtPkgAgcyCom
        // 
        txtPkgAgcyCom.BackColor = SystemColors.Control;
        txtPkgAgcyCom.Location = new Point(582, 65);
        txtPkgAgcyCom.Margin = new Padding(3, 2, 3, 2);
        txtPkgAgcyCom.Name = "txtPkgAgcyCom";
        txtPkgAgcyCom.Size = new Size(110, 23);
        txtPkgAgcyCom.TabIndex = 13;
        // 
        // dataGridView1
        // 
        dataGridView1.BackgroundColor = SystemColors.GradientActiveCaption;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(43, 187);
        dataGridView1.Margin = new Padding(3, 2, 3, 2);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.Size = new Size(708, 189);
        dataGridView1.TabIndex = 14;
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(43, 380);
        btnAdd.Margin = new Padding(3, 2, 3, 2);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(82, 22);
        btnAdd.TabIndex = 15;
        btnAdd.Text = "&Add";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // btnEdit
        // 
        btnEdit.Location = new Point(156, 380);
        btnEdit.Margin = new Padding(3, 2, 3, 2);
        btnEdit.Name = "btnEdit";
        btnEdit.Size = new Size(82, 22);
        btnEdit.TabIndex = 16;
        btnEdit.Text = "&Edit";
        btnEdit.UseVisualStyleBackColor = true;
        btnEdit.Click += btnEdit_Click;
        // 
        // btnDelete
        // 
        btnDelete.Location = new Point(269, 380);
        btnDelete.Margin = new Padding(3, 2, 3, 2);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(82, 22);
        btnDelete.TabIndex = 17;
        btnDelete.Text = "&Delete";
        btnDelete.UseVisualStyleBackColor = true;
        btnDelete.Click += btnDelete_Click;
        // 
        // btnDiscard
        // 
        btnDiscard.Enabled = false;
        btnDiscard.Location = new Point(382, 380);
        btnDiscard.Margin = new Padding(3, 2, 3, 2);
        btnDiscard.Name = "btnDiscard";
        btnDiscard.Size = new Size(169, 22);
        btnDiscard.TabIndex = 58;
        btnDiscard.Text = "Discard Chan&ges";
        btnDiscard.UseVisualStyleBackColor = true;
        btnDiscard.Click += btnDiscard_Click;
        // 
        // btnSave
        // 
        btnSave.Enabled = false;
        btnSave.Location = new Point(582, 380);
        btnSave.Margin = new Padding(3, 2, 3, 2);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(169, 22);
        btnSave.TabIndex = 57;
        btnSave.Text = "&Save Changes";
        btnSave.UseVisualStyleBackColor = true;
        btnSave.Click += btnSave_Click;
        // 
        // ucManagePackages
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.GradientInactiveCaption;
        Controls.Add(btnDiscard);
        Controls.Add(btnSave);
        Controls.Add(btnDelete);
        Controls.Add(btnEdit);
        Controls.Add(btnAdd);
        Controls.Add(dataGridView1);
        Controls.Add(txtPkgAgcyCom);
        Controls.Add(label7);
        Controls.Add(txtPkgBasePrice);
        Controls.Add(label6);
        Controls.Add(txtPkgDesc);
        Controls.Add(label5);
        Controls.Add(txtPkgEndDate);
        Controls.Add(label4);
        Controls.Add(txtPkgStartDate);
        Controls.Add(label3);
        Controls.Add(txtPkgName);
        Controls.Add(label2);
        Controls.Add(txtPkgId);
        Controls.Add(label1);
        Margin = new Padding(3, 2, 3, 2);
        Name = "ucManagePackages";
        Size = new Size(795, 409);
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox txtPkgId;
    private TextBox txtPkgName;
    private Label label2;
    private TextBox txtPkgStartDate;
    private Label label3;
    private TextBox txtPkgEndDate;
    private Label label4;
    private TextBox txtPkgDesc;
    private Label label5;
    private Label label6;
    private TextBox txtPkgBasePrice;
    private Label label7;
    private TextBox txtPkgAgcyCom;
    private DataGridView dataGridView1;
    private Button btnAdd;
    private Button btnEdit;
    private Button btnDelete;
    private Button btnDiscard;
    private Button btnSave;
}
