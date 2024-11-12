namespace TravelExpertGUI
{
    partial class frmLogin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(273, 210);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(163, 23);
            txtPassword.TabIndex = 3;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(273, 180);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(163, 23);
            txtUsername.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(207, 213);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(204, 183);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.travel_expert_logo;
            pictureBox1.Location = new Point(183, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(264, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 95, 184);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(183, 254);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(264, 34);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 318);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(pictureBox1);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmLogin";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private PictureBox pictureBox1;
        private Button btnLogin;
    }
}