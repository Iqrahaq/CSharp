using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstEF
{
    public class Student
    {
        public Student()
        {
            Modules = new List<Module>();
            Assessments = new List<Assessment>();
        }

        [Key]
        public int StudentId { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        [MaxLength(20)]
        public string Email { get; set; }
        [MaxLength(20)]
        public virtual Address Address { get; set; }
        [MaxLength(20)]
        public virtual ICollection<Module> Modules { get; set; }
        [MaxLength(20)]
        public virtual ICollection<Assessment> Assessments { get; set; }
    }


}
