using System.Text.Json.Serialization;

namespace SumUpDashBoard.BusinessModels.SumUpModels.OutputParameters
{
    public class TransactionData
    {
        [JsonPropertyName("transaction_code")]
        public string TransactionCode { get; set; } = default!;

        [JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; } = default!;

        [JsonPropertyName("amount")]
        public string Amount { get; set; } = default!;

        [JsonPropertyName("vat_amount")]
        public string VatAmount { get; set; } = default!;

        [JsonPropertyName("tip_amount")]
        public string TipAmount { get; set; } = default!;

        [JsonPropertyName("currency")]
        public string Currency { get; set; } = default!;

        [JsonPropertyName("timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; } = default!;

        [JsonPropertyName("payment_type")]
        public string PaymentType { get; set; } = default!;

        [JsonPropertyName("entry_mode")]
        public string EntryMode { get; set; } = default!;

        [JsonPropertyName("verification_method")]
        public string VerificationMethod { get; set; } = default!;

        [JsonPropertyName("card_reader")]
        public Card_Reader CardReader { get; set; } = default!;

        [JsonPropertyName("card")]
        public Card Card { get; set; } = default!;

        [JsonPropertyName("installments_count")]
        public int InstallmentsCount { get; set; }

        [JsonPropertyName("products")]
        public Product[] Products { get; set; } = default!;

        [JsonPropertyName("vat_rates")]
        public VatRates[] VatRates { get; set; } = default!;

        [JsonPropertyName("events")]
        public object[] Events { get; set; } = default!;

        [JsonPropertyName("receipt_no")]
        public string ReceiptNo { get; set; } = default!;
    }
}