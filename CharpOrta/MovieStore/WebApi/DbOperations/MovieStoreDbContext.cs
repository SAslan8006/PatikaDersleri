using Microsoft.EntityFrameworkCore;
using WebApi.Entites;

namespace WebApi.DbOperations
{
    public class MovieStoreDbContext : DbContext, IMovieStoreDbContext
    {
        public MovieStoreDbContext(DbContextOptions<MovieStoreDbContext> options) : base(options)
        {

        }

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.Entity<ActorMovies>()
        //         .HasKey(t => new { t.ActorId, t.MovieId });

        //     modelBuilder.Entity<ActorMovies>()
        //         .HasOne(ac => ac.Actor)
        //         .WithMany(a => a.ActorMovies)
        //         .HasForeignKey(ac => ac.ActorId);

        //     modelBuilder.Entity<ActorMovies>()
        //         .HasOne(mo => mo.Movie)
        //         .WithMany(m => m.ActorMovies)
        //         .HasForeignKey(mo => mo.MovieId);
        // }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<ActorMovies> ActorMovies { get; set; }
        public DbSet<DirectorMovies> DirectorMovies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<PurchasedMovies> PurchasedMovies { get; set; }
        public DbSet<FavoritesGenre> FavoritesGenres { get; set; }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}