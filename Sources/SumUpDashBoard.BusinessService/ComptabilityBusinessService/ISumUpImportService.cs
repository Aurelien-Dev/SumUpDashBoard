using SumUpDashBoard.BusinessModels.ComptabilityModels;

namespace SumUpDashBoard.BusinessService.ComptabilityBusinessService
{
    public interface ISumUpImportService
    {
        List<SumUpTransactionModel> GetSumUpTransactions();
        List<SumUpTransactionModel> ImportSumUpTransaction(string csvContent);
        Task CreateNewTrimestre(Trimester trimester, int year, decimal? amountTaxe);
        Task<List<UrsaffTrimesterModel>> GetTrimester();
  }

}