using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public interface IWorker
    {
        public string password { get; set; }
        public string username { get; set; }
        public string role { get; set; }
        public string jobTitle { get; set; }
        public string department { get; set; }
        public List<string> skills { get; set; }
        public Dictionary<string, int> languages { get; set; }
    }
}
