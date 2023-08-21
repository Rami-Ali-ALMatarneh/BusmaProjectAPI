using BusmaProjectAPI.Extensions;
using BusmaProjectAPI.Model.Models;
using BusmaProjectAPI.Model.Models.Accounts;
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
            modelBuilder.RelationShipUserTask();
            modelBuilder.SetUniqueProgrammingLanguage();
            modelBuilder.RelationShipUserAttendance();
            }
        public DbSet<User> Users { get; set; }
        public DbSet<task> Tasks { get; set; }
        public DbSet<RegisterAttendance> Attendances { get; set; }
        }
    }
