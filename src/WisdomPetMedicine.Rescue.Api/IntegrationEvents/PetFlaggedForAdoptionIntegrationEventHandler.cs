using Azure.Messaging.ServiceBus;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Threading;
using System.Threading.Tasks;

namespace WisdomPetMedicine.Rescue.Api.IntegrationEvents
{
    public class PetFlaggedForAdoptionIntegrationEventHandler : BackgroundService
    {
        private readonly ILogger<PetFlaggedForAdoptionIntegrationEventHandler> logger;
        private readonly ServiceBusClient client;
        private readonly ServiceBusProcessor processor;
        public PetFlaggedForAdoptionIntegrationEventHandler(IConfiguration configuration,
                                                            ILogger<PetFlaggedForAdoptionIntegrationEventHandler> logger)
        {
            this.logger = logger;

            client = new ServiceBusClient(configuration["ServiceBus:ConnectionString"]);
            processor = client.CreateProcessor(configuration["ServiceBus:TopicName"], configuration["ServiceBus:SubscriptionName"]);
            processor.ProcessMessageAsync += Processor_ProcessMessageAsync;
            processor.ProcessErrorAsync += Processor_ProcessErrorAsync;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            await processor.StartProcessingAsync(stoppingToken);
            System.Console.WriteLine("ejecucion del servicio background");
        }
        public override Task StartAsync(CancellationToken cancellationToken)
        {
            System.Console.WriteLine("inicio del servicio background");
            return base.StartAsync(cancellationToken);
        }

        public override async Task StopAsync(CancellationToken cancellationToken)
        {
            await processor.StopProcessingAsync(cancellationToken);
            System.Console.WriteLine("detencion del servicio bk");
        }

        private async Task Processor_ProcessMessageAsync(ProcessMessageEventArgs args)
        {
            var body = args.Message.Body.ToString();
            var theEvent = JsonConvert.DeserializeObject<PetFlaggedForAdoptionIntegrationEvent>(body);
            await args.CompleteMessageAsync(args.Message);
            logger?.LogInformation(body);
            System.Console.WriteLine(body);
            System.Console.WriteLine("procesamiento del servicio");
        }

        private Task Processor_ProcessErrorAsync(ProcessErrorEventArgs args)
        {
            logger.LogError(args.Exception.ToString());
            System.Console.WriteLine("procesamiento del error");
            return Task.CompletedTask;
        }
    }
}
