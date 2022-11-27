using System.Text.Json.Serialization;
using System.Web;

namespace QuizApp.Repository
{
    public class QuizModel
    {
        private string question;

        [JsonPropertyName("category")]
        public string Category { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("difficulty")]
        public string Difficulty { get; set; }

        [JsonPropertyName("question")]
        public string Question { get => HttpUtility.HtmlDecode(question); set => question = value; }

        [JsonPropertyName("correct_answer")]
        public string CorrectAnswer { get; set; }

        [JsonPropertyName("incorrect_answers")]
        public string[] IncorrectAnswers { get; set; }
    }
}