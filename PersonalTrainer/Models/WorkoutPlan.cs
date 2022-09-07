using PersonalTrainer.Data.API;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalTrainer.Models
{
    /// <summary>
    /// Workout plan class
    /// </summary>
    public class WorkoutPlan
    {
        /// <summary>
        /// Unique Id for workout
        /// </summary>
        [Key]
        public int WorkoutPlanId { get; set; }
        /// <summary>
        /// Inquiry Id that is linked to the workout
        /// </summary>
        [ForeignKey("Inquiry")]
        public int InquiryId { get; set; }
        public Inquiry Inquiry { get; set; }
        /// <summary>
        /// Trainer Id that is linked to the workout
        /// </summary>
        [ForeignKey("Trainer")]
        public int TrainderId { get; set; }
        public Trainer Trainer { get; set; }
        /// <summary>
        /// User Id for client that is linked to the workout 
        /// </summary>
        [ForeignKey("MyCustomUser")]
        public string Id { get; set; }
        public MyCustomUser MyCustomUser { get; set; }
        /// <summary>
        /// Week that the workout belongs to
        /// </summary>
        public DateTime WeekOf { get; set; }
        /// <summary>
        /// Day of the week that workout belongs to
        /// </summary>
        public string DayOfWeek { get; set; }
        /// <summary>
        /// Name of the exercise
        /// </summary>
        public string Exercise { get; set; }
        /// <summary>
        /// Number of Sets
        /// </summary>
        public int Set { get; set; }
        /// <summary>
        /// Number of Reps
        /// </summary>
        public int Rep { get; set; }
        /// <summary>
        /// Unit of the reps
        /// </summary>
        public string RepUnit { get; set; }
        /// <summary>
        /// Number of Weight
        /// </summary>
        public double Weight { get; set; }
        /// <summary>
        /// Unit of the weight
        /// </summary>
        public string WeightUnit { get; set; }
    }
}
