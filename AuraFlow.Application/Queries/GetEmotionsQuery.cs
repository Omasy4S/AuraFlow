using AuraFlow.Application.DTOs;
using MediatR;

namespace AuraFlow.Application.Queries
{
    public record GetEmotionsQuery(string UserId) : IRequest<List<EmotionRecordDto>>;
}
