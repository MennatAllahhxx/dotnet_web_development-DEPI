namespace Task3;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new Label();
        textBox1 = new TextBox();
        label2 = new Label();
        dateTimePicker1 = new DateTimePicker();
        label3 = new Label();
        radioButton1 = new RadioButton();
        radioButton2 = new RadioButton();
        label4 = new Label();
        comboBox1 = new ComboBox();
        label5 = new Label();
        checkBox1 = new CheckBox();
        checkBox2 = new CheckBox();
        checkBox3 = new CheckBox();
        checkBox4 = new CheckBox();
        label8 = new Label();
        label6 = new Label();
        progressBar1 = new ProgressBar();
        label7 = new Label();
        numericUpDown1 = new NumericUpDown();
        numericUpDown2 = new NumericUpDown();
        progressBar2 = new ProgressBar();
        button1 = new Button();
        label9 = new Label();
        panel2 = new Panel();
        panel3 = new Panel();
        panel4 = new Panel();
        label10 = new Label();
        richTextBox1 = new RichTextBox();
        panel1 = new Panel();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
        panel2.SuspendLayout();
        panel3.SuspendLayout();
        panel4.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.BackColor = Color.Transparent;
        label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        label1.ForeColor = Color.White;
        label1.Location = new Point(34, 25);
        label1.Name = "label1";
        label1.Size = new Size(48, 19);
        label1.TabIndex = 0;
        label1.Text = "Name:";
        // 
        // textBox1
        // 
        textBox1.Location = new Point(132, 24);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(167, 23);
        textBox1.TabIndex = 1;
        textBox1.TextChanged += textBox1_TextChanged;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.BackColor = Color.Transparent;
        label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        label2.ForeColor = Color.White;
        label2.Location = new Point(30, 62);
        label2.Name = "label2";
        label2.Size = new Size(63, 19);
        label2.TabIndex = 2;
        label2.Text = "Birthday:";
        // 
        // dateTimePicker1
        // 
        dateTimePicker1.CustomFormat = "dddd dd/MM/yyyy";
        dateTimePicker1.Format = DateTimePickerFormat.Custom;
        dateTimePicker1.Location = new Point(132, 62);
        dateTimePicker1.Name = "dateTimePicker1";
        dateTimePicker1.RightToLeft = RightToLeft.No;
        dateTimePicker1.Size = new Size(167, 23);
        dateTimePicker1.TabIndex = 3;
        dateTimePicker1.Value = new DateTime(2000, 1, 1, 12, 46, 0, 0);
        dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.BackColor = Color.Transparent;
        label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        label3.ForeColor = Color.White;
        label3.Location = new Point(30, 101);
        label3.Name = "label3";
        label3.Size = new Size(57, 19);
        label3.TabIndex = 4;
        label3.Text = "Gender:";
        // 
        // radioButton1
        // 
        radioButton1.AutoSize = true;
        radioButton1.BackColor = Color.Transparent;
        radioButton1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        radioButton1.ForeColor = Color.White;
        radioButton1.Location = new Point(133, 98);
        radioButton1.Name = "radioButton1";
        radioButton1.Size = new Size(57, 23);
        radioButton1.TabIndex = 5;
        radioButton1.TabStop = true;
        radioButton1.Text = "Male";
        radioButton1.UseVisualStyleBackColor = false;
        radioButton1.CheckedChanged += radioButton1_CheckedChanged;
        // 
        // radioButton2
        // 
        radioButton2.AutoSize = true;
        radioButton2.BackColor = Color.Transparent;
        radioButton2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        radioButton2.ForeColor = Color.White;
        radioButton2.Location = new Point(230, 97);
        radioButton2.Name = "radioButton2";
        radioButton2.Size = new Size(70, 23);
        radioButton2.TabIndex = 6;
        radioButton2.TabStop = true;
        radioButton2.Text = "Female";
        radioButton2.UseVisualStyleBackColor = false;
        radioButton2.CheckedChanged += radioButton2_CheckedChanged;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.BackColor = Color.Transparent;
        label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        label4.ForeColor = Color.White;
        label4.Location = new Point(30, 137);
        label4.Name = "label4";
        label4.Size = new Size(101, 19);
        label4.TabIndex = 7;
        label4.Text = "Martial Status: ";
        // 
        // comboBox1
        // 
        comboBox1.FormattingEnabled = true;
        comboBox1.Items.AddRange(new object[] { "Single", "Married", "Divorced", "Widowed" });
        comboBox1.Location = new Point(137, 133);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new Size(163, 23);
        comboBox1.TabIndex = 8;
        comboBox1.Text = "Please select your status";
        comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.BackColor = Color.Transparent;
        label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        label5.ForeColor = Color.White;
        label5.Location = new Point(43, 249);
        label5.Name = "label5";
        label5.Size = new Size(65, 20);
        label5.TabIndex = 9;
        label5.Text = "Hobbies";
        // 
        // checkBox1
        // 
        checkBox1.AutoSize = true;
        checkBox1.BackColor = Color.Transparent;
        checkBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        checkBox1.ForeColor = Color.White;
        checkBox1.Location = new Point(71, 272);
        checkBox1.Name = "checkBox1";
        checkBox1.Size = new Size(83, 24);
        checkBox1.TabIndex = 10;
        checkBox1.Text = "Football";
        checkBox1.UseVisualStyleBackColor = false;
        checkBox1.CheckedChanged += checkBox1_CheckedChanged;
        // 
        // checkBox2
        // 
        checkBox2.AutoSize = true;
        checkBox2.BackColor = Color.Transparent;
        checkBox2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        checkBox2.ForeColor = Color.White;
        checkBox2.Location = new Point(188, 43);
        checkBox2.Name = "checkBox2";
        checkBox2.Size = new Size(111, 24);
        checkBox2.TabIndex = 11;
        checkBox2.Text = "Watching TV";
        checkBox2.UseVisualStyleBackColor = false;
        checkBox2.CheckedChanged += checkBox2_CheckedChanged;
        // 
        // checkBox3
        // 
        checkBox3.AutoSize = true;
        checkBox3.BackColor = Color.Transparent;
        checkBox3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        checkBox3.ForeColor = Color.White;
        checkBox3.Location = new Point(188, 13);
        checkBox3.Name = "checkBox3";
        checkBox3.Size = new Size(98, 24);
        checkBox3.TabIndex = 12;
        checkBox3.Text = "Swimming";
        checkBox3.UseVisualStyleBackColor = false;
        checkBox3.CheckedChanged += checkBox3_CheckedChanged;
        // 
        // checkBox4
        // 
        checkBox4.AutoSize = true;
        checkBox4.BackColor = Color.Transparent;
        checkBox4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        checkBox4.ForeColor = Color.White;
        checkBox4.Location = new Point(71, 302);
        checkBox4.Name = "checkBox4";
        checkBox4.Size = new Size(58, 24);
        checkBox4.TabIndex = 13;
        checkBox4.Text = "Gym";
        checkBox4.UseVisualStyleBackColor = false;
        checkBox4.CheckedChanged += checkBox4_CheckedChanged;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.BackColor = Color.Transparent;
        label8.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        label8.ForeColor = Color.White;
        label8.Location = new Point(42, 345);
        label8.Name = "label8";
        label8.Size = new Size(80, 20);
        label8.TabIndex = 16;
        label8.Text = "Languages";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.BackColor = Color.Transparent;
        label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        label6.ForeColor = Color.White;
        label6.Location = new Point(34, 12);
        label6.Name = "label6";
        label6.Size = new Size(54, 19);
        label6.TabIndex = 17;
        label6.Text = "Arabic :";
        // 
        // progressBar1
        // 
        progressBar1.Location = new Point(148, 12);
        progressBar1.Name = "progressBar1";
        progressBar1.Size = new Size(151, 23);
        progressBar1.Style = ProgressBarStyle.Continuous;
        progressBar1.TabIndex = 18;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.BackColor = Color.Transparent;
        label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        label7.ForeColor = Color.White;
        label7.Location = new Point(34, 42);
        label7.Name = "label7";
        label7.Size = new Size(59, 19);
        label7.TabIndex = 19;
        label7.Text = "English :";
        // 
        // numericUpDown1
        // 
        numericUpDown1.Location = new Point(99, 12);
        numericUpDown1.Name = "numericUpDown1";
        numericUpDown1.Size = new Size(43, 23);
        numericUpDown1.TabIndex = 21;
        numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
        // 
        // numericUpDown2
        // 
        numericUpDown2.Location = new Point(99, 42);
        numericUpDown2.Name = "numericUpDown2";
        numericUpDown2.Size = new Size(43, 23);
        numericUpDown2.TabIndex = 23;
        numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
        // 
        // progressBar2
        // 
        progressBar2.BackColor = Color.White;
        progressBar2.Location = new Point(148, 42);
        progressBar2.Name = "progressBar2";
        progressBar2.Size = new Size(151, 23);
        progressBar2.TabIndex = 22;
        // 
        // button1
        // 
        button1.BackColor = Color.White;
        button1.BackgroundImageLayout = ImageLayout.Center;
        button1.Cursor = Cursors.Hand;
        button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        button1.Location = new Point(344, 468);
        button1.Name = "button1";
        button1.Size = new Size(112, 31);
        button1.TabIndex = 24;
        button1.Text = "Show Results";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.BackColor = Color.Transparent;
        label9.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
        label9.ForeColor = Color.White;
        label9.Location = new Point(427, 41);
        label9.Name = "label9";
        label9.Size = new Size(67, 25);
        label9.TabIndex = 26;
        label9.Text = "Report";
        // 
        // panel2
        // 
        panel2.BackColor = Color.Transparent;
        panel2.BorderStyle = BorderStyle.Fixed3D;
        panel2.Controls.Add(progressBar2);
        panel2.Controls.Add(label6);
        panel2.Controls.Add(progressBar1);
        panel2.Controls.Add(numericUpDown2);
        panel2.Controls.Add(label7);
        panel2.Controls.Add(numericUpDown1);
        panel2.Location = new Point(35, 358);
        panel2.Name = "panel2";
        panel2.Size = new Size(334, 85);
        panel2.TabIndex = 28;
        // 
        // panel3
        // 
        panel3.BackColor = Color.Transparent;
        panel3.BorderStyle = BorderStyle.Fixed3D;
        panel3.Controls.Add(checkBox2);
        panel3.Controls.Add(checkBox3);
        panel3.Location = new Point(35, 257);
        panel3.Name = "panel3";
        panel3.Size = new Size(334, 85);
        panel3.TabIndex = 29;
        // 
        // panel4
        // 
        panel4.BackColor = Color.Transparent;
        panel4.BorderStyle = BorderStyle.Fixed3D;
        panel4.Controls.Add(radioButton2);
        panel4.Controls.Add(label1);
        panel4.Controls.Add(label2);
        panel4.Controls.Add(label3);
        panel4.Controls.Add(label4);
        panel4.Controls.Add(radioButton1);
        panel4.Controls.Add(comboBox1);
        panel4.Controls.Add(dateTimePicker1);
        panel4.Controls.Add(textBox1);
        panel4.Location = new Point(35, 53);
        panel4.Name = "panel4";
        panel4.Size = new Size(334, 189);
        panel4.TabIndex = 30;
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.BackColor = Color.Transparent;
        label10.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        label10.ForeColor = Color.White;
        label10.Location = new Point(43, 41);
        label10.Name = "label10";
        label10.Size = new Size(146, 20);
        label10.TabIndex = 31;
        label10.Text = "Personal Information";
        // 
        // richTextBox1
        // 
        richTextBox1.Location = new Point(427, 79);
        richTextBox1.Name = "richTextBox1";
        richTextBox1.Size = new Size(327, 342);
        richTextBox1.TabIndex = 25;
        richTextBox1.Text = "";
        // 
        // panel1
        // 
        panel1.BackColor = Color.Transparent;
        panel1.BorderStyle = BorderStyle.Fixed3D;
        panel1.Location = new Point(412, 53);
        panel1.Name = "panel1";
        panel1.Size = new Size(358, 390);
        panel1.TabIndex = 32;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackgroundImage = Properties.Resources.OIP;
        BackgroundImageLayout = ImageLayout.Stretch;
        ClientSize = new Size(800, 507);
        Controls.Add(label10);
        Controls.Add(label5);
        Controls.Add(label9);
        Controls.Add(richTextBox1);
        Controls.Add(button1);
        Controls.Add(label8);
        Controls.Add(checkBox4);
        Controls.Add(checkBox1);
        Controls.Add(panel2);
        Controls.Add(panel3);
        Controls.Add(panel4);
        Controls.Add(panel1);
        Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "Form1";
        Text = "Application";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        panel3.ResumeLayout(false);
        panel3.PerformLayout();
        panel4.ResumeLayout(false);
        panel4.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox textBox1;
    private Label label2;
    private DateTimePicker dateTimePicker1;
    private Label label3;
    private RadioButton radioButton1;
    private RadioButton radioButton2;
    private Label label4;
    private ComboBox comboBox1;
    private Label label5;
    private CheckBox checkBox1;
    private CheckBox checkBox2;
    private CheckBox checkBox3;
    private CheckBox checkBox4;
    private Label label8;
    private Label label6;
    private ProgressBar progressBar1;
    private Label label7;
    private NumericUpDown numericUpDown1;
    private NumericUpDown numericUpDown2;
    private ProgressBar progressBar2;
    private Button button1;
    private Label label9;
    private Panel panel2;
    private Panel panel3;
    private Panel panel4;
    private Label label10;
    private RichTextBox richTextBox1;
    private Panel panel1;
}
