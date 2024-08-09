using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Management;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Logging;

namespace Management
{
    public class Program
    {

        [DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        [STAThread]
        static void Main()
        {
            AllocConsole();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var context = new ApplicationDBContext())
            {
                context.Database.Migrate();

                if (!context.Managers.Any())
                {
                    var menna = setupAdmin();
                    context.Managers.Add(menna);
                    var users = setupUsers();
                    users.ForEach(user =>
                    {
                        if (user is Employee) context.Employees.Add((Employee)user);
                        else context.Managers.Add((Manager)user);
                        context.SaveChanges();
                    });                    
                }
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }

        static Manager setupAdmin()
        {
            return new Manager
            {
                firstName = "menna",
                lastName = "hassan",
                username = "admin",
                password = "test1234",
                gender = "Female",
                dob = "Friday 10/11/2000",
                martialStatus = "Single",
                jobTitle = "software tester",
                department = "software development",
                skills = new List<Skill>
                {
                    new Skill { skillName = "c" },
                    new Skill { skillName = "python" },
                    new Skill { skillName = "c#" },
                    new Skill { skillName = "automation" },
                    new Skill { skillName = "java" }
                },
                languages = new List<Language>
                {
                    new Language { languageName = "Arabic", proficiency = 90 },
                    new Language { languageName = "English", proficiency = 80 }
                }
            };
        }

        static List<Person> setupUsers()
        {
            return new List<Person>
            {
                new Employee
                {
                    firstName = "Ahmed",
                    lastName = "Samir",
                    username = "ahmed1",
                    password = "ahmed1",
                    gender = "Male",
                    dob = "Thursday 27/09/2001",
                    martialStatus = "Married",
                    jobTitle = "DevOps Engineer",
                    department = "DevOps",
                    skills = new List<Skill>
                    {
                        new Skill { skillName = "python" },
                        new Skill { skillName = "bash" }
                    },
                    languages = new List<Language>
                    {
                        new Language { languageName = "Arabic", proficiency = 100 },
                        new Language { languageName = "English", proficiency = 75 }
                    }
                },
                new Employee
                {
                    firstName = "Mohamed",
                    lastName = "Ali",
                    username = "mhmd1",
                    password = "mhmd1",
                    gender = "Male",
                    dob = "Friday 01/01/1999",
                    martialStatus = "Single",
                    jobTitle = "Backend Developer",
                    department = "Software Development",
                    skills = new List<Skill>
                    {
                        new Skill { skillName = ".net development" },
                        new Skill { skillName = "c#" }
                    },
                    languages = new List<Language>
                    {
                        new Language { languageName = "Arabic", proficiency = 90 },
                        new Language { languageName = "English", proficiency = 60 }
                    }
                },
                new Manager
                {
                    firstName = "Sally",
                    lastName = "Ashraf",
                    username = "sally1",
                    password = "sally1",
                    gender = "Female",
                    dob = "25/03/1998",
                    martialStatus = "Married",
                    jobTitle = "HR Manager",
                    department = "Human Resources",
                    skills = new List<Skill>
                    {
                        new Skill { skillName = "Communication" },
                        new Skill { skillName = "Motivation" }
                    },
                    languages = new List<Language>
                    {
                        new Language { languageName = "Arabic", proficiency = 50 },
                        new Language { languageName = "English", proficiency = 95 }
                    }
                }
            };
        }

    }

    
}
