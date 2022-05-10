using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace PersonalTrainer.Models
{
    public class MyCustomUser : IdentityUser
    {
        [Required]
        public string Gender { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime DateofBirth { get; set; }
    }
}
