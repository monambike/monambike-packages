using Monambike.Core.Data;
using Newtonsoft.Json;

namespace Monambike.Core.Models
{
    public class GithubProjects
    {
        /// <summary>
        /// HttpClient for making api requests.
        /// </summary>
        readonly static HttpClient HttpClient = new() { BaseAddress = new Uri("https://api.github.com/repos/") };

        //internal static async Task<GithubResponse> Get()
        //{
        //    var response = await HttpService.GetAsync(HttpClient, $"monambike");
        //    return JsonConvert.DeserializeObject<GithubResponse>(response);
        //}

        internal class GithubResponse
        {
            [JsonProperty("name")]
            internal string Name { get; set; }

            [JsonProperty("private")]
            internal bool Private { get; set; }

            [JsonProperty("html_url")]
            internal string Url { get; set; }

            [JsonProperty("language")]
            internal string Language { get; set; }

            [JsonProperty("created_at")]
            internal string CreateDate { get; set; }

            [JsonProperty("pushed_at")]
            internal string PushDate { get; set; }
        }
    }
}
