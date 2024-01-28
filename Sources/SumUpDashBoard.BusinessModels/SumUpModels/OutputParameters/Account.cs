using System.Text.Json.Serialization;

namespace SumUpDashBoard.BusinessModels.SumUpModels.OutputParameters
{
    public class Account
    {
        [JsonPropertyName("username")]
        public string UserName { get; set; } = default!;

        [JsonPropertyName("type")]
        public string Type { get; set; } = default!;
    }
}