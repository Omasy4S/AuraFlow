using AuraFlow.Application.DTOs;

namespace AuraFlow.Application.Services
{
    public interface IEmotionService
    {
        Task<Guid> CreateEmotionRecordAsync(EmotionRecordDto dto, string userId);
        Task<List<EmotionRecordDto>> GetUserEmotionsAsync(string userId);
    }
}
