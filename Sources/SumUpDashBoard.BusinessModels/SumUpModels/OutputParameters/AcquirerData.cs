using System.Text.Json.Serialization;

namespace SumUpDashBoard.BusinessModels.SumUpModels.OutputParameters
{
    public class AcquirerData
    {
        [JsonPropertyName("tid")]
        public string Tid { get; set; } = default!;

        [JsonPropertyName("mid")]
        public string Mid { get; set; } = default!;

        [JsonPropertyName("authorization_code")]
        public string AuthorizationCode { get; set; } = default!;

        [JsonPropertyName("return_code")]
        public string ReturnCode { get; set; } = default!;

        [JsonPropertyName("local_time")]
        public DateTime LocalTime { get; set; }
    }
}