using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalTrainer.Models
{
    /// <summary>
    /// table for the users that has trainer roles
    /// </summary>
    public class Trainer
    {
        /// <summary>
        /// Unique Id for the trainer
        /// </summary>
        [Key]
        public int TrainerId { get; set; }
        /// <summary>
        /// Trainer's user Id
        /// </summary>
        [ForeignKey("MyCustomUser")]
        public string Id { get; set; }
        public MyCustomUser MyCustomUser { get; set; }
        /// <summary>
        /// Status to show if trainer is listed on the market
        /// </summary>
        public bool Listed { get; set; }

        public ICollection<Inquiry> Inquiries { get; set; }

        public ICollection<WorkoutPlan> workoutPlans { get; set; }
    }

    public class TrainerListViewModel
    {
        public TrainerListViewModel(List<Trainer> trainers, List<MyCustomUser> allUsers, int lastPage, int currentPage)
        {
            TrainerList=trainers;
            allUserList = allUsers;
            LastPage=lastPage;
            CurrentPage=currentPage;
        }

        public List<Trainer> TrainerList { get; set; }

        public List<MyCustomUser> allUserList { get; set; }

        public int LastPage { get; set; }

        public int CurrentPage { get; set; }
    }
}
