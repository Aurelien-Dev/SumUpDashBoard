using System.Text.Json.Serialization;

namespace SumUpDashBoard.BusinessModels.SumUpModels.OutputParameters
{
    public class FinancialPayout
    {
        [JsonPropertyName("amount")]
        public double Amount { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; } = default!;

        [JsonPropertyName("date")]
        public string Date { get; set; } = default!;

        [JsonPropertyName("fee")]
        public double Fee { get; set; }

        [JsonPropertyName("id")]
        public object Id { get; set; } = default!;

        [JsonPropertyName("reference")]
        public string Reference { get; set; } = default!;

        [JsonPropertyName("status")]
        public string Status { get; set; } = default!;

        [JsonPropertyName("transaction_code")]
        public string TransactionCode { get; set; } = default!;

        [JsonPropertyName("type")]
        public string Type { get; set; } = default!;
    }
}