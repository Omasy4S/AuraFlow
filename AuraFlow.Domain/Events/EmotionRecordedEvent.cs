namespace AuraFlow.Domain.Events
{
    public record EmotionRecordedEvent(
    Guid Id,
    string UserId,
    int Joy,
    int Sadness,
    int Calm,
    int Anxiety,
    int Inspiration,
    DateTime CreatedAt
    );
}
