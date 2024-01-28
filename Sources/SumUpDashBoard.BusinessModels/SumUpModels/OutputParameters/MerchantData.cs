using System.Text.Json.Serialization;

namespace SumUpDashBoard.BusinessModels.SumUpModels.OutputParameters
{
    public class MerchantData
    {
        [JsonPropertyName("merchant_profile ")]
        public MerchantProfile MerchantProfile { get; set; } = default!;

        [JsonPropertyName("locale ")]
        public string Locale { get; set; } = default!;
    }

}
