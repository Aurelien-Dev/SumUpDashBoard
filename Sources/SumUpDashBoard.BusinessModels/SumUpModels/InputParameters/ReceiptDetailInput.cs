using SumUpDashBoard.BusinessModels.Attributes;

namespace SumUpDemo.InputParameterModels
{
    public class ReceiptDetailInput
    {
        [ParamName("mid")]
        public string MerchantCode { get; set; }
    }
}
