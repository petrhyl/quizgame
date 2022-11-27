using QuizRequest;
using System.Net.Http.Headers;
using System.Net.Http.Json;

HttpClient client;
client = new();
    client.DefaultRequestHeaders.Accept.Clear();
    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

HttpResponseMessage response = await client.GetAsync("https://opentdb.com/api.php?amount=10&difficulty=easy&type=boolean");
response.EnsureSuccessStatusCode();
var json = await response.Content.ReadFromJsonAsync<JsonResponse>();
json.Models.ForEach(item => Console.WriteLine(item.Question + "\n" + item.CorrectAnswer + "\n"));