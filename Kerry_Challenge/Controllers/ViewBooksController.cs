using Kerry_Challenge.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;

namespace Kerry_Challenge.Controllers
{
    public class ViewBooksController : Controller
    {
        [HttpGet("books")]
        public async Task<ActionResult> ViewData()
        {
            try
            {
                string url = "https://api.itbook.store/1.0/search/mysql";
                var client = new HttpClient();
                GetDefaultRequestHeaders(client).Add("accept_token", "");
                var response = await client.GetAsync(url);
                var resultContent = await response.Content.ReadAsStringAsync();
                JObject jsonResponse = JObject.Parse(resultContent);
                var list = JsonConvert.DeserializeObject<List<BookModel>>(jsonResponse["books"].ToString());
                return Ok(list);
            }
            catch
            {
                return BadRequest("Load data error.");
            }
        }

        private static HttpRequestHeaders GetDefaultRequestHeaders(HttpClient client)
        {
            return client.DefaultRequestHeaders;
        }
    }
}
