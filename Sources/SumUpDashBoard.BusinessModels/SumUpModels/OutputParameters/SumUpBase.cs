using System.Text.Json.Serialization;

namespace SumUpDashBoard.BusinessModels.SumUpModels.OutputParameters
{
    public class SumUpBase
    {
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        [JsonPropertyName("error_message")]
        public string ErrorMessage { get; set; } = default!;

        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = default!;
    }
}
