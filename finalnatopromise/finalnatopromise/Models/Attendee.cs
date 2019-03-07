using System;
using System.Collections.Generic;

namespace finalnatopromise.Models
{
    public class Attendee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int SeminarID { get; set; }
        public Seminar Seminar { get; set; }
       
    }   
}