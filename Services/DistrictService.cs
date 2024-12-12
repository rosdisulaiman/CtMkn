// DistrictService.cs
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CtMkn.Models;

namespace CtMkn.Services
{
    public class DistrictService
    {
        private readonly HttpClient _httpClient;

        public DistrictService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // Fetch the list of districts for a given state
        public async Task<(List<Daerah> daerahList, string errorMessage)> GetDaerahByStateAsync(int stateId)
        {
            try
            {
                // Adjust the API URL to include the stateId
                var response = await _httpClient.GetFromJsonAsync<List<Daerah>>($"https://mkn.smammoth.com/api/daerah?state={stateId}");
                return (response, null);
            }
            catch (HttpRequestException ex)
            {
                return (null, $"Error fetching data: {ex.Message}");
            }
            catch (Exception ex)
            {
                return (null, $"Unexpected error: {ex.Message}");
            }
        }
    }
}
