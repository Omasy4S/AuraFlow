using AuraFlow.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuraFlow.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<EmotionRecord> EmotionRecords { get; set; }
    }
}
