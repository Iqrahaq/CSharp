using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstEF
{
    public class Module
    {
        public Module()
        {
            Students = new List<Student>();
            Assessment = new List<Assessment>();
        }

        [Key]
        public int ModuleId { get; set; }
        [MaxLength(20)]
        public String ModuleCode { get; set; }
        [MaxLength(20)]
        public String ModuleName { get; set; }
        public int Level { get; set; }
        [MaxLength(20)]
        public virtual ICollection<Student> Students { get; set; }
        [MaxLength(20)]
        public virtual ICollection<Assessment> Assessment { get; set; }
    }
}
