using System.Text.Json.Serialization;

namespace SumUpDashBoard.BusinessModels.SumUpModels.OutputParameters
{
    public class Product
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        [JsonPropertyName("description")]
        public string Description { get; set; } = default!;

        [JsonPropertyName("price")]
        public string Price { get; set; } = default!;

        [JsonPropertyName("vat_rate")]
        public string VatRate { get; set; } = default!;

        [JsonPropertyName("single_vat_amount")]
        public string SingleVatAmount { get; set; } = default!;

        [JsonPropertyName("price_with_vat")]
        public string PriceWithVat { get; set; } = default!;

        [JsonPropertyName("vat_amount")]
        public string VatAmount { get; set; } = default!;

        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        [JsonPropertyName("total_price")]
        public string TotalPrice { get; set; } = default!;

        [JsonPropertyName("total_with_vat")]
        public string TotalWithVat { get; set; } = default!;
    }

}
