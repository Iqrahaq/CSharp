// Iqra Haq [w16011654] & Simran Gibson [w15035649]

using Assignment;
using Assignment.Domain_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Domain_Layer
{
    public class GP
    {
        public GP()
        {
            People = new List<Person>();
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GPId { get; set; }

        [Column("GPPractice")]
        public string _GPPractice { get; set; }
        [NotMapped]
        public string GPPractice
        {
            get
            {
                return _GPPractice;
            }
            set
            {
                if (Regex.IsMatch(value, @"^.{1,30}$"))
                {
                    _GPPractice = value;
                }
            }
        }
                
        public virtual ICollection<Person> People { get; set; }

    }
}
