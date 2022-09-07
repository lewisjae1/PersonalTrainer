using Microsoft.AspNetCore.Identity;
using PersonalTrainer.Data;
using System.ComponentModel.DataAnnotations;

namespace PersonalTrainer.Models
{
    /// <summary>
    /// More elements added to the user table 
    /// </summary>
    public class MyCustomUser : IdentityUser
    {
        /// <summary>
        /// Gender of the user
        /// </summary>
        [Required]
        public string Gender { get; set; }
        /// <summary>
        /// First name of the user
        /// </summary>
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        /// <summary>
        /// Last name of the user
        /// </summary>
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        /// <summary>
        /// Date of Birth for the user
        /// </summary>
        [Required]
        [Display(Name = "Date of Birth")]
        public DateTime DateofBirth { get; set; }
        /// <summary>
        /// Photo URL for the user's profile picture
        /// </summary>
        [Display(Name = "Profile Picture")]
        public string UserPhotoURL { get; set; }

        public ICollection<Trainer> Trainers { get; set; }

        public ICollection<Inquiry> Inquiries { get; set; }

        public ICollection<WorkoutPlan> workoutPlans { get; set; }
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
