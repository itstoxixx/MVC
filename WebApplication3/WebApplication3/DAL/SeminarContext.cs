using WebApplication3.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace WebApplication3.DAL
{
    public class SeminarContext : DbContext
    {

        public SeminarContext()
            : base("SeminarContext")
        {
        }

        public DbSet<Seminar> Seminars { get; set; }
        public DbSet<Attendee> Attendees { get; set; }
       

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}