using WetherReport.Services;
using Confluent.Kafka;
using System;
using System.Threading.Tasks;

namespace WetherReport.Services
{
    public class KafkaProducer
    {
        private readonly string _bootstrapServers;
        private readonly string _topic;

        public KafkaProducer(string bootstrapServers, string topic)
        {
            _bootstrapServers = bootstrapServers;
            _topic = topic;
        }

        public async Task ProduceMessageAsync(string key, string value)
        {
            var config = new ProducerConfig
            {
                BootstrapServers = _bootstrapServers
            };

            using (var producer = new ProducerBuilder<string, string>(config).Build())
            {
                try
                {
                    var deliveryResult = await producer.ProduceAsync(_topic, new Message<string, string>
                    {
                        Key = key,
                        Value = value
                    });

                    Console.WriteLine($"Delivered '{deliveryResult.Value}' to '{deliveryResult.TopicPartitionOffset}'.");
                }
                catch (ProduceException<string, string> e)
                {
                    Console.WriteLine($"Delivery failed: {e.Error.Reason}");
                }
            }
        }
    }
}
