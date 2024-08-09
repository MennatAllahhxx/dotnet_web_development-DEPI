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
    public partial class ManagerProfile : Form
    {
        public Manager manager { get; set; }

        public ManagerProfile()
        {
            InitializeComponent();
        }

        public ManagerProfile(Manager manager)
        {
            InitializeComponent();
            this.manager = manager;

            richTextBox1.Text = "-----------------Your Information-----------------" + Environment.NewLine + "Name: " + manager.firstName + " " + manager.lastName + Environment.NewLine + "Date of birth: " + manager.dob + Environment.NewLine + "Gender: " + manager.gender + Environment.NewLine + "Martial Status: " + manager.martialStatus + Environment.NewLine + "Department: " + manager.department + Environment.NewLine + "Skills: " + string.Join(", ", manager.skills) + Environment.NewLine + "Languages Level: " + Environment.NewLine + "      Arabic Language: " + manager.languages["Arabic"] + Environment.NewLine + "      English Language: " + manager.languages["English"] + Environment.NewLine + "---------------------The End---------------------";
        }

        private void ManagerProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
