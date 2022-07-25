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
}
