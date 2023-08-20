using BusmaProjectAPI.Model.Enums;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusmaProjectAPI.Model.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Major { get; set; }
        public string programmingLanguage { get; set; }
        public TypeOfTraining TypeOfTraining { get; set; }
        public List<task> tasks { get; set; }
        [ForeignKey("IdentityUser")]
        public string UserId { get; set; }
        public Account Identity { get; set; }
    }
}
