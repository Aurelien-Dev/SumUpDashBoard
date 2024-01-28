namespace SumUpDashBoard.BusinessService.SumUpBusinessService
{
    public interface ISumUpBaseService
    {
        Task<TOut> CallService<TIn, TOut>(string httpMethod, string url, TIn parameters);
    }
}