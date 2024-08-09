using Management;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Management
{
    public partial class Login : Form
    {
        private readonly ApplicationDBContext _context;

        public Login()
        {
            InitializeComponent();
            _context = new ApplicationDBContext();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var usernameInput = textBox1.Text;
            var passwordInput = textBox2.Text;

            // Check in Employees
            var employee = _context.Employees
                .FirstOrDefault(emp => emp.username == usernameInput && emp.password == passwordInput);

            if (employee != null)
            {
                Console.WriteLine("Welcome " + employee.firstName);
                var profile = new EmployeeProfile(employee);


                this.Hide();
                profile.Show();
                return;
            }

            var manager = _context.Managers
                .FirstOrDefault(mgr => mgr.username == usernameInput && mgr.password == passwordInput);

            if (manager != null)
            {
                Console.WriteLine("Welcome " + manager.firstName);
                var profile = new ManagerProfile(manager);
                this.Hide();
                profile.Show();
                return;
            }

            Console.WriteLine("Incorrect username or password");
        }
    }
}
