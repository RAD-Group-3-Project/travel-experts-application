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
            ((System.ComponentModel.ISupportInitialize)dgvPackageProductSupplier).BeginInit();
            SuspendLayout();
            // 
            // txtPackageProductSupplierId
            // 
            txtPackageProductSupplierId.Location = new Point(287, 86);
            txtPackageProductSupplierId.Margin = new Padding(3, 4, 3, 4);
            txtPackageProductSupplierId.Name = "txtPackageProductSupplierId";
            txtPackageProductSupplierId.Size = new Size(114, 27);
            txtPackageProductSupplierId.TabIndex = 51;
            // 
            // lblPackageProductSupplierID
            // 
            lblPackageProductSupplierID.AutoSize = true;
            lblPackageProductSupplierID.Location = new Point(81, 89);
            lblPackageProductSupplierID.Name = "lblPackageProductSupplierID";
            lblPackageProductSupplierID.Size = new Size(199, 20);
            lblPackageProductSupplierID.TabIndex = 50;
            lblPackageProductSupplierID.Text = "Package Product Supplier ID:";
            // 
            // lblPackageID
            // 
            lblPackageID.AutoSize = true;
            lblPackageID.Location = new Point(195, 133);
            lblPackageID.Name = "lblPackageID";
            lblPackageID.Size = new Size(85, 20);
            lblPackageID.TabIndex = 52;
            lblPackageID.Text = "Package ID:";
            // 
            // lblProductSupplierID
            // 
            lblProductSupplierID.AutoSize = true;
            lblProductSupplierID.Location = new Point(140, 173);
            lblProductSupplierID.Name = "lblProductSupplierID";
            lblProductSupplierID.Size = new Size(141, 20);
            lblProductSupplierID.TabIndex = 54;
            lblProductSupplierID.Text = "Product Supplier ID:";
            // 
            // dgvPackageProductSupplier
            // 
            dgvPackageProductSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPackageProductSupplier.Location = new Point(62, 239);
            dgvPackageProductSupplier.Margin = new Padding(3, 4, 3, 4);
            dgvPackageProductSupplier.Name = "dgvPackageProductSupplier";
            dgvPackageProductSupplier.RowHeadersWidth = 51;
            dgvPackageProductSupplier.Size = new Size(809, 236);
            dgvPackageProductSupplier.TabIndex = 57;
            dgvPackageProductSupplier.SelectionChanged += dgvPackageProductSupplier_SelectionChanged;
            // 
            // btnDisc
            // 
            btnDisc.Enabled = false;
            btnDisc.Location = new Point(474, 503);
            btnDisc.Name = "btnDisc";
            btnDisc.Size = new Size(193, 29);
            btnDisc.TabIndex = 62;
            btnDisc.Text = "Discard Chan&ges";
            btnDisc.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Location = new Point(673, 503);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(193, 29);
            btnSave.TabIndex = 61;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(325, 504);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 60;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(224, 503);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 59;
            btnEdit.Text = "&Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(62, 503);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 58;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cmbPackageID
            // 
            cmbPackageID.FormattingEnabled = true;
            cmbPackageID.Location = new Point(287, 130);
            cmbPackageID.Name = "cmbPackageID";
            cmbPackageID.Size = new Size(151, 28);
            cmbPackageID.TabIndex = 63;
            // 
            // cmbProductSupplierID
            // 
            cmbProductSupplierID.FormattingEnabled = true;
            cmbProductSupplierID.Location = new Point(287, 173);
            cmbProductSupplierID.Name = "cmbProductSupplierID";
            cmbProductSupplierID.Size = new Size(151, 28);
            cmbProductSupplierID.TabIndex = 64;
            // 
            // ucManagePackageProductSupplier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Name = "ucManagePackageProductSupplier";
            Size = new Size(914, 571);
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
    }
}
