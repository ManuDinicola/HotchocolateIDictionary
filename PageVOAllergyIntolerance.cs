using System.Text.Json.Serialization;

namespace HotChocolateIDict;

public class PageVOAllergyIntolerance : ModelBase
{
    [JsonPropertyName("totalcount")]
    public long TotalCount { get; set; }

    [JsonPropertyName("hasmore")]
    public bool HasMore { get; set; }
}