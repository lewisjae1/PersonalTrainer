using Newtonsoft.Json;

namespace PersonalTrainer.Data.API
{
    public class ExerciseCategories
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public Category[] Results { get; set; }
    }

    public class Category
    {
        public int id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
