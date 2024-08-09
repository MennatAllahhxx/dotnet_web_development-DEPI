using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management
{
    public abstract class Person
    {
        public int personID { get; set; }

        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public string dob { get; set; }
        public string martialStatus { get; set; }

        public virtual ICollection<Skill> skills { get; set; }
        public virtual ICollection<Language> languages { get; set; }
    }
}
