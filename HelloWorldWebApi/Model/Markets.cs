
using HelloWorldWebApi.Configuration;
using Microsoft.Extensions.Options;

namespace HelloWorldWebApi.Model
{
    public class Markets : IMarkets
    {

        private List<string> markets;
        private readonly Configuration.Markets myConfig;
        private readonly ApiSettings apisettings;

        public Markets(IOptions<Configuration.Markets> myConfig, IOptions<ApiSettings> apisettOptions)
        {
            markets = new List<string>();
            this.myConfig = myConfig.Value;
            this.apisettings = apisettOptions.Value;

            foreach (var market in this.myConfig.RequestDetail)
            {
                markets.Add(market.MarketName);
            }
        }
        


        public List<string> GetMarkets()
        {
            return markets;
        }
    }
}
