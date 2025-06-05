using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Progreso2Ruales.Services
{
    public class JokesApi
    {
        private readonly HttpClient _httpClient;

        public JokesApi()
        {
            _httpClient = new HttpClient();
        }

        public async Task<Chiste> GetRandomJokeAsync()
        {
            return await _httpClient.GetFromJsonAsync<Chiste>("https://official-joke-api.appspot.com/random_joke");
        }
    }

    public class Chiste
    {
        public string Type { get; set; }
        public string Setup { get; set; }
        public string Punchline { get; set; }
    }
}
