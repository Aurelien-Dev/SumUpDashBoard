using System.Text.Json.Serialization;

namespace SumUpDashBoard.BusinessModels.SumUpModels.OutputParameters
{
    public class SumUpToken : SumUpBase
    {
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; } = default!;

        [JsonPropertyName("token_type")]
        public string TokenType { get; set; } = default!;

        [JsonPropertyName("expires_in")]
        public int ExpiresIn { get; set; }
    }
}
