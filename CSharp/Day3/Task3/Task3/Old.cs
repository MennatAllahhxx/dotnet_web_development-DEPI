namespace Task3;

public partial class Old : Form
{
    public Old()
    {
        InitializeComponent();
    }
    String gender;
    String name;
    String dob;
    String martialStatus;
    List<String> hobbies = new List<String>();


    private void Form1_Load(object sender, EventArgs e)
    {

    }



    private void textBox1_TextChanged(object sender, EventArgs e)
    {
        name = textBox1.Text;
    }


    private void button1_Click(object sender, EventArgs e)
    {
        richTextBox1.Text = "-----------------Your Information-----------------" + Environment.NewLine + "Name: " + name + Environment.NewLine +"Date of birth: " + dob + Environment.NewLine + "Gender: " + gender + Environment.NewLine + "Martial Status: " + martialStatus + Environment.NewLine + "Hobbies: " + string.Join(", ", hobbies) + Environment.NewLine + "Languages Level: " + Environment.NewLine + "      Arabic Language: " + numericUpDown1.Value + Environment.NewLine + "      English Language: " + numericUpDown2.Value + Environment.NewLine + "---------------------The End---------------------";
    }

    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {
        gender = "Male";
    }

    private void radioButton2_CheckedChanged(object sender, EventArgs e)
    {
        gender = "Female";
    }

    private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
    {
        dob = dateTimePicker1.Text;
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        martialStatus = comboBox1.Text;
    }

    private void numericUpDown1_ValueChanged(object sender, EventArgs e)
    {
        progressBar1.Value = Convert.ToInt32(numericUpDown1.Value);
    }

    private void numericUpDown2_ValueChanged(object sender, EventArgs e)
    {
        progressBar2.Value = Convert.ToInt32(numericUpDown2.Value);
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBox1.Checked)
        {
            hobbies.Add(checkBox1.Text);
        }
        else
        {
            hobbies.Remove(checkBox1.Text);
        }

    }

    private void checkBox2_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBox2.Checked)
        {
            hobbies.Add(checkBox2.Text);
        }
        else
        {
            hobbies.Remove(checkBox2.Text);
        }
    }

    private void checkBox3_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBox3.Checked)
        {
            hobbies.Add(checkBox3.Text);
        }
        else
        {
            hobbies.Remove(checkBox3.Text);
        }
    }

    private void checkBox4_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBox4.Checked)
        {
            hobbies.Add(checkBox4.Text);
        }
        else
        {
            hobbies.Remove(checkBox4.Text);
        }
    }
}
