using Microsoft.AspNetCore.Identity;
using PersonalTrainer.Data;
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

        public ICollection<Trainer> Trainers { get; set; }
    }

    public class HomeViewModel
    {
        public List<MyCustomUser> CustomUsers { get; set; }

        public HomeViewModel(List<MyCustomUser> customUsers)
        {
            CustomUsers = customUsers;
        }
    }
}
