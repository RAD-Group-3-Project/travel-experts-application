﻿namespace TravelExpertGUI
{
    partial class ucManageAgencies
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
            dgvAgencies = new DataGridView();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            lblAgencyId = new Label();
            txtAgencyId = new TextBox();
            txtAgencyAddress = new TextBox();
            lblAddress = new Label();
            lblCity = new Label();
            lblProv = new Label();
            lblPostal = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtCity = new TextBox();
            txtProv = new TextBox();
            txtPostal = new TextBox();
            txtCountry = new TextBox();
            txtPhone = new TextBox();
            txtFax = new TextBox();
            btnSave = new Button();
            btnDiscard = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAgencies).BeginInit();
            SuspendLayout();
            // 
            // dgvAgencies
            // 
            dgvAgencies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAgencies.BackgroundColor = SystemColors.GradientActiveCaption;
            dgvAgencies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAgencies.Location = new Point(46, 182);
            dgvAgencies.Margin = new Padding(3, 2, 3, 2);
            dgvAgencies.Margin = new Padding(3, 2, 3, 2);
            dgvAgencies.Size = new Size(832, 236);
            dgvAgencies.RowHeadersWidth = 51;
            dgvAgencies.Size = new Size(708, 177);
            dgvAgencies.TabIndex = 11;
            dgvAgencies.SelectionChanged += dgvAgencies_SelectionChanged;
            // 
            btnDelete.ForeColor = Color.FromArgb(192, 0, 0);
            btnDelete.Location = new Point(285, 500);
            btnDelete.Location = new Point(272, 375);
            btnDelete.Size = new Size(79, 29);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 22);
            btnDelete.TabIndex = 38;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            btnEdit.Location = new Point(186, 500);
            btnEdit.Location = new Point(160, 375);
            btnEdit.Size = new Size(79, 29);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(82, 22);
            btnEdit.TabIndex = 37;
            btnEdit.Text = "&Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            btnAdd.Location = new Point(35, 500);
            btnAdd.Location = new Point(48, 375);
            btnAdd.Size = new Size(79, 29);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 22);
            btnAdd.TabIndex = 36;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblAgencyId
            // 
            lblAgencyId.AutoSize = true;
            lblAgencyId.Location = new Point(94, 56);
            lblAgencyId.Name = "lblAgencyId";
            lblAgencyId.Size = new Size(86, 20);
            lblAgencyId.TabIndex = 39;
            lblAgencyId.Text = "Agency Id : ";
            // 
            // txtAgencyId
            // 
            txtAgencyId.Location = new Point(186, 53);
            txtAgencyId.Name = "txtAgencyId";
            txtAgencyId.ReadOnly = true;
            txtAgencyId.Size = new Size(228, 27);
            txtAgencyId.TabIndex = 0;
            // 
            // txtAgencyAddress
            // 
            txtAgencyAddress.Location = new Point(186, 97);
            txtAgencyAddress.Name = "txtAgencyAddress";
            txtAgencyAddress.ReadOnly = true;
            txtAgencyAddress.Size = new Size(228, 27);
            txtAgencyAddress.TabIndex = 1;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(107, 100);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(73, 20);
            lblAddress.TabIndex = 42;
            lblAddress.Text = "Address : ";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(129, 147);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(41, 20);
            lblCity.TabIndex = 43;
            lblCity.Text = "City :";
            // 
            // lblProv
            // 
            lblProv.AutoSize = true;
            lblProv.Location = new Point(98, 193);
            lblProv.Name = "lblProv";
            lblProv.Size = new Size(72, 20);
            lblProv.TabIndex = 44;
            lblProv.Text = "Province :";
            // 
            // lblPostal
            // 
            lblPostal.AutoSize = true;
            lblPostal.Location = new Point(505, 56);
            lblPostal.Name = "lblPostal";
            lblPostal.Size = new Size(94, 20);
            lblPostal.TabIndex = 45;
            lblPostal.Text = "Postal Code :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(528, 100);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 46;
            label4.Text = "Country : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(538, 147);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 47;
            label5.Text = "Phone : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(562, 189);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 48;
            label6.Text = "Fax :";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(186, 144);
            txtCity.Name = "txtCity";
            txtCity.ReadOnly = true;
            txtCity.Size = new Size(228, 27);
            txtCity.TabIndex = 2;
            // 
            // txtProv
            // 
            txtProv.Location = new Point(186, 189);
            txtProv.Name = "txtProv";
            txtProv.ReadOnly = true;
            txtProv.Size = new Size(228, 27);
            txtProv.TabIndex = 3;
            // 
            // txtPostal
            // 
            txtPostal.Location = new Point(605, 53);
            txtPostal.Name = "txtPostal";
            txtPostal.ReadOnly = true;
            txtPostal.Size = new Size(257, 27);
            txtPostal.TabIndex = 4;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(605, 97);
            txtCountry.Name = "txtCountry";
            txtCountry.ReadOnly = true;
            txtCountry.Size = new Size(257, 27);
            txtCountry.TabIndex = 5;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(605, 140);
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new Size(257, 27);
            txtPhone.TabIndex = 6;
            // 
            // txtFax
            // 
            txtFax.Location = new Point(605, 187);
            txtFax.Name = "txtFax";
            txtFax.ReadOnly = true;
            txtFax.Size = new Size(257, 27);
            txtFax.TabIndex = 7;
            // 
            // btnSave
            btnSave.Location = new Point(678, 500);
            btnSave.Location = new Point(583, 375);
            btnSave.Size = new Size(189, 29);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(169, 22);
            btnSave.TabIndex = 8;
            btnSave.Text = "&Save Changes";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDiscard
            btnDiscard.Location = new Point(465, 500);
            btnDiscard.Location = new Point(384, 375);
            btnDiscard.Size = new Size(189, 29);
            btnDiscard.Name = "btnDiscard";
            btnDiscard.Size = new Size(169, 22);
            btnDiscard.TabIndex = 9;
            btnDiscard.Text = "Discard Chan&ges";
            btnDiscard.UseVisualStyleBackColor = true;
            btnDiscard.Click += btnDiscard_Click;
            // 
            // ucManageAgencies
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            Controls.Add(btnDiscard);
            Controls.Add(btnSave);
            Controls.Add(txtFax);
            Controls.Add(txtPhone);
            Controls.Add(txtCountry);
            Controls.Add(txtPostal);
            Controls.Add(txtProv);
            Controls.Add(txtCity);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblPostal);
            Controls.Add(lblProv);
            Controls.Add(lblCity);
            Controls.Add(lblAddress);
            Controls.Add(txtAgencyAddress);
            Controls.Add(txtAgencyId);
            Controls.Add(lblAgencyId);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Size = new Size(914, 562);
            Name = "ucManageAgencies";
            Size = new Size(795, 402);
            Load += ucManageAgencies_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAgencies).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAgencies;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private Label lblAgencyId;
        private TextBox txtAgencyId;
        private TextBox txtAgencyAddress;
        private Label lblAddress;
        private Label lblCity;
        private Label lblProv;
        private Label lblPostal;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtCity;
        private TextBox txtProv;
        private TextBox txtPostal;
        private TextBox txtCountry;
        private TextBox txtPhone;
        private TextBox txtFax;
        private Button btnSave;
        private Button btnDiscard;
    }
}
