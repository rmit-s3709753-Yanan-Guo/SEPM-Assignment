using CoffeeBuzz.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeBuzz.Data
{
    public class CoffeeBuzzContext : IdentityDbContext<ApplicationUser>
    {
        public CoffeeBuzzContext(DbContextOptions<CoffeeBuzzContext> options) : base(options)
        { }

        public DbSet<Foods> Foods { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Drinks> Drinks { get; set; }
        public DbSet<size> Sizes { get; set; }
        public DbSet<Coffee> Coffee { get; set; }
    }
}
