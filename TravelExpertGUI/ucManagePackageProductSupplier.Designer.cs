namespace TravelExpertGUI
{
    partial class ucManagePackageProductSupplier
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            txtPackageProductSupplierId = new TextBox();
            lblPackageProductSupplierID = new Label();
            lblPackageID = new Label();
            lblProductSupplierID = new Label();
            dgvPackageProductSupplier = new DataGridView();
            btnDisc = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            cmbPackageID = new ComboBox();
            cmbProductSupplierID = new ComboBox();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPackageProductSupplier).BeginInit();
            SuspendLayout();
            // 
            // txtPackageProductSupplierId
            // 
            txtPackageProductSupplierId.BackColor = SystemColors.Control;
            txtPackageProductSupplierId.Location = new Point(251, 64);
            txtPackageProductSupplierId.Name = "txtPackageProductSupplierId";
            txtPackageProductSupplierId.Size = new Size(100, 23);
            txtPackageProductSupplierId.TabIndex = 51;
            // 
            // lblPackageProductSupplierID
            // 
            lblPackageProductSupplierID.AutoSize = true;
            lblPackageProductSupplierID.Location = new Point(71, 67);
            lblPackageProductSupplierID.Name = "lblPackageProductSupplierID";
            lblPackageProductSupplierID.Size = new Size(159, 15);
            lblPackageProductSupplierID.TabIndex = 50;
            lblPackageProductSupplierID.Text = "Package Product Supplier ID:";
            // 
            // lblPackageID
            // 
            lblPackageID.AutoSize = true;
            lblPackageID.Location = new Point(162, 97);
            lblPackageID.Name = "lblPackageID";
            lblPackageID.Size = new Size(68, 15);
            lblPackageID.TabIndex = 52;
            lblPackageID.Text = "Package ID:";
            // 
            // lblProductSupplierID
            // 
            lblProductSupplierID.AutoSize = true;
            lblProductSupplierID.Location = new Point(118, 130);
            lblProductSupplierID.Name = "lblProductSupplierID";
            lblProductSupplierID.Size = new Size(112, 15);
            lblProductSupplierID.TabIndex = 54;
            lblProductSupplierID.Text = "Product Supplier ID:";
            // 
            // dgvPackageProductSupplier
            // 
            dgvPackageProductSupplier.BackgroundColor = SystemColors.GradientActiveCaption;
            dgvPackageProductSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPackageProductSupplier.Location = new Point(50, 179);
            dgvPackageProductSupplier.Name = "dgvPackageProductSupplier";
            dgvPackageProductSupplier.RowHeadersWidth = 51;
            dgvPackageProductSupplier.Size = new Size(702, 177);
            dgvPackageProductSupplier.TabIndex = 57;
            // 
            // btnDisc
            // 
            btnDisc.Enabled = false;
            btnDisc.Location = new Point(383, 377);
            btnDisc.Margin = new Padding(3, 2, 3, 2);
            btnDisc.Name = "btnDisc";
            btnDisc.Size = new Size(107, 22);
            btnDisc.TabIndex = 62;
            btnDisc.Text = "Discard Chan&ges";
            btnDisc.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Location = new Point(532, 377);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(107, 22);
            btnSave.TabIndex = 61;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.ForeColor = Color.FromArgb(192, 0, 0);
            btnDelete.Location = new Point(272, 378);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(69, 22);
            btnDelete.TabIndex = 60;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(161, 377);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(69, 22);
            btnEdit.TabIndex = 59;
            btnEdit.Text = "&Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(50, 377);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(69, 22);
            btnAdd.TabIndex = 58;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // cmbPackageID
            // 
            cmbPackageID.BackColor = SystemColors.Control;
            cmbPackageID.FormattingEnabled = true;
            cmbPackageID.Location = new Point(251, 97);
            cmbPackageID.Margin = new Padding(3, 2, 3, 2);
            cmbPackageID.Name = "cmbPackageID";
            cmbPackageID.Size = new Size(100, 23);
            cmbPackageID.TabIndex = 63;
            // 
            // cmbProductSupplierID
            // 
            cmbProductSupplierID.BackColor = SystemColors.Control;
            cmbProductSupplierID.FormattingEnabled = true;
            cmbProductSupplierID.Location = new Point(251, 130);
            cmbProductSupplierID.Margin = new Padding(3, 2, 3, 2);
            cmbProductSupplierID.Name = "cmbProductSupplierID";
            cmbProductSupplierID.Size = new Size(100, 23);
            cmbProductSupplierID.TabIndex = 64;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(681, 377);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(69, 22);
            btnExit.TabIndex = 65;
            btnExit.Text = "&Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // ucManagePackageProductSupplier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            Controls.Add(btnExit);
            Controls.Add(cmbProductSupplierID);
            Controls.Add(cmbPackageID);
            Controls.Add(btnDisc);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dgvPackageProductSupplier);
            Controls.Add(lblProductSupplierID);
            Controls.Add(lblPackageID);
            Controls.Add(txtPackageProductSupplierId);
            Controls.Add(lblPackageProductSupplierID);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ucManagePackageProductSupplier";
            Size = new Size(800, 428);
            Load += ucManagePackageProductSupplier_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPackageProductSupplier).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPackageProductSupplierId;
        private Label lblPackageProductSupplierID;
        private Label lblPackageID;
        private Label lblProductSupplierID;
        private DataGridView dgvPackageProductSupplier;
        private Button btnDisc;
        private Button btnSave;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private ComboBox cmbPackageID;
        private ComboBox cmbProductSupplierID;
        private Button btnExit;
    }
}
