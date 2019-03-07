using finalnatopromise.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace finalnatopromise.DAL
{
    public class PoresContext : DbContext
    {

        public PoresContext()
            : base("PoresContext")
        {
        }

        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Seminar> Seminars { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}