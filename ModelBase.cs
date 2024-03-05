using System.Text.Json.Serialization;

namespace HotChocolateIDict
{
    public class ModelBase
    {
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}