using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace PersonalTrainer.Models
{
    public class MyCustomUser : IdentityUser
    {
        [Required]
        public string Gender { get; set; }
    }
}
