using Microsoft.EntityFrameworkCore;
using MOD.TrainingService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.TrainingService.Context
{
    public class TrainingContext : DbContext
    {

        public TrainingContext(DbContextOptions<TrainingContext> options) : base(options) { }
        public DbSet<Training> Training { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Training>().HasData(new Training
            {
                TrainingId = 12,
                UserId = 101,
                MentorId = 201,
                SkillId = 47890,
                StartDate = DateTime.Parse("09-11-2019"),
                EndDate = DateTime.Parse("09-02-2020"),
                TimeSlot = "evening",
                Status = "almost done",
                Progress = 4,
                Rating = 3,

            }
                );

        }

    }
}
    