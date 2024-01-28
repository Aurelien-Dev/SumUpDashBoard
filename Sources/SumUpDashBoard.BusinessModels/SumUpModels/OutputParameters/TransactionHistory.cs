using System.Text.Json.Serialization;

namespace SumUpDashBoard.BusinessModels.SumUpModels.OutputParameters
{
    public class Item
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = default!;
        [JsonPropertyName("transaction_id")]
        public string transactionId { get; set; } = default!;
        [JsonPropertyName("user")]
        public string User { get; set; } = default!;
        [JsonPropertyName("type")]
        public string Type { get; set; } = default!;
        [JsonPropertyName("status")]
        public string Status { get; set; } = default!;
        [JsonPropertyName("timestamp")]
        public DateTime Timestamp { get; set; }
        [JsonPropertyName("currency")]
        public string Currency { get; set; } = default!;
        [JsonPropertyName("amount")]
        public double Amount { get; set; }
        [JsonPropertyName("transaction_code")]
        public string TransactionCode { get; set; } = default!;
        [JsonPropertyName("product_summary")]
        public string ProductSummary { get; set; } = default!;
        [JsonPropertyName("installments_count")]
        public int InstallmentsCount { get; set; }
        [JsonPropertyName("payment_type")]
        public string PaymentType { get; set; } = default!;
        [JsonPropertyName("entry_mode")]
        public string EntryMode { get; set; } = default!;
        [JsonPropertyName("card_type")]
        public string CardType { get; set; } = default!;
        [JsonPropertyName("payouts_total")]
        public int PayoutsTotal { get; set; }
        [JsonPropertyName("payouts_received")]
        public int PayoutsReceived { get; set; }
        [JsonPropertyName("payout_plan")]
        public string PayoutPlan { get; set; } = default!;
        [JsonPropertyName("refunded_amount")]
        public int RefundedAmount { get; set; }
        [JsonPropertyName("payout_date")]
        public string PayoutDate { get; set; } = default!;
        [JsonPropertyName("payout_type")]
        public string PayoutType { get; set; } = default!;
    }

    public class Link
    {
        [JsonPropertyName("rel")]
        public string Rel { get; set; } = default!;
        [JsonPropertyName("href")]
        public string Href { get; set; } = default!;    
    }

    public class TransactionHystory
    {
        [JsonPropertyName("items")]
        public List<Item> Items { get; set; } = default!;
        [JsonPropertyName("links")]
        public List<Link> Links { get; set; } = default!;
    }
}