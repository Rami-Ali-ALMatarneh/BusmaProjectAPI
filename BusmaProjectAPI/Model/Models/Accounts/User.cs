using BusmaProjectAPI.Model.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusmaProjectAPI.Model.Models.Accounts
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Major { get; set; }
        public TypeOfTraining TypeOfTraining { get; set; }
        public ProgrammingLanguage ProgrammingLanguage { get; set; }
        public List<task> Tasks { get; set; }
        [ForeignKey("IdentityUser")]
        public string UserId { get; set; }
        public Account Identity { get; set; }
        public RegisterAttendance RegisterAttendance { get; set; }
        }
    }
