namespace TravelExpertGUI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txtUser = new TextBox();
            label1 = new Label();
            txtPassword = new TextBox();
            label2 = new Label();
            button1 = new Button();
            picTravelExperts = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picTravelExperts).BeginInit();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.BackColor = SystemColors.Control;
            txtUser.Location = new Point(284, 65);
            txtUser.Margin = new Padding(3, 2, 3, 2);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(110, 23);
            txtUser.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(195, 70);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 1;
            label1.Text = "Username: ";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Control;
            txtPassword.Location = new Point(284, 111);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(110, 23);
            txtPassword.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(195, 116);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 3;
            label2.Text = "Password: ";
            // 
            // button1
            // 
            button1.Location = new Point(284, 154);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // picTravelExperts
            // 
            picTravelExperts.Image = (Image)resources.GetObject("picTravelExperts.Image");
            picTravelExperts.Location = new Point(10, 38);
            picTravelExperts.Margin = new Padding(3, 2, 3, 2);
            picTravelExperts.Name = "picTravelExperts";
            picTravelExperts.Size = new Size(172, 157);
            picTravelExperts.SizeMode = PictureBoxSizeMode.StretchImage;
            picTravelExperts.TabIndex = 5;
            picTravelExperts.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 214);
            Controls.Add(picTravelExperts);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Controls.Add(txtUser);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            Text = "Travel Experts Login ";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)picTravelExperts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUser;
        private Label label1;
        private TextBox txtPassword;
        private Label label2;
        private Button button1;
        private PictureBox picTravelExperts;
    }
}