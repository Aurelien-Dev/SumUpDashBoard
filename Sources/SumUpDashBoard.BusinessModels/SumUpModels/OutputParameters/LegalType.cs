using System.Text.Json.Serialization;

namespace SumUpDashBoard.BusinessModels.SumUpModels.OutputParameters
{
    public class LegalType
    {
        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        [JsonPropertyName("full_description")]
        public string Full_description { get; set; } = default!;

        [JsonPropertyName("description")]
        public string Description { get; set; } = default!;

        [JsonPropertyName("sole_trader")]
        public bool SoleTrader { get; set; } = default!;
    }

}
