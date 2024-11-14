namespace TravelExpertGUI;

partial class ucWelcomeMessage
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
        label1 = new Label();
        lblHello = new Label();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Arial", 16F, FontStyle.Bold);
        label1.ForeColor = Color.DarkSlateBlue;
        label1.Location = new Point(163, 220);
        label1.Name = "label1";
        label1.Size = new Size(411, 26);
        label1.TabIndex = 0;
        label1.Text = "Welcome to Travel Expert Management";
        // 
        // lblHello
        // 
        lblHello.AutoSize = true;
        lblHello.Font = new Font("Arial", 12F);
        lblHello.ForeColor = Color.DarkBlue;
        lblHello.Location = new Point(316, 190);
        lblHello.Name = "lblHello";
        lblHello.Padding = new Padding(0, 0, 9, 0);
        lblHello.Size = new Size(104, 18);
        lblHello.TabIndex = 1;
        lblHello.Text = "Hello, Admin";
        // 
        // ucWelcomeMessage
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.GradientInactiveCaption;
        Controls.Add(lblHello);
        Controls.Add(label1);
        Margin = new Padding(3, 2, 3, 2);
        Name = "ucWelcomeMessage";
        Size = new Size(800, 428);
        Load += ucWelcomeMessage_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label lblHello;
}
