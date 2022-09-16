using Microsoft.EntityFrameworkCore;
using WebApi.Entites;

namespace WebApi.DbOperations
{
    public interface IMovieStoreDbContext
    {
        DbSet<Movie> Movies { get; set; }
        DbSet<Actor> Actors { get; set; }
        DbSet<Director> Directors { get; set; }
        DbSet<ActorMovies> ActorMovies { get; set; }
        DbSet<DirectorMovies> DirectorMovies { get; set; }
        DbSet<Customer> Customers { get; set; }
        DbSet<PurchasedMovies> PurchasedMovies { get; set; }
        DbSet<FavoritesGenre> FavoritesGenres { get; set; }
        
                        
        int SaveChanges();
    }
}