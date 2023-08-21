using BusmaProjectAPI.Model.Models;
using BusmaProjectAPI.Model.Models.Accounts;
using Microsoft.EntityFrameworkCore;

namespace BusmaProjectAPI.Extensions
{
    public static class ModelBuliderExtension
        {
        public static void RelationShipUserTask( this ModelBuilder modelBuilder )
            {
            modelBuilder.Entity<User>()
              .HasMany(e => e.Tasks)
              .WithOne(e => e.User)
              .HasForeignKey(e => e.UserId);
            }
        public static void SetUniqueProgrammingLanguage( this ModelBuilder modelBuilder )
            {
            modelBuilder.Entity<User>()
                .HasIndex(e => e.ProgrammingLanguage)
                .IsUnique();
            }
        public static void RelationShipUserAttendance( this ModelBuilder modelBuilder )
            {
            //SET 1 or 0 RelationShip
            modelBuilder.Entity<User>()
              .HasOne(e => e.RegisterAttendance)
              .WithOne(e => e.User)
              .HasForeignKey<RegisterAttendance>(e => e.UserId)
              .OnDelete(DeleteBehavior.Restrict);
            }
        }
    }
