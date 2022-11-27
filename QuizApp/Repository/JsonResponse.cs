using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace QuizApp.Repository
{
    internal class JsonResponse
    {
        [JsonPropertyName("response_code")]
        public int ResponseCode { get; set; }
        [JsonPropertyName("results")]
        public List<QuizModel> Models { get; set; }
    }
}
