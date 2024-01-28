using System.Text.Json.Serialization;

namespace SumUpDashBoard.BusinessModels.SumUpModels.OutputParameters
{
    public class Address
    {
        [JsonPropertyName("address_line1")]
        public string AddressLine1 { get; set; } = default!;
        [JsonPropertyName("city")]
        public string City { get; set; } = default!;
        [JsonPropertyName("country")]
        public string Country { get; set; } = default!;
        [JsonPropertyName("country_en_name")]
        public string CountryEnName { get; set; } = default!;
        [JsonPropertyName("country_native_name")]
        public string CountryNativeName { get; set; } = default!;
        [JsonPropertyName("post_code")]
        public string PostCode { get; set; } = default!;
        [JsonPropertyName("landline")]
        public string LandLine { get; set; } = default!;
    }

}
