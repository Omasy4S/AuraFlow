using AuraFlow.Application.Services;
using AuraFlow.Domain.Interfaces;
using AuraFlow.Infrastructure.Data;
using AuraFlow.Infrastructure.Messaging;
using AuraFlow.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AuraFlow.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            // PostgreSQL
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("Default")));

            // Kafka Producer
            services.AddSingleton<IKafkaProducer, KafkaProducer>();

            // Services
            services.AddScoped<IEmotionService, EmotionService>();
        }

    }

}
