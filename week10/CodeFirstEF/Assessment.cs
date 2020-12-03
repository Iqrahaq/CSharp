using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstEF
{
    public class Assessment
    {
        public Assessment()
        {

        }

        [Key]
        public int AssessmentId { get; set; }
        public int Mark { get; set; }
        public DateTime Submitted { get; set; }
        [MaxLength(20)]
        public virtual Student Student { get; set; }
        [MaxLength(20)]
        public virtual Module Module { get; set; }
    }
}
