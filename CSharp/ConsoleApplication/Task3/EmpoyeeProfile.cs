using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Task3
{
    public partial class EmpoyeeProfile : Form
    {
        public Employee employee { get; set; }
        public EmpoyeeProfile()
        {
            InitializeComponent();
        }

        public EmpoyeeProfile(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;

            richTextBox1.Text = "-----------------Your Information-----------------" + Environment.NewLine + "Name: " + employee.firstName + " " + employee.lastName + Environment.NewLine + "Date of birth: " + employee.dob + Environment.NewLine + "Gender: " + employee.gender + Environment.NewLine + "Martial Status: " + employee.martialStatus + Environment.NewLine + "Department: " + employee.department + Environment.NewLine + "Skills: " + string.Join(", ", employee.skills) + Environment.NewLine + "Languages Level: " + Environment.NewLine + "      Arabic Language: " + employee.languages["Arabic"] + Environment.NewLine + "      English Language: " + employee.languages["English"] + Environment.NewLine + "---------------------The End---------------------";
        }

    }
}
