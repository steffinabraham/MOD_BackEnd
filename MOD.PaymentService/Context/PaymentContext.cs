using Microsoft.EntityFrameworkCore;
using MOD.PaymentService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.PaymentService.Context
{
    public class PaymentContext : DbContext
    {

        public PaymentContext(DbContextOptions<PaymentContext> options) : base(options) { }
        public DbSet<Payment> Payment { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=DESKTOP-J33QLHE\SQLDB;Database=MOD_DB;Trusted_Connection=True;");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Payment>().HasData(new Payment
            {
                PaymentId = 12,
                UserId = 101,
                MentorId = 201,
                Amount = 4,
                MentorAmount = 3,

            }
                );

        }

    }
}
