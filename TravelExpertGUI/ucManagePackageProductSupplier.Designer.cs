﻿namespace TravelExpertGUI
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
            txtPackageProductSupplierId.Location = new Point(287, 85);
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
            lblPackageID.Location = new Point(185, 129);
            lblPackageID.Name = "lblPackageID";
            lblPackageID.Size = new Size(85, 20);
            lblPackageID.TabIndex = 52;
            lblPackageID.Text = "Package ID:";
            // 
            // lblProductSupplierID
            // 
            lblProductSupplierID.AutoSize = true;
            lblProductSupplierID.Location = new Point(135, 173);
            lblProductSupplierID.Name = "lblProductSupplierID";
            lblProductSupplierID.Size = new Size(141, 20);
            lblProductSupplierID.TabIndex = 54;
            lblProductSupplierID.Text = "Product Supplier ID:";
            // 
            // dgvPackageProductSupplier
            // 
            dgvPackageProductSupplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPackageProductSupplier.BackgroundColor = SystemColors.GradientActiveCaption;
            dgvPackageProductSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPackageProductSupplier.Location = new Point(57, 239);
            dgvPackageProductSupplier.Margin = new Padding(3, 4, 3, 4);
            dgvPackageProductSupplier.Name = "dgvPackageProductSupplier";
            dgvPackageProductSupplier.ReadOnly = true;
            dgvPackageProductSupplier.RowHeadersWidth = 51;
            dgvPackageProductSupplier.Size = new Size(802, 236);
            dgvPackageProductSupplier.TabIndex = 57;
            dgvPackageProductSupplier.SelectionChanged += dgvPackageProductSupplier_SelectionChanged;
            // 
            // btnDisc
            // 
            btnDisc.Enabled = false;
            btnDisc.Location = new Point(525, 503);
            btnDisc.Name = "btnDisc";
            btnDisc.Size = new Size(163, 29);
            btnDisc.TabIndex = 62;
            btnDisc.Text = "Discard Chan&ges";
            btnDisc.UseVisualStyleBackColor = true;
            btnDisc.Click += btnDisc_Click;
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Location = new Point(695, 504);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(163, 29);
            btnSave.TabIndex = 61;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.ForeColor = Color.FromArgb(192, 0, 0);
            btnDelete.Location = new Point(249, 504);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(79, 29);
            btnDelete.TabIndex = 60;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(163, 504);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(79, 29);
            btnEdit.TabIndex = 59;
            btnEdit.Text = "&Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(57, 504);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(79, 29);
            btnAdd.TabIndex = 58;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cmbPackageID
            // 
            cmbPackageID.BackColor = SystemColors.Control;
            cmbPackageID.FormattingEnabled = true;
            cmbPackageID.Location = new Point(287, 129);
            cmbPackageID.Name = "cmbPackageID";
            cmbPackageID.Size = new Size(114, 28);
            cmbPackageID.TabIndex = 63;
            // 
            // cmbProductSupplierID
            // 
            cmbProductSupplierID.BackColor = SystemColors.Control;
            cmbProductSupplierID.FormattingEnabled = true;
            cmbProductSupplierID.Location = new Point(287, 173);
            cmbProductSupplierID.Name = "cmbProductSupplierID";
            cmbProductSupplierID.Size = new Size(114, 28);
            cmbProductSupplierID.TabIndex = 64;
            // 
            // lblClearIcon
            // 
            lblClearIcon.AutoSize = true;
            lblClearIcon.Font = new Font("Segoe UI", 15F);
            lblClearIcon.Location = new Point(814, 197);
            lblClearIcon.Name = "lblClearIcon";
            lblClearIcon.Size = new Size(49, 35);
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
            lblSearchIcon.Location = new Point(771, 197);
            lblSearchIcon.Name = "lblSearchIcon";
            lblSearchIcon.Size = new Size(49, 35);
            lblSearchIcon.TabIndex = 65;
            lblSearchIcon.Text = "🔍";
            lblSearchIcon.Click += lblSearchIcon_Click;
            lblSearchIcon.MouseLeave += lblSearchIcon_MouseLeave;
            lblSearchIcon.MouseHover += lblSearchIcon_MouseHover;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(359, 503);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(127, 31);
            btnSearch.TabIndex = 67;
            btnSearch.Text = "&Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // ucManagePackageProductSupplier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
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
            Name = "ucManagePackageProductSupplier";
            Size = new Size(914, 563);
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
