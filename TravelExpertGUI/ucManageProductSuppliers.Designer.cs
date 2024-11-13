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
        dgvAgents = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dgvAgents).BeginInit();
        SuspendLayout();
        // 
        // btnDisc
        // 
        btnDisc.Enabled = false;
        btnDisc.Location = new Point(415, 377);
        btnDisc.Margin = new Padding(3, 2, 3, 2);
        btnDisc.Name = "btnDisc";
        btnDisc.Size = new Size(169, 22);
        btnDisc.TabIndex = 47;
        btnDisc.Text = "Discard Chan&ges";
        btnDisc.UseVisualStyleBackColor = true;
        // 
        // btnSave
        // 
        btnSave.Enabled = false;
        btnSave.Location = new Point(589, 377);
        btnSave.Margin = new Padding(3, 2, 3, 2);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(169, 22);
        btnSave.TabIndex = 46;
        btnSave.Text = "Save Changes";
        btnSave.UseVisualStyleBackColor = true;
        // 
        // btnDelete
        // 
        btnDelete.Location = new Point(284, 377);
        btnDelete.Margin = new Padding(3, 2, 3, 2);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(82, 22);
        btnDelete.TabIndex = 45;
        btnDelete.Text = "&Delete";
        btnDelete.UseVisualStyleBackColor = true;
        // 
        // btnEdit
        // 
        btnEdit.Location = new Point(196, 377);
        btnEdit.Margin = new Padding(3, 2, 3, 2);
        btnEdit.Name = "btnEdit";
        btnEdit.Size = new Size(82, 22);
        btnEdit.TabIndex = 44;
        btnEdit.Text = "&Edit";
        btnEdit.UseVisualStyleBackColor = true;
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(54, 377);
        btnAdd.Margin = new Padding(3, 2, 3, 2);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(82, 22);
        btnAdd.TabIndex = 43;
        btnAdd.Text = "&Add";
        btnAdd.UseVisualStyleBackColor = true;
        // 
        // dgvAgents
        // 
        dgvAgents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvAgents.Location = new Point(50, 184);
        dgvAgents.Margin = new Padding(3, 2, 3, 2);
        dgvAgents.Name = "dgvAgents";
        dgvAgents.RowHeadersWidth = 51;
        dgvAgents.Size = new Size(708, 177);
        dgvAgents.TabIndex = 42;
        // 
        // ucManageProductSuppliers
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(btnDisc);
        Controls.Add(btnSave);
        Controls.Add(btnDelete);
        Controls.Add(btnEdit);
        Controls.Add(btnAdd);
        Controls.Add(dgvAgents);
        Name = "ucManageProductSuppliers";
        Size = new Size(800, 428);
        ((System.ComponentModel.ISupportInitialize)dgvAgents).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Button btnDisc;
    private Button btnSave;
    private Button btnDelete;
    private Button btnEdit;
    private Button btnAdd;
    private DataGridView dgvAgents;
}
