using Microsoft.EntityFrameworkCore;
using Piano.Entities;
using Piano.Entities.Note;
using Piano.Entities.Session;
using Piano.Entities.Subscription;
using Piano.Entities.User;

public class PianoContext : DbContext
{
    public DbSet<Note> Notes { get; set; }
    public DbSet<NoteAttachment> NoteAttachments { get; set; }
    public DbSet<NoteLink> NoteLinks { get; set; }
    public DbSet<Session> Sessions { get; set; }
    public DbSet<SessionAttachment> SessionAttachments { get; set; }
    public DbSet<CommentLink> CommentLinks { get; set; }
    public DbSet<MonthlySubscription> MonthlySubscriptions { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<SocialLink> SocialLinks { get; set; }

    public PianoContext(DbContextOptions<PianoContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(PianoContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }
}