namespace AuraFlow.Domain.Entities
{
    public class EmotionRecord
    {
        public Guid Id { get; set; }
        public string UserId { get; set; } = string.Empty;
        public int Joy { get; set; }
        public int Sadness { get; set; }
        public int Calm { get; set; }
        public int Anxiety { get; set; }
        public int Inspiration { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
