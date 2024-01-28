using SumUpDashBoard.BusinessModels.SumUpModels.InputParameters;
using SumUpDashBoard.BusinessModels.SumUpModels.OutputParameters;
using SumUpDemo.InputParameterModels;

namespace SumUpDashBoard.BusinessService.SumUpBusinessService
{
    public class SumUpService : SumUpBaseService, ISumUpService
    {
        public async Task<IEnumerable<FinancialTransaction>> GetFinancialTransactions()
        {
            return await CallService<FinancialTransactionsInput, List<FinancialTransaction>>("GET", "v0.1/me/financials/transactions", new FinancialTransactionsInput
            {
                StartDate = new DateTime(2020, 01, 01),
                EndDate = new DateTime(2023, 01, 01)
            });
        }

        public async Task<TransactionHystory> GetTransactionsHistory()
        {
            return await CallService<BaseInput, TransactionHystory>("GET", "v0.1/me/transactions/history", null);
        }

        public async Task<IEnumerable<FinancialPayout>> GetFinancialsPayouts()
        {
            return await CallService<BaseInput, IEnumerable<FinancialPayout>>("GET", "v0.1/me/financials/payouts", new FinancialTransactionsInput
            {
                StartDate = new DateTime(2020, 01, 01),
                EndDate = new DateTime(2023, 01, 01)
            });
        }

        public async Task<ReceipDetail> GetReceiptDetails(string id)
        {
            return await CallService<ReceiptDetailInput, ReceipDetail>("GET", $"v1.1/receipts/{id}", new ReceiptDetailInput()
            {
                MerchantCode = "MFRP7DQE"
            });
        }

        public async Task<MyInformation> GetMyInfos()
        {
            return await CallService<BaseInput, MyInformation>("GET", "v0.1/me", null);
        }
    }
}
