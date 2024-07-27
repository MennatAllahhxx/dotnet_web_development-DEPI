using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{

    public class Manager : Person, IWorker
    {
        public string password { get; set; }
        public string username { get; set; }
        public string role { get; set; }
        public string jobTitle { get; set; }
        public string department { get; set; }
        public List<string> skills { get; set; }
        public Dictionary<string, int> languages { get; set; }

        public Manager()
        {
            role = "Manager";
        }

        public Manager(string firstName, string lastName, string username,
            string password, string gender, string dob,
            string martialStatus, string jobTitle,
            string department, List<string> skills, Dictionary<string, int> languages)
        {
            role = "Manager";
            this.firstName = firstName;
            this.lastName = lastName;
            this.username = username;
            this.password = password;
            this.gender = gender;
            this.dob = dob;
            this.martialStatus = martialStatus;
            this.jobTitle = jobTitle;
            this.department = department;
            this.skills = skills;
            this.languages = languages;
        }
    }
}
