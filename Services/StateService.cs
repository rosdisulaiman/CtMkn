using CtMkn.Models;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CtMkn.Services
{
    public class StateService
    {
        private readonly HttpClient _httpClient;

        public StateService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<State>> GetStatesAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("https://mkn.smammoth.com/api/state");
                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    throw new HttpRequestException($"Server error (HTTP {response.StatusCode}): {errorContent}");
                }

                return await response.Content.ReadFromJsonAsync<List<State>>();
            }
            catch (HttpRequestException e)
            {
                throw new Exception($"Request error: {e.Message}", e);
            }
        }

        public async Task<List<Daerah>> GetDaerahAsync(int stateId)
        {
            try
            {
                var response = await _httpClient.GetAsync($"https://mkn.smammoth.com/api/daerah?state={stateId}");
                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    throw new HttpRequestException($"Server error (HTTP {response.StatusCode}): {errorContent}");
                }

                return await response.Content.ReadFromJsonAsync<List<Daerah>>();
            }
            catch (HttpRequestException e)
            {
                throw new Exception($"Request error: {e.Message}", e);
            }
        }
    }
}
