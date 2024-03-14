using curewellApp.Models;
using Microsoft.EntityFrameworkCore;

namespace curewellApp.Database
{
    public class CureWellDbContext : DbContext
    {
        public CureWellDbContext(DbContextOptions<CureWellDbContext> options):base(options)
        {

        }

        public DbSet<Doctor> Doctors{get;set;}
        public DbSet<Surgery> Surgeries{get;set;}
        public DbSet<Specialization> Specializations{get;set;}
        public DbSet<DoctorSpecialization> DoctorSpecializations{get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {            
            modelBuilder.Entity<DoctorSpecialization>().HasKey(b=> new {b.DoctorId,b.SpecializationId});    
        }

    }
}