using Microsoft.EntityFrameworkCore;
using MOD.TechnologyService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.TechnologyService.Context
{
    public class TechnologyContext : DbContext
    {

        public TechnologyContext(DbContextOptions<TechnologyContext> options) : base(options) { }
        public DbSet<Technology> Technology { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=DESKTOP-J33QLHE\SQLDB;Database=MOD_DB;Trusted_Connection=True;");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Technology>().HasData(new Technology
            {
                SkillId = 12,
                SkillName = "C++",
                TOC = "iiiii",
                Fee = 47890,
                Duration = 2

            }
                );

        }

    }
}
