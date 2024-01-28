using System.Text.Json.Serialization;

namespace SumUpDashBoard.BusinessModels.SumUpModels.OutputParameters
{
    public class PersonalProfile
    {
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; } = default!;

        [JsonPropertyName("last_name")]
        public string LastName { get; set; } = default!;

        [JsonPropertyName("date_of_birth")]
        public string DateOfBirth { get; set; } = default!;

        [JsonPropertyName("mobile_phone")]
        public string MobilePhone { get; set; } = default!;

        [JsonPropertyName("address")]
        public Address Address { get; set; } = default!;

        [JsonPropertyName("complete")]
        public bool Complete { get; set; }
    }

}
