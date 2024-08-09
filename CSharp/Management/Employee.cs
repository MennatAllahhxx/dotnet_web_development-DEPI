using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management
{
    public class Employee : Person, IWorker
    {
        public string password { get; set; }
        public string username { get; set; }
        public string jobTitle { get; set; }
        public string department { get; set; }

    }
}
