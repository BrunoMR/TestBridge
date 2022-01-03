using Microsoft.EntityFrameworkCore;
using MusicStore.Domain;

namespace MusicStore.Data
{
    public class AlbumContext : DbContext
    {
        public AlbumContext(DbContextOptions<AlbumContext> options)
            : base(options)
        {
        }

        public DbSet<Album> Albums { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder
        //        .UseSqlServer("Data Source = localhost; Initial Catalog = TestBridge;User Id=sa;Password=local14Tests");
        //}
    }
}
