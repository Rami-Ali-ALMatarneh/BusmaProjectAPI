using BusmaProjectAPI.Extensions;
using BusmaProjectAPI.Model.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BusmaProjectAPI.Data
{
    public class AppDbContext:IdentityDbContext<Account>
        {
        public AppDbContext( DbContextOptions<AppDbContext> options ) : base(options) { }
        protected override void OnModelCreating( ModelBuilder modelBuilder )
            {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Rship_User_Task();
            }
        public DbSet<User>Users { get; set; }
        public DbSet<task> Tasks { get; set; }
        }
    }
