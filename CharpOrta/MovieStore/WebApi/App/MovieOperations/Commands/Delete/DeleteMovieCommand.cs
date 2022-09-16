using WebApi.DbOperations;
using WebApi.Entites;

namespace WebApi.App.MovieOperations.Commands.Delete
{
    public class DeleteMovieCommand
    {
        private readonly IMovieStoreDbContext _context;
        public int Id;

        public DeleteMovieCommand(IMovieStoreDbContext context)
        {
            _context = context;
        }

        public void Handle()
        {
            Movie movie = _context.Movies.SingleOrDefault(x => x.Id == Id);

            if (movie is null)
                throw new InvalidOperationException("Silinecek kitap bulunamadı.");

            List<ActorMovies> actorMovies = _context.ActorMovies.Where(x => x.MovieId == Id).ToList();
            foreach (var item in actorMovies)
            {
                _context.ActorMovies.Remove(item);
            }
            
            _context.Movies.Remove(movie);
            _context.SaveChanges();
        }
    }
}