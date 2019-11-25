using Microsoft.EntityFrameworkCore;
using MOD.AuthenticateService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.AuthenticateService.Context
{
    public class LoginContext : DbContext
    {
        public LoginContext(DbContextOptions<LoginContext> options) : base(options) { }
        public DbSet<Mentor> Mentor { get; set; }
        public DbSet<User> User { get; set; }
    }
}
