using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalTrainer.Models
{
    public class Trainer
    {
        public int TrainerId { get; set; }

        [ForeignKey("MyCustomUser")]
        public string userId { get; set; }
        public MyCustomUser MyCustomUser { get; set; }

        public bool Listed { get; set; }
    }
}
