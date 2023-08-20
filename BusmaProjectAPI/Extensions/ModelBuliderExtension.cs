using BusmaProjectAPI.Model.Models;
using Microsoft.EntityFrameworkCore;

namespace BusmaProjectAPI.Extensions
    {
    public static class ModelBuliderExtension
        {
        public static void Rship_User_Task( this ModelBuilder modelBuilder )
            {
            modelBuilder.Entity<User>()
              .HasMany(e => e.tasks)
              .WithOne(e => e.user)
              .HasForeignKey(e => e.UserId);
            } 
        }
    }
