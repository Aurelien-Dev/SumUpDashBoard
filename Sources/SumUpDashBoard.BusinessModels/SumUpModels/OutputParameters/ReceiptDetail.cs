using System.Text.Json.Serialization;

namespace SumUpDashBoard.BusinessModels.SumUpModels.OutputParameters
{
    public class ReceipDetail
    {
        [JsonPropertyName("transaction_data")]
        public TransactionData transaction_data { get; set; } = default!;

        [JsonPropertyName("card_application_data")]
        public CardApplicationData card_application_data { get; set; } = default!;

        [JsonPropertyName("merchant_data")]
        public MerchantData merchant_data { get; set; } = default!;

        [JsonPropertyName("emv_data")]
        public EmvData emv_data { get; set; } = default!;

        [JsonPropertyName("acquirer_data")]
        public AcquirerData acquirer_data { get; set; } = default!;
    }
}