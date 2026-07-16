using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Infrastructure.Persistance
{
    public class DreamStreamDbContext: DbContext
    {
        public DreamStreamDbContext(DbContextOptions<DreamStreamDbContext> options) : base(options)
        {
        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Background> Backgrounds { get; set; }
        public DbSet<ChatMessage> ChatMessages { get; set; }
        public DbSet<Effect> Effects { get; set; }
        public DbSet<Music> Musics { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<StreamRecord> StreamRecords { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
