using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Login : Form
    {
        public string username { get; set; }
        public Login()
        {
            InitializeComponent();
            foreach (var user in Users.users)
            {

                Console.WriteLine(user.firstName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean flag = false;
            foreach (Person user in Users.users)
            {
                if (user is Employee employee && employee.username.Equals(textBox1.Text)
                    && employee.password.Equals(textBox2.Text))
                {
                    Console.WriteLine("Welcome " + employee.firstName);
                    EmpoyeeProfile profile = new EmpoyeeProfile(employee);
                    this.Hide();
                    profile.Show();
                    flag = true;
                    break;
                }
                else if (user is Employee employee1 && employee1.username.Equals(textBox1.Text))
                {
                    Console.WriteLine("incorrect password");
                    flag = true;
                    break;
                }
                else if (user is Manager manager && manager.username.Equals(textBox1.Text)
                    && manager.password.Equals(textBox2.Text))
                {
                    Console.WriteLine("Welcome " + manager.firstName);
                    ManagerProfile profile = new ManagerProfile(manager);
                    this.Hide();
                    profile.Show();
                    flag = true;
                    break;
                }
                else if (user is Manager manager1 && manager1.username.Equals(textBox1.Text))
                {
                    Console.WriteLine("incorrect password");
                    flag = true;
                    break;
                }
            }

            if (!flag)
            {
                Console.WriteLine("This user does not exist");
            }
        }
    }
}
