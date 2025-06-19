using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Business_License__main.Controllers
{
    [Route("ChatBot")]
    public class ChatBotController : Controller
    {
        [HttpPost("Ask")]
        public async Task<IActionResult> Ask([FromBody] ChatRequest request)
        {
            string apiKey = "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"; // Replace with your real key

            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

            var requestBody = new
            {
                model = "openai/gpt-3.5-turbo",
                messages = new[]
                {
                    new { role = "system", content = "You are a helpful assistant for business license applications." },
                    new { role = "user", content = request.Question }
                }
            };

            var content = new StringContent(JsonSerializer.Serialize(requestBody), Encoding.UTF8, "application/json");

            var response = await client.PostAsync("https://openrouter.ai/api/v1/chat/completions", content);
            var responseString = await response.Content.ReadAsStringAsync();

            using var doc = JsonDocument.Parse(responseString);
            var answer = doc.RootElement.GetProperty("choices")[0].GetProperty("message").GetProperty("content").GetString();

            return Json(new { answer });
        }
    }

    public class ChatRequest
    {
        public string Question { get; set; }
    }
}
