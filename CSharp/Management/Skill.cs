using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management
{
    public class Skill
    {
        public int skillID { get; set; }
        public string skillName { get; set; }
        public int personID { get; set; }
        [ForeignKey("personID")]
        public virtual Person Person { get; set; }
    }
}
