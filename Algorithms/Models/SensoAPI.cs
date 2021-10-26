using System.Text.Json.Serialization;

namespace Algorithms
{
    public class SensoAPI
    {
        [JsonPropertyName("nome")]
        public string Name { get; set; }
    }
}