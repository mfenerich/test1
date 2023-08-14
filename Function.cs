using System;
using System.Threading;
using System.Threading.Tasks;
using CloudNative.CloudEvents;
using Google.Cloud.Functions.Framework;
using Google.Cloud.Functions.Hosting;
using Google.Events.Protobuf.Cloud.PubSub.V1;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Client;

namespace HelloPubSub
{
    public class Startup : FunctionsStartup
    {
        public override void ConfigureServices(WebHostBuilderContext context, IServiceCollection services)
        {
            services.AddHttpClient();
            services.AddSingleton<ProductStockSoapService>();
        }
    }
    
    [FunctionsStartup(typeof(Startup))]
    public class Function : ICloudEventFunction<MessagePublishedData>
    {
        private readonly ProductStockSoapService _soapService;
        
        public Function(ProductStockSoapService soapService) =>
            _soapService = soapService;
        
        public async Task HandleAsync(CloudEvent cloudEvent, MessagePublishedData data, CancellationToken cancellationToken)
        {
            var nameFromMessage = data.Message?.TextData;
            var name = string.IsNullOrEmpty(nameFromMessage) ? "world" : nameFromMessage;
            Console.WriteLine($"Hello {name}");

            var soapResponse = await _soapService.SendSoapRequestAsync();
            //Console.WriteLine(soapResponse.productStockItems[0].calculatetQuantity);
            Console.WriteLine("soapResponse START -------------");
            /*Console.WriteLine(soapResponse.error.errorCode);
            Console.WriteLine(soapResponse.error.errorMessage);*/
            Console.WriteLine(soapResponse.productStockItems[0].itemNo);
            Console.WriteLine(soapResponse.productStockItems[0].calculatetQuantity);
            Console.WriteLine(soapResponse.messageHeader.clientName);
            /*Console.WriteLine(soapResponse.messageHeader.token);*/
            Console.WriteLine("soapResponse END -------------");
        }
    }
}