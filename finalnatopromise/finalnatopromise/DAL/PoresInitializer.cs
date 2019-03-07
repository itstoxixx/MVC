using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using finalnatopromise.Models;

namespace finalnatopromise.DAL
{
    public class PoresInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<PoresContext>
    {
        protected override void Seed(PoresContext context)
        {
            var attendee = new List<Attendee>
            {
            new Attendee{Name="Patricia Delos Reyes",Gender="Female",RegistrationDate=DateTime.Parse("2005-09-01"),SeminarID=1}
          
            };

            attendee.ForEach(s => context.Attendees.Add(s));
            context.SaveChanges();
            var seminar = new List<Seminar>
            {
            new Seminar{SeminarID=1,Title="Chemistry",Price=100,SeminarDate=DateTime.Parse("2005-09-01")}
          
            };
            seminar.ForEach(s => context.Seminars.Add(s));
            context.SaveChanges();
           
        }
    }
}