// Iqra Haq [w16011654] & Simran Gibson [w15035649]

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.Domain_Layer;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;
using Domain_Layer;

namespace Assignment.Domain_Layer
{
    public class Person
    {
        public Person()
        {
            Appointments = new List<Appointment>();
        }
        //Conversions from string to Enum for database storage.
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonId { get; set; }

        [NotMapped]
        public Member PersonMember { get; set; }

        [Column("Type")]
        public string PersonMemberString
        {
            get { return PersonMember.ToString(); }
            set { PersonMember = (Member)Enum.Parse(typeof(Member), value, true); }
        }

        [NotMapped]
        public Prefix Title { get; set; }

        [Column("Title")]
        public string TitleString
        {
            get { return Title.ToString(); }
            set { Title = (Prefix)Enum.Parse(typeof(Prefix), value, true); }
        }

        [Column("FirstName")]
        public string _FirstName { get; set; }
        [NotMapped]
        public string FirstName 
        {
            get 
            {
                return _FirstName;
            }
            set 
            {
                if (Regex.IsMatch(value, @"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)$"))
                {
                    _FirstName = value;
                }
            } 
        }

        [Column("MiddleName")]
        public string _MiddleName { get; set; }
        [NotMapped]
        public string MiddleName
        {
            get
            {
                return _MiddleName;
            }
            set
            {
                if (Regex.IsMatch(value, @"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)$"))
                {
                    _MiddleName = value;
                }
            }
        }

        [Column("LastName")]
        public string _LastName { get; set; }
        [NotMapped]
        public string LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                if (Regex.IsMatch(value, @"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)$"))
                {
                    _LastName = value;
                }
            }
        }

        [NotMapped]
        // Regex expression from https://www.regextester.com/99555
        public Gender PersonGender { get; set; }

        [Column("Gender")]
        public string GenderString
        {
            get { return PersonGender.ToString(); }
            set { PersonGender = (Gender)Enum.Parse(typeof(Gender), value, true); }
        }

        [Column("PersonDOB")]
        public DateTime _PersonDOB { get; set; }
        [NotMapped]
        public DateTime PersonDOB
        {
            get 
            {
                return _PersonDOB;
            }
            set
            {
                if (Regex.IsMatch(value.ToString("dd-MM-yyyy"), @"^([0-2][0-9]|(3)[0-1])(-)(((0)[0-9])|((1)[0-2]))(-)\d{4}$"))
                {
                    _PersonDOB = value.Date;
                }
            } 
        }

        [Column("PrimaryPhone")]
        public string _PrimaryPhone { get; set; }
        //Regex expression from https://stackoverflow.com/questions/44327236/regex-for-uk-phone-number
        [NotMapped]
        public string PrimaryPhone 
        {
            get 
            {
                return _PrimaryPhone;
            }
            set 
            {
                if (Regex.IsMatch(value, @"^(?:0|\+?44)(?:\d\s?){9,10}$"))
                {
                    _PrimaryPhone = value;
                }
            } 
        }

        [Column("SecondaryPhone")]
        public string _SecondaryPhone { get; set; }
        [NotMapped]
        public string SecondaryPhone
        {
            get
            {
                return _SecondaryPhone;
            }
            set
            {
                if (Regex.IsMatch(value, @"^(?:0|\+?44)(?:\d\s?){9,10}$"))
                {
                    _SecondaryPhone = value;
                }
            }
        }

        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual PersonAddress Address { get; set; }
        public virtual GP GP { get; set; }
        
        public enum Gender
        {
            Male,
            Female
        }

        public enum Member
        {
            Patient,
            Receptionist,
            Dentist,
            GP
        }

        public enum Prefix
        {
            Mr,
            Mrs,
            Miss,
            Dr,
            Ms
        }

        public String getFullName()
        {

            if (string.IsNullOrEmpty(MiddleName))
            {
                return String.Join(" ", Title, FirstName, LastName);
            }
            else
            {
                return String.Join(" ", Title, FirstName, MiddleName, LastName);
            }
        }

    }
}