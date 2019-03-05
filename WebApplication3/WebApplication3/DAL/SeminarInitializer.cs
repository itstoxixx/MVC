using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApplication3.Models;

namespace WebApplication3.DAL
{
    public class SeminarInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SeminarContext>
    {
        protected override void Seed(SeminarContext context)
        {
            var seminar = new List<Seminar>
            {
            new Seminar{Name="Cyber Security",Date=DateTime.Parse("2019-03-01"),Price=150, Slot=100},
            
            };

            seminar.ForEach(s => context.Seminars.Add(s));
            context.SaveChanges();

            var attendees = new List<Attendee>
            {
            new Attendee{Name="Justine joy Ibanez",Date=DateTime.Parse("2019-03-01")},
           
            };
            attendees.ForEach(s => context.Attendees.Add(s));
            context.SaveChanges();
           
        }
    }
}