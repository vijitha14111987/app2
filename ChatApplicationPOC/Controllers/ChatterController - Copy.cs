using ChatApplicationPOC.Services;
using Confluent.Kafka;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using static Confluent.Kafka.ConfigPropertyNames;

namespace ChatApplicationPOC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChatterController_old : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<ChatterController> _logger;

        public ChatterController_old(ILogger<ChatterController> logger)
        {
            _logger = logger;
        }

        //[HttpGet(Name = "GetChatter")]
        //public IEnumerable<Chat> Get()
        //{
        //    return null;
        //}


        //[HttpPost(Name = "SendMessage")]
        //public async Task<bool> Post([FromBody] Chat message)
        //{

        //    var config = new ProducerConfig
        //    {
        //        BootstrapServers = "localhost:9092" // Replace with your Kafka broker address
        //    };

        //    using (var producer = new ProducerBuilder<Null, string>(config).Build())
        //    {
        //        try
        //        {
                   
        //                var key = message.SenderName;
        //                var value = message.Message;
        //            var dr = await producer.ProduceAsync("order", new Message<Null, string> { Value = value });
        //            string redisConnectionString = "localhost:6379";

                 
        //                // Redis Cache
        //                var cache = new RedisCache(redisConnectionString);

        //                // Example of setting and getting cache value
        //                await cache.SetCacheValueAsync("Chat", message.SenderName + ":" + message.Message);
                    
        //        }
        //        catch (ProduceException<Null, string> e)
        //        {
        //            Console.WriteLine($"Delivery failed: {e.Error.Reason}");
        //        }
        //    }

        //    return true;
        //}

        //[HttpGet(Name = "ReceiveMessage")]
        //public async Task<IEnumerable<Chat>> Get()
        //{
        //    List<Chat> c = new List<Chat>();
        //    var config = new ConsumerConfig
        //    {
        //        BootstrapServers = "localhost:9092", // Replace with your Kafka broker address
        //        GroupId = "my_consumer_group",
        //        AutoOffsetReset = AutoOffsetReset.Earliest
        //    };
            
        //    using (var consumer = new ConsumerBuilder<Ignore, string>(config).Build())
        //    {
        //        consumer.Subscribe("order");

        //        try
        //        {
                    
                      


                    

        //            var cr = consumer.Consume();
        //                Chat chat = new Chat();
        //                chat.Message = cr.Value.ToString();
        //                c.Add(chat);
                    
        //        }
        //        catch (ConsumeException e)
        //        {
        //            Console.WriteLine($"Error occurred: {e.Error.Reason}");
        //        }
        //        finally
        //        {
        //            consumer.Close();
        //        }
        //    }
        //    string redisConnectionString = "localhost:6379";
        //    var cache = new RedisCache(redisConnectionString);
        //    var result = await cache.GetCacheValueAsync("Chat");
        //    return c;

        //}











        //[HttpPost(Name = "SendMessage")]
        //public async Task<bool> Post([FromBody] Chat message)
        //{

        //    // Configuration settings
        //    string kafkaBootstrapServers = "localhost:9092";
        //    string kafkaTopic = "my-topic";
        //    string kafkaGroupId = "my-group";
        //    string redisConnectionString = "localhost:6379";

        //    // Kafka Producer and Consumer
        //    var producer = new KafkaProducer(kafkaBootstrapServers, kafkaTopic);


        //    // Redis Cache
        //    var cache = new RedisCache(redisConnectionString);

        //    // Example of setting and getting cache value
        //    await cache.SetCacheValueAsync("Chat", message.SenderName + ":" + message.Message);


        //    // Example of producing and consuming Kafka messages
        //    await producer.ProduceMessageAsync("Chat", message.SenderName + ":" + message.Message);

        //    return true;
        //}


        //[HttpGet(Name = "ReceiveMessage")]
        //public async Task<IEnumerable<Chat>> Get()
        //{
        //    string kafkaBootstrapServers = "localhost:9092";
        //    string kafkaTopic = "my-topic";
        //    string kafkaGroupId = "my-group";
        //    string redisConnectionString = "localhost:6379";
        //    var cache = new RedisCache(redisConnectionString);

        //    // Kafka Producer and Consumer
        //    var consumer = new KafkaConsumer(kafkaBootstrapServers, kafkaTopic, kafkaGroupId);
        //    var cts = new CancellationTokenSource();
        //    Task consumerTask = consumer.ConsumeMessagesAsync(cts.Token);
        //    List<Chat> c = new List<Chat>();
        //    var result = await cache.GetCacheValueAsync("Chat");
        //    await Task.Delay(TimeSpan.FromSeconds(10));
        //    cts.Cancel();
        //    return c;

        //}
    }
}
