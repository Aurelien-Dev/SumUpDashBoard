using System.Text.Json.Serialization;

namespace SumUpDashBoard.BusinessModels.SumUpModels.OutputParameters
{

    public class MyInformation
    {
        [JsonPropertyName("account")]
        public Account Account { get; set; } = default!;

        [JsonPropertyName("personal_profile")]
        public PersonalProfile PersonalProfile { get; set; } = default!;

        [JsonPropertyName("merchant_profile")]
        public MerchantProfile MerchantProfile { get; set; } = default!;

        [JsonPropertyName("requirements")]
        public object[] Requirements { get; set; } = default!;

        [JsonPropertyName("verifications")]
        public object[] Verifications { get; set; } = default!;

        [JsonPropertyName("is_migrated_payleven_br")]
        public bool IsMigratedPayleven { get; set; }

        [JsonPropertyName("signup_time")]
        public DateTime SignupTime { get; set; }

        [JsonPropertyName("details_submitted")]
        public bool DetailsSubmitted { get; set; }
    }

}
