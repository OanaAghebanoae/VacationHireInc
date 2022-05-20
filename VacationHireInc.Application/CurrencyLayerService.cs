using Flurl;
using Flurl.Http;
using Microsoft.Extensions.Configuration;
using RestSharp;
using VacationHireInc.Core;
using VacationHireInc.Data;

namespace VacationHireInc.Application
{
    public class CurrencyLayerService : ICurrencyLayerService
    {
        private readonly IConfiguration _config;

        public CurrencyLayerService(IConfiguration config)
        {
            _config = config;
        }

        public async Task<decimal> Convert(string from, string to, decimal amount)
        {
            var response = await _config["CurrencyLayerApi:Endpoint"]
                .SetQueryParam("from", from)
                .SetQueryParam("to", to)
                .SetQueryParam("amount", amount)
                .WithHeader("apikey", _config["CurrencyLayerApi:ApiKey"])
                .GetJsonAsync<CurrencyLayerApiResponse>();

            return response.Result;
        }
    }
}
