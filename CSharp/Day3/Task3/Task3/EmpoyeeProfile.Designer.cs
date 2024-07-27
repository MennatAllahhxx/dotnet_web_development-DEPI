namespace Task3
{
    partial class EmpoyeeProfile
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
            label9 = new Label();
            richTextBox1 = new RichTextBox();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(77, 9);
            label9.Name = "label9";
            label9.Size = new Size(67, 25);
            label9.TabIndex = 34;
            label9.Text = "Report";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(55, 37);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(430, 283);
            richTextBox1.TabIndex = 33;
            richTextBox1.Text = "";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Location = new Point(36, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(467, 321);
            panel1.TabIndex = 35;
            // 
            // EmpoyeeProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.OIP;
            ClientSize = new Size(541, 364);
            Controls.Add(label9);
            Controls.Add(richTextBox1);
            Controls.Add(panel1);
            Name = "EmpoyeeProfile";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Your Profile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private RichTextBox richTextBox1;
        private Panel panel1;
    }
}