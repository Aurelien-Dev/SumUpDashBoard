using System.Text.Json.Serialization;

namespace SumUpDashBoard.BusinessModels.SumUpModels.OutputParameters
{
    public class Card_Reader
    {
        [JsonPropertyName("code")]
        public string Code { get; set; } = default!;

        [JsonPropertyName("type")]
        public string Type { get; set; } = default!;
    }
}