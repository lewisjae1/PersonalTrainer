using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalTrainer.Models
{
    /// <summary>
    /// Inquiries which belongs to specific trainers and clients.
    /// </summary>
    public class Inquiry
    {
        /// <summary>
        /// Inquiry id
        /// </summary>
        [Key]
        public int InquiryId { get; set; }
        /// <summary>
        /// TrainerId that is linked to trainer table
        /// </summary>
        [ForeignKey("Trainer")]
        public int? TrainerId { get; set; }
        public Trainer Trainer { get; set; }
        /// <summary>
        /// UserId that is linked to the user table
        /// </summary>
        [ForeignKey("MyCustomUser")]
        public string? Id { get; set; }
        public MyCustomUser MyCustomUser { get; set; }
        /// <summary>
        /// Feet in height
        /// </summary>
        [Display(Name = "Feet"), Required]
        public int? Feet { get; set; }
        /// <summary>
        /// Inches in height
        /// </summary>
        [Display(Name = "Inches"), Required]
        public int? Inches { get; set; }
        /// <summary>
        /// Weight in lbs
        /// </summary>
        [Display(Name = "lbs"), Required]
        public double? Weight { get; set; }
        /// <summary>
        /// Message from client to trainers
        /// </summary>
        [Display(Name = "Message"), Required]
        public string? Message { get; set; }
        /// <summary>
        /// Inquiry status
        /// </summary>
        public string? Status { get; set; }

        public ICollection<WorkoutPlan> workoutPlans { get; set; }
    }
}
