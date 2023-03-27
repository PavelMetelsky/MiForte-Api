using System.Diagnostics.Contracts;
using System.Reflection;
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
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Session> Sessions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserMap).Assembly,
                type => type.IsDerivedFromOpenGenericType(typeof(IEntityTypeConfiguration<>)));
        }
    }
}

static class TypeExtensions
{
    public static bool IsDerivedFromOpenGenericType(
        this Type type,
        Type openGenericType
    )
    {
        Contract.Requires(openGenericType.IsGenericTypeDefinition);
        return type.GetTypeHierarchy()
                   .Where(t => t.IsGenericType)
                   .Select(t => t.GetGenericTypeDefinition())
                   .Any(t => openGenericType == t);
    }

    private static IEnumerable<Type> GetTypeHierarchy(this Type type)
    {
        var currentType = type;
        while (currentType != null)
        {
            yield return currentType;
            currentType = currentType.BaseType;
        }
    }
}