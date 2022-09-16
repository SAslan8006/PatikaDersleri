using WebApi.DbOperations;
using WebApi.Entites;

namespace WebApi.App.PurchasedMoviesOperation.Commands.Delete
{
     public class DeletePurchasedMovieCommand
    {
        private readonly IMovieStoreDbContext _dbContext;
        public int Id;
        public DeletePurchasedMovieCommand(IMovieStoreDbContext context)
        {
            _dbContext = context;
        }
        public void Handle()
        {
            PurchasedMovies purchasedMovies = _dbContext.PurchasedMovies.SingleOrDefault(s => s.Id == Id);
            if (purchasedMovies is null)
                throw new InvalidOperationException("ilgili kayda ait veri bulunamadı.");

            purchasedMovies.movieStatus = false;
            
            _dbContext.PurchasedMovies.Update(purchasedMovies);
            _dbContext.SaveChanges();
        }
    }
}