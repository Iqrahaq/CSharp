using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstEF
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }
        [MaxLength(20)]
        public String NumberorName { get; set; }
        [MaxLength(20)]
        public String Street { get; set; }
        [MaxLength(20)]
        public String Town { get; set; }
        [MaxLength(20)]
        public String PostCode { get; set; }
    }
}
