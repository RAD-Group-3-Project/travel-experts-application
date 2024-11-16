namespace TravelExpertGUI
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
            dgvAgencies.BackgroundColor = SystemColors.GradientActiveCaption;
            dgvAgencies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAgencies.Location = new Point(31, 182);
            dgvAgencies.Margin = new Padding(3, 2, 3, 2);
            dgvAgencies.Name = "dgvAgencies";
            dgvAgencies.RowHeadersWidth = 51;
            dgvAgencies.Size = new Size(728, 177);
            dgvAgencies.TabIndex = 11;
            dgvAgencies.SelectionChanged += dgvAgencies_SelectionChanged;
            // 
            // btnDelete
            // 
            btnDelete.ForeColor = Color.FromArgb(192, 0, 0);
            btnDelete.Location = new Point(249, 375);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(69, 22);
            btnDelete.TabIndex = 38;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(163, 375);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(69, 22);
            btnEdit.TabIndex = 37;
            btnEdit.Text = "&Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(31, 375);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(69, 22);
            btnAdd.TabIndex = 36;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblAgencyId
            // 
            lblAgencyId.AutoSize = true;
            lblAgencyId.Location = new Point(82, 42);
            lblAgencyId.Name = "lblAgencyId";
            lblAgencyId.Size = new Size(69, 15);
            lblAgencyId.TabIndex = 39;
            lblAgencyId.Text = "Agency Id : ";
            // 
            // txtAgencyId
            // 
            txtAgencyId.Location = new Point(163, 40);
            txtAgencyId.Margin = new Padding(3, 2, 3, 2);
            txtAgencyId.Name = "txtAgencyId";
            txtAgencyId.ReadOnly = true;
            txtAgencyId.Size = new Size(200, 23);
            txtAgencyId.TabIndex = 0;
            // 
            // txtAgencyAddress
            // 
            txtAgencyAddress.Location = new Point(163, 73);
            txtAgencyAddress.Margin = new Padding(3, 2, 3, 2);
            txtAgencyAddress.Name = "txtAgencyAddress";
            txtAgencyAddress.ReadOnly = true;
            txtAgencyAddress.Size = new Size(200, 23);
            txtAgencyAddress.TabIndex = 1;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(94, 75);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(58, 15);
            lblAddress.TabIndex = 42;
            lblAddress.Text = "Address : ";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(113, 110);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(34, 15);
            lblCity.TabIndex = 43;
            lblCity.Text = "City :";
            // 
            // lblProv
            // 
            lblProv.AutoSize = true;
            lblProv.Location = new Point(86, 145);
            lblProv.Name = "lblProv";
            lblProv.Size = new Size(59, 15);
            lblProv.TabIndex = 44;
            lblProv.Text = "Province :";
            // 
            // lblPostal
            // 
            lblPostal.AutoSize = true;
            lblPostal.Location = new Point(442, 42);
            lblPostal.Name = "lblPostal";
            lblPostal.Size = new Size(76, 15);
            lblPostal.TabIndex = 45;
            lblPostal.Text = "Postal Code :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(462, 75);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 46;
            label4.Text = "Country : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(471, 110);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 47;
            label5.Text = "Phone : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(492, 142);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 48;
            label6.Text = "Fax :";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(163, 108);
            txtCity.Margin = new Padding(3, 2, 3, 2);
            txtCity.Name = "txtCity";
            txtCity.ReadOnly = true;
            txtCity.Size = new Size(200, 23);
            txtCity.TabIndex = 2;
            // 
            // txtProv
            // 
            txtProv.Location = new Point(163, 142);
            txtProv.Margin = new Padding(3, 2, 3, 2);
            txtProv.Name = "txtProv";
            txtProv.ReadOnly = true;
            txtProv.Size = new Size(200, 23);
            txtProv.TabIndex = 3;
            // 
            // txtPostal
            // 
            txtPostal.Location = new Point(529, 40);
            txtPostal.Margin = new Padding(3, 2, 3, 2);
            txtPostal.Name = "txtPostal";
            txtPostal.ReadOnly = true;
            txtPostal.Size = new Size(225, 23);
            txtPostal.TabIndex = 4;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(529, 73);
            txtCountry.Margin = new Padding(3, 2, 3, 2);
            txtCountry.Name = "txtCountry";
            txtCountry.ReadOnly = true;
            txtCountry.Size = new Size(225, 23);
            txtCountry.TabIndex = 5;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(529, 105);
            txtPhone.Margin = new Padding(3, 2, 3, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new Size(225, 23);
            txtPhone.TabIndex = 6;
            // 
            // txtFax
            // 
            txtFax.Location = new Point(529, 140);
            txtFax.Margin = new Padding(3, 2, 3, 2);
            txtFax.Name = "txtFax";
            txtFax.ReadOnly = true;
            txtFax.Size = new Size(225, 23);
            txtFax.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Location = new Point(593, 375);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(165, 22);
            btnSave.TabIndex = 8;
            btnSave.Text = "&Save Changes";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDiscard
            // 
            btnDiscard.Enabled = false;
            btnDiscard.Location = new Point(407, 375);
            btnDiscard.Margin = new Padding(3, 2, 3, 2);
            btnDiscard.Name = "btnDiscard";
            btnDiscard.Size = new Size(165, 22);
            btnDiscard.TabIndex = 9;
            btnDiscard.Text = "Discard Chan&ges";
            btnDiscard.UseVisualStyleBackColor = true;
            btnDiscard.Click += btnDiscard_Click;
            // 
            // ucManageAgencies
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
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
            Controls.Add(dgvAgencies);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ucManageAgencies";
            Size = new Size(800, 422);
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
