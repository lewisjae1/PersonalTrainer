using Newtonsoft.Json;

namespace PersonalTrainer.Data.API
{
    public class Exercise
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public ExerciseInfo[] Results { get; set; }
    }

    public class ExerciseInfo
    {
        public int id { get; set; }

        public string uuid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("exercise_base")]
        public int ExerciseBase { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("creation_date")]
        public string CreationDate { get; set; }

        [JsonProperty("category")]
        public int Category { get; set; }

        [JsonProperty("muscles")]
        public int[] Muscles { get; set; }

        [JsonProperty("muscles_secondary")]
        public int[] MusclesSecondary { get; set; }

        [JsonProperty("equipment")]
        public int[] Equipment { get; set; }

        [JsonProperty("language")]
        public int Language { get; set; }

        [JsonProperty("license")]
        public int License { get; set; }

        [JsonProperty("license_author")]
        public string LicenseAuthor { get; set; }

        [JsonProperty("variations")]
        public int[] Variations { get; set; }
    }
}
