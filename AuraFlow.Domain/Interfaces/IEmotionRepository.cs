using AuraFlow.Domain.Entities;

namespace AuraFlow.Domain.Interfaces
{
    public interface IEmotionRepository
    {
        Task<EmotionRecord> AddAsync(EmotionRecord record);
        Task<List<EmotionRecord>> GetByUserIdAsync(string userId);
    }
}
