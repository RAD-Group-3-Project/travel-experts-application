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
            txtUser.Location = new Point(325, 87);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(125, 27);
            txtUser.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(223, 94);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 1;
            label1.Text = "Username: ";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(325, 148);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(223, 155);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 3;
            label2.Text = "Password: ";
            // 
            // button1
            // 
            button1.Location = new Point(325, 205);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // picTravelExperts
            // 
            picTravelExperts.Image = (Image)resources.GetObject("picTravelExperts.Image");
            picTravelExperts.Location = new Point(12, 51);
            picTravelExperts.Name = "picTravelExperts";
            picTravelExperts.Size = new Size(196, 209);
            picTravelExperts.SizeMode = PictureBoxSizeMode.StretchImage;
            picTravelExperts.TabIndex = 5;
            picTravelExperts.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 286);
            Controls.Add(picTravelExperts);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Controls.Add(txtUser);
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