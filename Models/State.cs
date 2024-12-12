using System.Text.Json.Serialization;

namespace CtMkn.Models
{
    public class State
    {
        public int Id { get; set; }

        [JsonPropertyName("lat")]
        public string Lat { get; set; }

        [JsonPropertyName("long")]
        public string Long { get; set; }

        [JsonPropertyName("state_abbr")]
        public string StateAbbr { get; set; }

        [JsonPropertyName("state_description")]
        public string StateDescription { get; set; }

        [JsonPropertyName("state_id")]
        public string StateId { get; set; }
    }
}
