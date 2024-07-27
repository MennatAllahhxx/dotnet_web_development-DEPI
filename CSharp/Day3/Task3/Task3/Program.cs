using System.Drawing.Text;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Task3;

public class Program
{
    static void Main()
    {
        Users.users = new List<Person>();

        Manager menna = new Manager();
        menna = setupAdmin(menna);
        Users.users.Add(menna);

        Users.users = setupUsers(Users.users);

        ApplicationConfiguration.Initialize();
        Application.Run(new Login());
    }

    static Manager setupAdmin(Manager manager)
    {
        manager.firstName = "menna";
        manager.lastName = "hassan";
        manager.username = "admin";
        manager.password = "test1234";
        manager.gender = "Female";
        manager.dob = "Friday 10/11/2000";
        manager.martialStatus = "Single";
        manager.jobTitle = "software teser";
        manager.department = "software development";
        manager.skills = new List<string>{ "C", "Python", "C#", "Java" };
        manager.languages = new Dictionary<string, int> { {"Arabic", 90}, {"English", 80}};

        return manager;
    }

    static List<Person> setupUsers(List<Person> users)
    {
        users.Add(new Employee("Ahmed", "Samir", "ahmed1",
            "ahmed1", "Male", "Thursday 27/09/2001", "Married", "DevOps Engineer",
            "DevOps", new List<string> { "Python", "Bash", "CI/CD"},
            new Dictionary<string, int> { { "Arabic", 100}, {"English", 75}}));

        users.Add(new Employee("Mohamed", "Ali", "mhmd1",
            "mhmd1", "Male", "Friday 01/01/1999", "Single", "Backend Developer",
            "Software Development", new List<string> { ".NET", "C#" },
            new Dictionary<string, int> { { "Arabic", 90 }, { "English", 60 } }));
        
        users.Add(new Manager("Sally", "Ashraf", "sally1",
            "sally1", "Female", "25/03/1998", "Married", "HR Manager",
            "Human Resources", new List<string> { "Finance", "Flexibilty" },
            new Dictionary<string, int> { { "Arabic", 50 }, { "English", 95} }));

        return users;
    }
}