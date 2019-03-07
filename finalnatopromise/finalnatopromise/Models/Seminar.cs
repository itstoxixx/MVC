using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace finalnatopromise.Models
{
    public class Seminar
    {
        public int SeminarID { get; set; }
        public string Title { get; set; }
     
        public int Price { get; set; }
      
        public DateTime SeminarDate { get; set; }

        public virtual ICollection<Attendee> Attendees { get; set; }
    }
}