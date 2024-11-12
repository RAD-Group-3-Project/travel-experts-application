namespace TravelExpertGUI;

partial class ucManagePackages
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
        textBox1 = new TextBox();
        textBox2 = new TextBox();
        label2 = new Label();
        textBox3 = new TextBox();
        label3 = new Label();
        textBox4 = new TextBox();
        label4 = new Label();
        textBox5 = new TextBox();
        label5 = new Label();
        label6 = new Label();
        textBox6 = new TextBox();
        label7 = new Label();
        textBox7 = new TextBox();
        dataGridView1 = new DataGridView();
        button1 = new Button();
        button2 = new Button();
        button3 = new Button();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(73, 50);
        label1.Name = "label1";
        label1.Size = new Size(83, 20);
        label1.TabIndex = 0;
        label1.Text = "Package Id:";
        // 
        // textBox1
        // 
        textBox1.Location = new Point(222, 47);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(125, 27);
        textBox1.TabIndex = 1;
        // 
        // textBox2
        // 
        textBox2.Location = new Point(222, 87);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(125, 27);
        textBox2.TabIndex = 3;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(73, 87);
        label2.Name = "label2";
        label2.Size = new Size(110, 20);
        label2.TabIndex = 2;
        label2.Text = "Package Name:";
        // 
        // textBox3
        // 
        textBox3.Location = new Point(222, 124);
        textBox3.Name = "textBox3";
        textBox3.Size = new Size(125, 27);
        textBox3.TabIndex = 5;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(73, 127);
        label3.Name = "label3";
        label3.Size = new Size(137, 20);
        label3.TabIndex = 4;
        label3.Text = "Package Start Date:";
        // 
        // textBox4
        // 
        textBox4.Location = new Point(222, 159);
        textBox4.Name = "textBox4";
        textBox4.Size = new Size(125, 27);
        textBox4.TabIndex = 7;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(73, 166);
        label4.Name = "label4";
        label4.Size = new Size(131, 20);
        label4.TabIndex = 6;
        label4.Text = "Package End Date:";
        // 
        // textBox5
        // 
        textBox5.Location = new Point(222, 199);
        textBox5.Name = "textBox5";
        textBox5.Size = new Size(217, 27);
        textBox5.TabIndex = 9;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(73, 202);
        label5.Name = "label5";
        label5.Size = new Size(146, 20);
        label5.TabIndex = 8;
        label5.Text = "Package Description:";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(469, 51);
        label6.Name = "label6";
        label6.Size = new Size(137, 20);
        label6.TabIndex = 10;
        label6.Text = "Package Base Price:";
        // 
        // textBox6
        // 
        textBox6.Location = new Point(618, 51);
        textBox6.Name = "textBox6";
        textBox6.Size = new Size(125, 27);
        textBox6.TabIndex = 11;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(469, 94);
        label7.Name = "label7";
        label7.Size = new Size(204, 20);
        label7.TabIndex = 12;
        label7.Text = "Package Agency Commission:";
        // 
        // textBox7
        // 
        textBox7.Location = new Point(679, 87);
        textBox7.Name = "textBox7";
        textBox7.Size = new Size(125, 27);
        textBox7.TabIndex = 13;
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(56, 249);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.Size = new Size(809, 236);
        dataGridView1.TabIndex = 14;
        // 
        // button1
        // 
        button1.Location = new Point(60, 506);
        button1.Name = "button1";
        button1.Size = new Size(94, 29);
        button1.TabIndex = 15;
        button1.Text = "&Add";
        button1.UseVisualStyleBackColor = true;
        // 
        // button2
        // 
        button2.Location = new Point(170, 506);
        button2.Name = "button2";
        button2.Size = new Size(94, 29);
        button2.TabIndex = 16;
        button2.Text = "&Edit";
        button2.UseVisualStyleBackColor = true;
        // 
        // button3
        // 
        button3.Location = new Point(323, 506);
        button3.Name = "button3";
        button3.Size = new Size(94, 29);
        button3.TabIndex = 17;
        button3.Text = "&Delete";
        button3.UseVisualStyleBackColor = true;
        // 
        // ucManagePackages
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(dataGridView1);
        Controls.Add(textBox7);
        Controls.Add(label7);
        Controls.Add(textBox6);
        Controls.Add(label6);
        Controls.Add(textBox5);
        Controls.Add(label5);
        Controls.Add(textBox4);
        Controls.Add(label4);
        Controls.Add(textBox3);
        Controls.Add(label3);
        Controls.Add(textBox2);
        Controls.Add(label2);
        Controls.Add(textBox1);
        Controls.Add(label1);
        Name = "ucManagePackages";
        Size = new Size(914, 570);
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox textBox1;
    private TextBox textBox2;
    private Label label2;
    private TextBox textBox3;
    private Label label3;
    private TextBox textBox4;
    private Label label4;
    private TextBox textBox5;
    private Label label5;
    private Label label6;
    private TextBox textBox6;
    private Label label7;
    private TextBox textBox7;
    private DataGridView dataGridView1;
    private Button button1;
    private Button button2;
    private Button button3;
}
