using AuraFlow.Application.DTOs;
using MediatR;

namespace AuraFlow.Application.Commands
{
    public record CreateEmotionRecordCommand(EmotionRecordDto Data, string UserId) : IRequest<Guid>;
}
