using Microsoft.EntityFrameworkCore;
using Piano.Entities;
using Piano.Entities.Mappings;

namespace Piano.Database
{
    public class PianoContext : DbContext
    {
        public const string DefaultSchema = "dbo";
        public PianoContext(DbContextOptions<PianoContext> options)
            : base(options)
        {
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=.;Database=helloappdb;Trusted_Connection=True;");
        //}

        public DbSet<User> Users { get; set; }
        public DbSet<SocialLink> SocialLinks { get; set; }
        public DbSet<SubscriptionCard> SubscriptionCards { get; set; }
        public DbSet<Session> Sessions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new SocialLinkMap());
            modelBuilder.ApplyConfiguration(new SubscriptionMap());
            modelBuilder.ApplyConfiguration(new SessionMap());
        }
    }
}