using QuizApp.Repository;
using System;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace QuizApp.Connector
{
    public class QuizRequest
    {
        public QuizRequest()
        {
            this.client = new();
        }
        private HttpClient client;
        private string[] claimsDifficultyArray = new string[] { "easy", "medium", "hard" };
        public int amountOfClaims;
        private string claimsDifficulty;

        public int AmountOfClaims {
            get => amountOfClaims;
            set {
                if (value >= 3 && value <= 20) {
                    amountOfClaims = value;
                } else {
                    amountOfClaims = 3;
                }
            }
        }
        public string ClaimsDifficulty {
            get => claimsDifficulty;
            set {
                if (claimsDifficultyArray.Contains(value)) {
                    claimsDifficulty = value;
                } else {
                claimsDifficulty = "easy";
                }
            }
        }

        public async Task<List<QuizModel>> GetQuizAsync()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.GetAsync($"https://opentdb.com/api.php?amount={AmountOfClaims}&difficulty={ClaimsDifficulty}&type=boolean");
            response.EnsureSuccessStatusCode();
            var responseModel = await response.Content.ReadFromJsonAsync<JsonResponse>();

            return responseModel.Models;
        }
    }
}
