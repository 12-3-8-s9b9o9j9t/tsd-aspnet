using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Text.Json;
using Yummy_CookBook.Models;

namespace Yummy_CookBook.Data
{
    public class YummyContext : DbContext
    {
        public DbSet<Recipe> Recipes { get; set; }
        
        public YummyContext(DbContextOptions<YummyContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recipe>()
                .Property(e => e.Ingredients)
                .HasConversion(
                    v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
                    v => JsonSerializer.Deserialize<List<string>>(v, (JsonSerializerOptions)null),
                    new ValueComparer<ICollection<string>>(
                        (c1, c2) => c1.SequenceEqual(c2),
                        c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                        c => (ICollection<string>)c.ToList()));
            modelBuilder.Entity<Recipe>()
                .Property(e => e.TipsTricks)
                .HasConversion(
                    v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
                    v => JsonSerializer.Deserialize<List<string>>(v, (JsonSerializerOptions)null),
                    new ValueComparer<ICollection<string>>(
                        (c1, c2) => c1.SequenceEqual(c2),
                        c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                        c => (ICollection<string>)c.ToList()));
        }
    }
}
