using System.Text.Json.Serialization;

namespace SumUpDashBoard.BusinessModels.SumUpModels.OutputParameters
{
    public class FinancialTransaction : SumUpBase
    {
        [JsonPropertyName("amount")]
        public float Amount { get; set; }

        [JsonPropertyName("currency ")]
        public string Currency { get; set; } = default!;

        [JsonPropertyName("external_reference ")]
        public object ExternalReference { get; set; } = default!;

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("timestamp")]
        public DateTime TransactionDate { get; set; }

        [JsonPropertyName("transaction_code")]
        public string TransactionCode { get; set; } = default!;

        [JsonPropertyName("type")]
        public string Type { get; set; } = default!;
    }
}
