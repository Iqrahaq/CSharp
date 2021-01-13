// Iqra Haq [w16011654] & Simran Gibson [w15035649]

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace Assignment.Domain_Layer
{
    public class PersonAddress
    {
        public PersonAddress()
        {
            People = new List<Person>();
        }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonAddressId { get; set; }

        [Column("FirstLine")]
        public string _FirstLine { get; set; }
        [NotMapped]
        public string FirstLine
        {
            get
            {
                return _FirstLine;
            }
            set
            {
                if (Regex.IsMatch(value, @"^[a-zA-Z0-9]+(([',. -][a-zA-Z0-9])?[a-zA-Z0-9]*)*$"))
                {
                    _FirstLine = value;
                }
            }
        }

        [Column("SecondLine")]
        public string _SecondLine { get; set; }
        [NotMapped]
        public string SecondLine
        {
            get
            {
                return _SecondLine;
            }
            set
            {
                if (Regex.IsMatch(value, @"^[a-zA-Z0-9]+(([',. -][a-zA-Z0-9])?[a-zA-Z0-9]*)*$"))
                {
                    _SecondLine = value;
                }
            }
        }

        [Column("ThirdLine")]
        public string _ThirdLine { get; set; }
        [NotMapped]
        public string ThirdLine
        {
            get
            {
                return _ThirdLine;
            }
            set
            {
                if (Regex.IsMatch(value, @"^[a-zA-Z0-9]+(([',. -][a-zA-Z0-9])?[a-zA-Z0-9]*)*$"))
                {
                    _ThirdLine = value;
                }
            }
        }

        [Column("City")]
        public string _City { get; set; }
        [NotMapped]
        public string City
        {
            get
            {
                return _City;
            }
            set
            {
                if (Regex.IsMatch(value, @"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$"))
                {
                    _City = value;
                }
            }
        }

        [Column("County")]
        public string _County { get; set; }
        [NotMapped]
        public string County
        {
            get
            {
                return _County;
            }
            set
            {
                if (Regex.IsMatch(value, @"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$"))
                {
                    _County = value;
                }
            }
        }

        [Column("Postcode")]
        public string _Postcode { get; set; }
        [NotMapped]
        public string Postcode
        {
            get
            {
                return _Postcode;
            }
            set
            {
                // Regex expression from https://ideal-postcodes.co.uk/guides/postcode-validation 
                if (Regex.IsMatch(value, @"^[a-zA-Z]{1,2}\d[a-zA-Z\d]?\s*\d[a-zA-Z]{2}$"))
                {
                    _Postcode = value;
                }
            }
        }

        public virtual ICollection<Person> People { get; set; }

        public string getFullAddress()
        {
            return FirstLine + "\n" + SecondLine + "\n" + ThirdLine + "\n" + City + "\n" + County + "\n" + Postcode;
        }

    }
}
