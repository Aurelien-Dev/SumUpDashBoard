using SumUpDashBoard.BusinessModels.Attributes;

namespace SumUpDashBoard.BusinessModels.SumUpModels.InputParameters
{
    public class FinancialTransactionsInput : BaseInput
    {

        [ParamName("start_date")]
        public DateTime StartDate { get; set; }

        [ParamName("end_date")]
        public DateTime EndDate { get; set; }
    }
}
