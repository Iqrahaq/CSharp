// Iqra Haq [w16011654] & Simran Gibson [w15035649]

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;
using Assignment.Domain_Layer;

namespace Assignment
{
    public class Appointment
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AppointmentId { get; set; }

        [NotMapped]
        public Consult AppointmentType;

        [Column("AppointmentType")]
        public string TypeString
        {
            get { return AppointmentType.ToString(); }
            set { AppointmentType = (Consult)Enum.Parse(typeof(Consult), value, true); }
        }

        [Column("AppointmentDate")]
        public DateTime _AppointmentDate { get; set; }
        [NotMapped]
        public DateTime AppointmentDate
        {
            get
            {
                return _AppointmentDate.Date;
            }
            set
            {
                if (Regex.IsMatch(value.Date.ToString("dd-MM-yyyy"), @"^([0-2][0-9]|(3)[0-1])(-)(((0)[0-9])|((1)[0-2]))(-)\d{4}$"))
                {
                    _AppointmentDate = value.Date;
                }
            }
        }

        [Column("AppointmentTime")]
        public string _AppointmentTime { get; set; }
        [NotMapped]
        public string AppointmentTime
        {
            get
            {
                return _AppointmentTime;
            }
            set
            {
                //RegEx from https://stackoverflow.com/questions/7536755/regular-expression-for-matching-hhmm-time-format
                if (Regex.IsMatch(value, @"^([0-1]?[0-9]|2[0-3]):[0-5][0-9]$"))
                {
                    _AppointmentTime = value;
                }
            }
        }

        [Column("AppointmentDentist")]
        public string _AppointmentDentist { get; set; }
        [NotMapped]
        public string AppointmentDentist
        {
            get
            {
                return _AppointmentDentist;
            }
            set
            {
                _AppointmentDentist = value;
            }
        }

        [Column("AppointmentNotes")]
        public string _AppointmentNotes { get; set; }
        [NotMapped]
        public string AppointmentNotes
        {
            get
            {
                return _AppointmentNotes;
            }
            set
            {
                _AppointmentNotes = value;
            }
        }

        public virtual Person People { get; set; }

        public enum Consult
        {
            Checkups, 
            Other
        }

    }
}
