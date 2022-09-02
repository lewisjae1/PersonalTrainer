using PersonalTrainer.Data.API;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalTrainer.Models
{
    public class WorkoutPlan
    {
        [Key]
        public int WorkoutPlanId { get; set; }

        [ForeignKey("Inquiry")]
        public int InquiryId { get; set; }
        public Inquiry Inquiry { get; set; }

        [ForeignKey("Trainer")]
        public int TrainderId { get; set; }
        public Trainer Trainer { get; set; }

        [ForeignKey("MyCustomUser")]
        public string Id { get; set; }
        public MyCustomUser MyCustomUser { get; set; }

        public DateTime WeekOf { get; set; }

        public string DayOfWeek { get; set; }

        public string Exercise { get; set; }

        public int Set { get; set; }

        public int Rep { get; set; }

        public string RepUnit { get; set; }

        public double Weight { get; set; }

        public string WeightUnit { get; set; }
    }
}
