using System.Text.Json.Serialization;

namespace SumUpDashBoard.BusinessModels.SumUpModels.OutputParameters
{
    public class Card
    {
        [JsonPropertyName("last_4_digits")]
        public string Last4Digits { get; set; } = default!;

        [JsonPropertyName("type")]
        public string Type { get; set; } = default!;

        [JsonPropertyName("token")]
        public string Token { get; set; } = default!;
    }

}
