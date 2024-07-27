using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class Register : Form
    {
        List<string> skills = new List<string>();
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text.Equals("Manager"))
            {
                Manager newUser = new Manager();

                newUser.firstName = textBox1.Text;
                newUser.lastName = textBox2.Text;
                newUser.username = textBox4.Text;
                newUser.password = textBox3.Text;
                newUser.gender = radioButton1.Checked ? "Male" : "Female";
                newUser.dob = dateTimePicker1.Text;
                newUser.martialStatus = comboBox1.Text;
                newUser.jobTitle = textBox5.Text;
                newUser.department = textBox6.Text;
                newUser.languages = new Dictionary<string, int> {
                    {"Arabic", Convert.ToInt32(numericUpDown1.Value)},
                    {"English", Convert.ToInt32(numericUpDown2.Value)}};
                newUser.skills = this.skills;

                Users.users.Add(newUser);
            }
            else
            {
                Employee newUser = new Employee();

                newUser.firstName = textBox1.Text;
                newUser.lastName = textBox2.Text;
                newUser.username = textBox4.Text;
                newUser.password = textBox3.Text;
                newUser.gender = radioButton1.Checked ? "Male" : "Female";
                newUser.dob = dateTimePicker1.Text;
                newUser.martialStatus = comboBox1.Text;
                newUser.jobTitle = textBox5.Text;
                newUser.department = textBox6.Text;
                newUser.languages = new Dictionary<string, int> {
                    {"Arabic", Convert.ToInt32(numericUpDown1.Value)},
                    {"English", Convert.ToInt32(numericUpDown2.Value)}};
                newUser.skills = this.skills;

                Users.users.Add(newUser);
            }

            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                skills.Add(checkBox1.Text);
            }
            else
            {
                skills.Remove(checkBox1.Text);
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                skills.Add(checkBox4.Text);
            }
            else
            {
                skills.Remove(checkBox4.Text);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                skills.Add(checkBox3.Text);
            }
            else
            {
                skills.Remove(checkBox3.Text);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                skills.Add(checkBox2.Text);
            }
            else
            {
                skills.Remove(checkBox2.Text);
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
            {
                skills.Add(checkBox12.Text);
            }
            else
            {
                skills.Remove(checkBox12.Text);
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                skills.Add(checkBox8.Text);
            }
            else
            {
                skills.Remove(checkBox8.Text);
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                skills.Add(checkBox5.Text);
            }
            else
            {
                skills.Remove(checkBox5.Text);
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                skills.Add(checkBox7.Text);
            }
            else
            {
                skills.Remove(checkBox7.Text);
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                skills.Add(checkBox6.Text);
            }
            else
            {
                skills.Remove(checkBox6.Text);
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                skills.Add(checkBox11.Text);
            }
            else
            {
                skills.Remove(checkBox11.Text);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            progressBar1.Value = Convert.ToInt32(numericUpDown1.Value);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            progressBar2.Value = Convert.ToInt32(numericUpDown2.Value);
        }
    }
}
