using Azure.Messaging.ServiceBus;
using Crud_Bus.Models;
using Newtonsoft.Json;
using System.Text.Json;

namespace Crud_Bus.Services
{
    public class AzureBusService
    {
        private ServiceBusClient _client;

        public AzureBusService(string keys)
        {
            _client = new ServiceBusClient(keys);
        }
        public async Task SendMessageAsync(CarModel modelMessage)
        {
            ServiceBusSender sender = _client.CreateSender("myqueue");
            //ServiceBusMessage message = new ServiceBusMessage(data);
            //await sender.SendMessageAsync(message);

            var body = System.Text.Json.JsonSerializer.Serialize(modelMessage);
            var sbMessage = new ServiceBusMessage(body);
            await sender.SendMessageAsync(sbMessage);
        }

        public async Task<string?> GetQueueAz()
        {
            ServiceBusReceiver receiver = _client.CreateReceiver("myqueue");
            ServiceBusReceivedMessage receivedMessage = await receiver.ReceiveMessageAsync();

            if (receivedMessage is null)
                return null;

            var jsonstring = receivedMessage.Body.ToString();


            Console.WriteLine(jsonstring);

            await receiver.CompleteMessageAsync(receivedMessage);

            return jsonstring;


        }

    }

}
