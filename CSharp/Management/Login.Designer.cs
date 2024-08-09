namespace Management
{
    partial class Login
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
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(259, 213);
            button1.Name = "button1";
            button1.Size = new Size(85, 27);
            button1.TabIndex = 11;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(151, 169);
            label2.Name = "label2";
            label2.Size = new Size(70, 19);
            label2.TabIndex = 10;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(147, 126);
            label1.Name = "label1";
            label1.Size = new Size(74, 19);
            label1.TabIndex = 9;
            label1.Text = "Username:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(227, 168);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(167, 23);
            textBox2.TabIndex = 8;
            textBox2.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(227, 125);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(167, 23);
            textBox1.TabIndex = 7;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.OIP;
            ClientSize = new Size(541, 364);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}
