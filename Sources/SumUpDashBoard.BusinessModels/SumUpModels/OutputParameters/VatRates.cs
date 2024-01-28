using System.Text.Json.Serialization;

namespace SumUpDashBoard.BusinessModels.SumUpModels.OutputParameters
{
    public class VatRates
    {
        [JsonPropertyName("rate")]
        public float Rate { get; set; }
        [JsonPropertyName("net")]
        public float Net { get; set; }
        [JsonPropertyName("vat")]
        public float Vat { get; set; }
        [JsonPropertyName("gross")]
        public float Gross { get; set; }
    }

}
