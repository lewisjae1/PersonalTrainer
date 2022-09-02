using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalTrainer.Models
{
    public class Inquiry
    {
        [Key]
        public int InquiryId { get; set; }

        [ForeignKey("Trainer")]
        public int? TrainerId { get; set; }
        public Trainer Trainer { get; set; }

        [ForeignKey("MyCustomUser")]
        public string? Id { get; set; }
        public MyCustomUser MyCustomUser { get; set; }

        [Display(Name = "Feet"), Required]
        public int? Feet { get; set; }

        [Display(Name = "Inches"), Required]
        public int? Inches { get; set; }

        [Display(Name = "lbs"), Required]
        public double? Weight { get; set; }

        [Display(Name = "Message"), Required]
        public string? Message { get; set; }

        public string? Status { get; set; }

        public ICollection<WorkoutPlan> workoutPlans { get; set; }
    }
}
