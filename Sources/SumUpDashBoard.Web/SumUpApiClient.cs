using SumUpDashBoard.BusinessModels.ComptabilityModels;

namespace SumUpDashBoard.Web;

public class SumUpApiClient(HttpClient httpClient)
{
    public async Task<SumUpTransactionModel[]> GetSumUpTransactionsAsync()
    {
        return await httpClient.GetFromJsonAsync<SumUpTransactionModel[]>("/Transactions") ?? [];
    }

    public async Task<List<UrsaffTrimesterModel>> GetTrimesterAsync()
    {
        return await httpClient.GetFromJsonAsync<List<UrsaffTrimesterModel>>("/Trimester") ?? [];
    }

    public async Task PostDataAsync()
    {
        var data = new { Name = "John Doe", Age = 30 };
        var response = await httpClient.PostAsJsonAsync("/Transactions", data);
    }
}