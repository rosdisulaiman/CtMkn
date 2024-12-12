using System.Text.Json.Serialization;

namespace CtMkn.Models
{
    public class Daerah
    {
        public int Id { get; set; }

        [JsonPropertyName("daerah_description")]
        public string DaerahDescription { get; set; }

        [JsonPropertyName("daerah_id")]
        public string DaerahId { get; set; }

        [JsonPropertyName("lat")]
        public string Lat { get; set; }

        [JsonPropertyName("long")]
        public string Long { get; set; }

        [JsonPropertyName("state_description")]
        public string StateDescription { get; set; }

        [JsonPropertyName("state_id")]
        public int StateId { get; set; }
    }
}
