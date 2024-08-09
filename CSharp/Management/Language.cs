using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management
{
    public class Language
    {
        public int languageID { get; set; }
        public string languageName { get; set; }
        public int proficiency { get; set; }
        public int personID { get; set; }
        [ForeignKey("personID")]
        public virtual Person Person { get; set; }
    }
}
