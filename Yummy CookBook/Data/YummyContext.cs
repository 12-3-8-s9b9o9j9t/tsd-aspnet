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
            : base(options) {}

    }
}
