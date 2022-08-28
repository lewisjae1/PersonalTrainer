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
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        public DateTime DateofBirth { get; set; }

        [Display(Name = "Profile Picture")]
        public string UserPhotoURL { get; set; }

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
