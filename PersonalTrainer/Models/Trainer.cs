using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalTrainer.Models
{
    public class Trainer
    {
        [Key]
        public int TrainerId { get; set; }

        [ForeignKey("MyCustomUser")]
        public string Id { get; set; }
        public MyCustomUser MyCustomUser { get; set; }

        public bool Listed { get; set; }
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
