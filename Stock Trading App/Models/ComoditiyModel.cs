using System.Text.Json.Serialization;

namespace Stock_Trading_App.Data.Models;


public class ComoditiyModel
{
    [JsonPropertyName("name")]
    public string? comoditiyName { get; set; }

    [JsonPropertyName("interval")]
    public string? comoditiyInterval { get; set; }

    [JsonPropertyName("unit")]
     public string? comoditiyUnit { get; set; }

    [JsonPropertyName("data")]
    public IEnumerable<Dictionary<string,string>>? comoditiyData { get; set; }
}