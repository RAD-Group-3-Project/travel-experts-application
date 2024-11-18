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
            lblClearIcon = new Label();
            lblSearchIcon = new Label();
            btnSearch = new Button();
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
            dgvPackageProductSupplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPackageProductSupplier.BackgroundColor = SystemColors.GradientActiveCaption;
            dgvPackageProductSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPackageProductSupplier.Location = new Point(50, 179);
            dgvPackageProductSupplier.Name = "dgvPackageProductSupplier";
            dgvPackageProductSupplier.RowHeadersWidth = 51;
            dgvPackageProductSupplier.Size = new Size(702, 177);
            dgvPackageProductSupplier.TabIndex = 57;
            dgvPackageProductSupplier.SelectionChanged += dgvPackageProductSupplier_SelectionChanged;
            // 
            // btnDisc
            // 
            btnDisc.Enabled = false;
            btnDisc.Location = new Point(459, 377);
            btnDisc.Margin = new Padding(3, 2, 3, 2);
            btnDisc.Name = "btnDisc";
            btnDisc.Size = new Size(143, 22);
            btnDisc.TabIndex = 62;
            btnDisc.Text = "Discard Chan&ges";
            btnDisc.UseVisualStyleBackColor = true;
            btnDisc.Click += btnDisc_Click;
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Location = new Point(608, 378);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(143, 22);
            btnSave.TabIndex = 61;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.ForeColor = Color.FromArgb(192, 0, 0);
            btnDelete.Location = new Point(218, 378);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(69, 22);
            btnDelete.TabIndex = 60;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(143, 378);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(69, 22);
            btnEdit.TabIndex = 59;
            btnEdit.Text = "&Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(50, 378);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(69, 22);
            btnAdd.TabIndex = 58;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
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
            // lblClearIcon
            // 
            lblClearIcon.AutoSize = true;
            lblClearIcon.Font = new Font("Segoe UI", 15F);
            lblClearIcon.Location = new Point(712, 148);
            lblClearIcon.Name = "lblClearIcon";
            lblClearIcon.Size = new Size(39, 28);
            lblClearIcon.TabIndex = 66;
            lblClearIcon.Text = "✖";
            lblClearIcon.Click += lblClearIcon_Click;
            lblClearIcon.MouseLeave += lblClearIcon_MouseLeave;
            lblClearIcon.MouseHover += lblClearIcon_MouseHover;
            // 
            // lblSearchIcon
            // 
            lblSearchIcon.AutoSize = true;
            lblSearchIcon.Font = new Font("Segoe UI", 15F);
            lblSearchIcon.Location = new Point(675, 148);
            lblSearchIcon.Name = "lblSearchIcon";
            lblSearchIcon.Size = new Size(39, 28);
            lblSearchIcon.TabIndex = 65;
            lblSearchIcon.Text = "🔍";
            lblSearchIcon.Click += lblSearchIcon_Click;
            lblSearchIcon.MouseLeave += lblSearchIcon_MouseLeave;
            lblSearchIcon.MouseHover += lblSearchIcon_MouseHover;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(314, 377);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(111, 23);
            btnSearch.TabIndex = 67;
            btnSearch.Text = "&Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // ucManagePackageProductSupplier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            Controls.Add(btnSearch);
            Controls.Add(lblClearIcon);
            Controls.Add(lblSearchIcon);
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
            Size = new Size(800, 422);
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
        private Label lblClearIcon;
        private Label lblSearchIcon;
        private Button btnSearch;
    }
}
