namespace TravelExpertGUI;

partial class ucManageAgents
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
        btnDelete = new Button();
        btnEdit = new Button();
        btnAdd = new Button();
        dgvAgents = new DataGridView();
        label7 = new Label();
        txtAgntPosition = new TextBox();
        label6 = new Label();
        txtAgntEmail = new TextBox();
        label5 = new Label();
        txtAgntBusPhone = new TextBox();
        label4 = new Label();
        txtAgntLName = new TextBox();
        label3 = new Label();
        txtAgntFName = new TextBox();
        label2 = new Label();
        txtAgntId = new TextBox();
        label1 = new Label();
        btnSave = new Button();
        cboAgency = new ComboBox();
        txtMiddleInit = new TextBox();
        lblMid = new Label();
        btnDisc = new Button();
        ((System.ComponentModel.ISupportInitialize)dgvAgents).BeginInit();
        SuspendLayout();
        // 
        // btnDelete
        // 
        btnDelete.ForeColor = Color.FromArgb(192, 0, 0);
        btnDelete.Location = new Point(305, 500);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(94, 29);
        btnDelete.TabIndex = 35;
        btnDelete.Text = "&Delete";
        btnDelete.UseVisualStyleBackColor = true;
        btnDelete.Click += btnDelete_Click;
        // 
        // btnEdit
        // 
        btnEdit.Location = new Point(196, 500);
        btnEdit.Name = "btnEdit";
        btnEdit.Size = new Size(94, 29);
        btnEdit.TabIndex = 34;
        btnEdit.Text = "&Edit";
        btnEdit.UseVisualStyleBackColor = true;
        btnEdit.Click += btnEdit_Click;
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(51, 500);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(94, 29);
        btnAdd.TabIndex = 33;
        btnAdd.Text = "&Add";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // dgvAgents
        // 
        dgvAgents.BackgroundColor = SystemColors.GradientActiveCaption;
        dgvAgents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvAgents.Location = new Point(49, 243);
        dgvAgents.Name = "dgvAgents";
        dgvAgents.RowHeadersWidth = 51;
        dgvAgents.Size = new Size(806, 236);
        dgvAgents.TabIndex = 32;
        dgvAgents.SelectionChanged += dgvAgents_SelectionChanged;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(513, 157);
        label7.Name = "label7";
        label7.Size = new Size(65, 20);
        label7.TabIndex = 30;
        label7.Text = "Agency :";
        // 
        // txtAgntPosition
        // 
        txtAgntPosition.Location = new Point(595, 116);
        txtAgntPosition.Name = "txtAgntPosition";
        txtAgntPosition.ReadOnly = true;
        txtAgntPosition.Size = new Size(217, 27);
        txtAgntPosition.TabIndex = 6;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(513, 115);
        label6.Name = "label6";
        label6.Size = new Size(68, 20);
        label6.TabIndex = 28;
        label6.Text = "Position :";
        // 
        // txtAgntEmail
        // 
        txtAgntEmail.Location = new Point(595, 79);
        txtAgntEmail.Name = "txtAgntEmail";
        txtAgntEmail.ReadOnly = true;
        txtAgntEmail.Size = new Size(217, 27);
        txtAgntEmail.TabIndex = 5;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(526, 79);
        label5.Name = "label5";
        label5.Size = new Size(53, 20);
        label5.TabIndex = 26;
        label5.Text = "Email :";
        // 
        // txtAgntBusPhone
        // 
        txtAgntBusPhone.Location = new Point(595, 41);
        txtAgntBusPhone.Name = "txtAgntBusPhone";
        txtAgntBusPhone.ReadOnly = true;
        txtAgntBusPhone.Size = new Size(217, 27);
        txtAgntBusPhone.TabIndex = 4;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(469, 52);
        label4.Name = "label4";
        label4.Size = new Size(116, 20);
        label4.TabIndex = 24;
        label4.Text = "Business Phone :";
        // 
        // txtAgntLName
        // 
        txtAgntLName.Location = new Point(219, 153);
        txtAgntLName.Name = "txtAgntLName";
        txtAgntLName.ReadOnly = true;
        txtAgntLName.Size = new Size(217, 27);
        txtAgntLName.TabIndex = 3;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(101, 157);
        label3.Name = "label3";
        label3.Size = new Size(86, 20);
        label3.TabIndex = 22;
        label3.Text = "Last Name :";
        // 
        // txtAgntFName
        // 
        txtAgntFName.Location = new Point(219, 79);
        txtAgntFName.Name = "txtAgntFName";
        txtAgntFName.ReadOnly = true;
        txtAgntFName.Size = new Size(217, 27);
        txtAgntFName.TabIndex = 1;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(101, 84);
        label2.Name = "label2";
        label2.Size = new Size(87, 20);
        label2.TabIndex = 20;
        label2.Text = "First Name :";
        // 
        // txtAgntId
        // 
        txtAgntId.Location = new Point(219, 41);
        txtAgntId.Name = "txtAgntId";
        txtAgntId.ReadOnly = true;
        txtAgntId.Size = new Size(217, 27);
        txtAgntId.TabIndex = 0;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(113, 44);
        label1.Name = "label1";
        label1.Size = new Size(73, 20);
        label1.TabIndex = 18;
        label1.Text = "Agent Id :";
        // 
        // btnSave
        // 
        btnSave.Enabled = false;
        btnSave.Location = new Point(666, 500);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(189, 29);
        btnSave.TabIndex = 8;
        btnSave.Text = "Save Changes";
        btnSave.UseVisualStyleBackColor = true;
        btnSave.Click += btnSave_Click;
        // 
        // cboAgency
        // 
        cboAgency.BackColor = SystemColors.Control;
        cboAgency.Enabled = false;
        cboAgency.FormattingEnabled = true;
        cboAgency.Location = new Point(595, 153);
        cboAgency.Name = "cboAgency";
        cboAgency.Size = new Size(217, 28);
        cboAgency.TabIndex = 7;
        // 
        // txtMiddleInit
        // 
        txtMiddleInit.Location = new Point(219, 116);
        txtMiddleInit.Name = "txtMiddleInit";
        txtMiddleInit.ReadOnly = true;
        txtMiddleInit.Size = new Size(217, 27);
        txtMiddleInit.TabIndex = 2;
        // 
        // lblMid
        // 
        lblMid.AutoSize = true;
        lblMid.Location = new Point(83, 121);
        lblMid.Name = "lblMid";
        lblMid.Size = new Size(104, 20);
        lblMid.TabIndex = 40;
        lblMid.Text = "Middle Initial :";
        // 
        // btnDisc
        // 
        btnDisc.Enabled = false;
        btnDisc.Location = new Point(459, 500);
        btnDisc.Name = "btnDisc";
        btnDisc.Size = new Size(189, 29);
        btnDisc.TabIndex = 9;
        btnDisc.Text = "Discard Chan&ges";
        btnDisc.UseVisualStyleBackColor = true;
        btnDisc.Click += btnDisc_Click;
        // 
        // ucManageAgents
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.GradientInactiveCaption;
        Controls.Add(btnDisc);
        Controls.Add(lblMid);
        Controls.Add(txtMiddleInit);
        Controls.Add(cboAgency);
        Controls.Add(btnSave);
        Controls.Add(btnDelete);
        Controls.Add(btnEdit);
        Controls.Add(btnAdd);
        Controls.Add(dgvAgents);
        Controls.Add(label7);
        Controls.Add(txtAgntPosition);
        Controls.Add(label6);
        Controls.Add(txtAgntEmail);
        Controls.Add(label5);
        Controls.Add(txtAgntBusPhone);
        Controls.Add(label4);
        Controls.Add(txtAgntLName);
        Controls.Add(label3);
        Controls.Add(txtAgntFName);
        Controls.Add(label2);
        Controls.Add(txtAgntId);
        Controls.Add(label1);
        ForeColor = SystemColors.ControlText;
        Name = "ucManageAgents";
        Size = new Size(914, 562);
        Load += ucManageAgents_Load;
        ((System.ComponentModel.ISupportInitialize)dgvAgents).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnDelete;
    private Button btnEdit;
    private Button btnAdd;
    private DataGridView dgvAgents;
    private Label label7;
    private TextBox txtAgntPosition;
    private Label label6;
    private TextBox txtAgntEmail;
    private Label label5;
    private TextBox txtAgntBusPhone;
    private Label label4;
    private TextBox txtAgntLName;
    private Label label3;
    private TextBox txtAgntFName;
    private Label label2;
    private TextBox txtAgntId;
    private Label label1;
    private Button btnSave;
    private ComboBox cboAgency;
    private TextBox txtMiddleInit;
    private Label lblMid;
    private Button btnDisc;
}
