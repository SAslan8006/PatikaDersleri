using WebApi.DbOperations;
using WebApi.Entites;

namespace WebApi.App.DirectorMoviesOperation.Commands.Delete
{
     public class DeleteDirectorMovieCommand
    {
        private readonly IMovieStoreDbContext _dbContext;
        public int Id;
        public DeleteDirectorMovieCommand(IMovieStoreDbContext context)
        {
            _dbContext = context;
        }
        public void Handle()
        {
            DirectorMovies directorMovies = _dbContext.DirectorMovies.SingleOrDefault(s => s.Id == Id);

            if (directorMovies is null)
                throw new InvalidOperationException("ilgili kayda ait veri bulunamadı.");
            
            _dbContext.DirectorMovies.Remove(directorMovies);
            _dbContext.SaveChanges();
        }
    }
}