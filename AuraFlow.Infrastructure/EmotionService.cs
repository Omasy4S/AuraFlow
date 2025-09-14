using AuraFlow.Application.Services; // Импорт интерфейса
using AuraFlow.Application.DTOs;     // Импорт DTO
using System.Threading.Tasks;

namespace AuraFlow.Infrastructure.Services
{
    public class EmotionService : IEmotionService
    {
        public async Task<Guid> CreateEmotionRecordAsync(EmotionRecordDto dto, string userId)
        {
            // В реальном проекте — вызов через HttpClient
            // Здесь — заглушка
            return Guid.NewGuid();
        }

        public async Task<List<EmotionRecordDto>> GetUserEmotionsAsync(string userId)
        {
            // Заглушка
            return new List<EmotionRecordDto>();
        }
    }
}