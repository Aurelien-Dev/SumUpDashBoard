using SumUpDashBoard.BusinessModels.SumUpModels.OutputParameters;

namespace SumUpDashBoard.BusinessService.SumUpBusinessService
{
    public interface ISumUpService
    {
        Task<IEnumerable<FinancialTransaction>> GetFinancialTransactions();
        Task<TransactionHystory> GetTransactionsHistory();
        Task<IEnumerable<FinancialPayout>> GetFinancialsPayouts();
        Task<ReceipDetail> GetReceiptDetails(string id);
        Task<MyInformation> GetMyInfos();
    }
}
