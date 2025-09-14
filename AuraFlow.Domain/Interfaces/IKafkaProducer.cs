namespace AuraFlow.Domain.Interfaces
{
    public interface IKafkaProducer
    {
        Task ProduceAsync(string topic, string key, string value);
    }
}
