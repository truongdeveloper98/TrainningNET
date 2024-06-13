using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Trainning.Core.Entities;

namespace Tranning.Infrastructure
{
    public class StudentManagerDbContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public StudentManagerDbContext(DbContextOptions<StudentManagerDbContext> options) : base(options) { }

     
     
       public DbSet<Student> students { get; set; }

        public DbSet<Class> classes { get; set; }
        public DbSet<StudentInClass> studentInClasses {get;set;}
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Class>()
                .HasMany(x => x.studentInClasses)
                .WithOne(x => x.Classes)
                .HasForeignKey(x=>x.ClassId);
            builder.Entity<Student>()
                .HasMany(x => x.studentInClasses)
                .WithOne(x => x.Students)
                .HasForeignKey(x => x.StudentId);

            builder.Entity<Class>().HasData(new Class 
            {
                Id = 1,
                Name = "3A",
                Description = "Test"
            });

            builder.Entity<Student>().HasData(new Student
            {
                Id = 1, 
                Name = "Test",  
                Age = 14,
                Adress = "NamSach",
                Description = "Test",
                Email = "EmailTest",
                PhoneNumber = "0334215783",
                
            });
        }


    }
}