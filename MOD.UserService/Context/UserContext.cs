using Microsoft.EntityFrameworkCore;
using MOD.UserService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.UserService.Context
{
    public class UserContext : DbContext
    {

        public UserContext(DbContextOptions<UserContext> options) : base(options) { }
        public DbSet<User> User { get; set; }
        public DbSet<Mentor> Mentor { get; set; }
        public DbSet<Training> Training { get; set; }
        public DbSet<Technology> Technology { get; set; }
        public DbSet<Payment> Payment { get; set; }



        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=DESKTOP-JEDOTCT\SQLEXPRESS;Database=MOD_DB;Trusted_Connection=True;");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User
            {
                UserId = 101,
                UserName = "Steffin",
                Email = "steff@g.com",
                Password = "steff",
                Active = true

            });

            modelBuilder.Entity<Mentor>().HasData(new Mentor
            {
                MentorId = 201,
                MentorName = "Abdullah",
                Email = "abd@g.com",
                MobileNo = 9495989956,
                Experience = 2,
                MentorSkills = "Java",
                TimeSlot = "Evening",
                Availability = true,
                Active = true,
                Password = "123"




            }
             );

        }

    }
}
