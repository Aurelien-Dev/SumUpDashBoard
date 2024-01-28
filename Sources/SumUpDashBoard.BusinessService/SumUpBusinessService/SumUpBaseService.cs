using SumUpDashBoard.BusinessModels.Attributes;
using System.Reflection;
using System.Text.Json;

namespace SumUpDashBoard.BusinessService.SumUpBusinessService
{
    public class SumUpBaseService : ISumUpBaseService
    {

        public string _authenticationType { get; }
        public string _authenticationKey { get; }

        public SumUpBaseService()
        {
            _authenticationType = "Bearer";
            _authenticationKey = "sup_sk_lGqMSakyKQ1c72ADSXLlRE4Ht8blLrLMY";// "sup_sk_bNgXq4lTpmneHbw1mcVNPVk5QPCafG3FV";
        }

        public async Task<TOut> CallService<TIn, TOut>(string httpMethod, string url, TIn? parameters)
        {
            try
            {
                var baseUrl = $"https://api.sumup.com/{url}";

                using var client = new HttpClient();
                client.DefaultRequestHeaders.Authorization = new(_authenticationType, _authenticationKey);

                string fullUrl = baseUrl + GetParamsUrl(parameters);
                using var httpRequestMessage = new HttpRequestMessage(new HttpMethod(httpMethod), fullUrl);

                var httpResponseMessage = await client.SendAsync(httpRequestMessage);

                var result = await httpResponseMessage.Content.ReadAsStringAsync();

                if (result == null)
                    throw new ArgumentNullException("result");

                TOut baseResult = JsonSerializer.Deserialize<TOut>(result);

                return baseResult;
            }
            catch (Exception)
            {
                return default(TOut);
            }
        }



        //private FormUrlEncodedContent GetParams<T>(T parameters)
        //{
        //    if (parameters == null)
        //        throw new ArgumentNullException("parameters");

        //    IDictionary<string, string> param = parameters
        //                                            .GetType()
        //                                            .GetProperties()
        //                                            .ToDictionary(p => p.GetCustomAttribute<ParamNameAttribute>().Name, p => p.GetValue(parameters).ToString());

        //    return new FormUrlEncodedContent(param);
        //}

        private string GetParamsUrl<T>(T parameters)
        {
            if (parameters == null)
                return string.Empty;

            IDictionary<string, string> parametres = new Dictionary<string, string>();

            PropertyInfo[] properties = parameters.GetType().GetProperties();

            foreach (PropertyInfo item in properties)
            {
                string key = item.GetCustomAttribute<ParamNameAttribute>().Name;
                string value = string.Empty;

                if (item.PropertyType == typeof(DateTime))
                    value = (item.GetValue(parameters) as DateTime?).Value.ToShortDateString();
                else
                    value = item.GetValue(parameters).ToString();

                parametres.Add(key, value);
            }

            //var dd = parameters.GetType().GetProperties()
            //       .ToDictionary(p => p.GetCustomAttribute<ParamNameAttribute>().Name, p => p.GetValue(parameters).ToString());

            return $"?{string.Join("&", parametres.Select(p => $"{p.Key}={p.Value}").ToArray())}";
        }
    }
}