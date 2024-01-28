using System.Text.Json.Serialization;

namespace SumUpDashBoard.BusinessModels.SumUpModels.OutputParameters
{
    public class EmvData
    {
        [JsonPropertyName("tvr")]
        public string Tvr { get; set; } = default!;

        [JsonPropertyName("tsi")]
        public string Tsi { get; set; } = default!;

        [JsonPropertyName("cvr")]
        public string Cvr { get; set; } = default!;

        [JsonPropertyName("iad")]
        public string Iad { get; set; } = default!;

        [JsonPropertyName("arc")]
        public string Arc { get; set; } = default!;

        [JsonPropertyName("aid")]
        public string Aid { get; set; } = default!;

        [JsonPropertyName("act")]
        public string Act { get; set; } = default!;

        [JsonPropertyName("acv")]
        public string Acv { get; set; } = default!;
    }

}
