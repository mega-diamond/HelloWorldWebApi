
using HelloWorldWebApi.Configuration;
using HelloWorldWebApi.Model;
using Microsoft.Extensions.Options;

namespace HelloWorldWebApi
{
    public class Worker : BackgroundService
    {
        //private readonly IMarkets markets;
        private readonly IServiceProvider scopeProvider;
        //private readonly HelloWorldWebApi.Configuration.Markets root;
        //private readonly ApiSettings apisett;

        public Worker(IServiceProvider scopeProvider, IOptions<HelloWorldWebApi.Configuration.Markets> rootOptions, IOptions<ApiSettings> apisettOptions)
        {
            //this.markets = markets;
            this.scopeProvider = scopeProvider;
            //root = rootOptions.Value;
            //apisett = apisettOptions.Value;
        }



        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {

           // var test = apisett;
           // var test2 = root;



            using (var scope = scopeProvider.CreateScope())
            {
                var scopedService = scope.ServiceProvider.GetRequiredService<IMarkets>();
                while (!stoppingToken.IsCancellationRequested)
                {
                    /*
                    foreach (var market in this.scopedService.GetMarkets())
                    {

                    }
                    */
                    await Task.Delay(30000);
                }
            }





            //Get currencyes


            // Get last price


        }
    }
}
