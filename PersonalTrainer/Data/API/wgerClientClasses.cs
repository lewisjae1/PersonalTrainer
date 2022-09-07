using System.Net;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace PersonalTrainer.Data.API
{
    public class wgerClient
    {
        private static readonly HttpClient _client;

        /// <summary>
        /// constructor that calls the Web API
        /// </summary>
        static wgerClient()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://wger.de");
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        /// <summary>
        /// Calls exercise categories from the API
        /// </summary>
        /// <returns>Returns Exercise categories as a list</returns>
        public async static Task<IEnumerable<Category>> getExerciseCategories()
        {
            HttpResponseMessage response = await _client.GetAsync("api/v2/exercisecategory/?language=2");

            if (response.IsSuccessStatusCode)
            {
                var data = JsonConvert.DeserializeObject<ExerciseCategories>(await response.Content.ReadAsStringAsync());
                var allCategories = data.Results;
                return allCategories;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// Calls the Exercises from the API
        /// </summary>
        /// <returns>Returns the exercises from API as a list</returns>
        public async static Task<IEnumerable<ExerciseInfo>> getExercises()
        {
            HttpResponseMessage response = await _client.GetAsync("api/v2/exercise/?language=2");

            if (response.IsSuccessStatusCode)
            {
                var data = JsonConvert.DeserializeObject<Exercise>(await response.Content.ReadAsStringAsync());
                var allCategories = data.Results;
                return allCategories;
            }
            else
            {
                return null;
            }
        }
    }
}
