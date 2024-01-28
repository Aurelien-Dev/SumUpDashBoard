using System.Text.Json.Serialization;

namespace SumUpDashBoard.BusinessModels.SumUpModels.OutputParameters
{
    public class CardApplicationData
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        [JsonPropertyName("aid")]
        public string Aid { get; set; } = default!;
    }
}