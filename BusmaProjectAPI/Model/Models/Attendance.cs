using BusmaProjectAPI.Model.Models.Accounts;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusmaProjectAPI.Model.Models
    {
    public class RegisterAttendance
        {
        public int Id { get; set; }
        public DateTime LoginAttendance { get; set; } = DateTime.Now;
        public DateTime LogoutAttendance { get; set;}
        public bool StateAttendance { get; set;}
        public int? UserId { get; set; }
        public User User { get; set; }
        }
    }
