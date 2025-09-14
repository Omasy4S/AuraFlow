using AuraFlow.Domain.Interfaces;
using Confluent.Kafka;
using Microsoft.Extensions.Configuration;

namespace AuraFlow.Infrastructure.Messaging
{
    public class KafkaProducer : IKafkaProducer
    {
        private readonly IProducer<string, string> _producer;

        public KafkaProducer(IConfiguration configuration)
        {
            var config = new ProducerConfig
            {
                BootstrapServers = configuration["Kafka:BootstrapServers"] ?? "localhost:9092"
            };
            _producer = new ProducerBuilder<string, string>(config).Build();
        }

        public async Task ProduceAsync(string topic, string key, string value)
        {
            var result = await _producer.ProduceAsync(topic, new Message<string, string> { Key = key, Value = value });
            Console.WriteLine($"Produced to {result.TopicPartitionOffset}");
        }
    }
}
