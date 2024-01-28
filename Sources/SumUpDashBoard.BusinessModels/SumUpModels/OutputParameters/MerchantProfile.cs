using System.Text.Json.Serialization;

namespace SumUpDashBoard.BusinessModels.SumUpModels.OutputParameters
{
    public class MerchantProfile
    {
        [JsonPropertyName("merchant_code")]
        public string MerchantCode { get; set; } = default!;

        [JsonPropertyName("company_name")]
        public string CompanyName { get; set; } = default!;

        [JsonPropertyName("business_name")]
        public string BusinessName { get; set; } = default!;

        [JsonPropertyName("website")]
        public string Website { get; set; }

        [JsonPropertyName("email")] 
        public string mail { get; set; } = default!;

        [JsonPropertyName("legal_type")]
        public LegalType LegalType { get; set; } = default!;

        [JsonPropertyName("merchant_category_code")]
        public string MerchantCategoryCode { get; set; } = default!;

        [JsonPropertyName("mobile_phone")]
        public string MobilePhone { get; set; } = default!;

        [JsonPropertyName("company_registration_number")]
        public string CompanyRegistrationNumber { get; set; } = default!;

        [JsonPropertyName("address")]
        public Address Address { get; set; } = default!;

        [JsonPropertyName("business_owners")]
        public object[] Business_owners { get; set; } = default!;

        [JsonPropertyName("doing_business_as")]
        public MerchantProfile Doing_business_as { get; set; } = default!;

        [JsonPropertyName("locale")]
        public string Locale { get; set; } = default!;

        [JsonPropertyName("complete")]
        public bool Complete { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; } = default!;

        [JsonPropertyName("default_currency")]
        public string DefaultCurrency { get; set; } = default!;
    }

}
