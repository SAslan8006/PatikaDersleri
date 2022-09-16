using AutoMapper;
using WebApi.App.DirectorMoviesOperation.Commands.Create;
using WebApi.DbOperations;
using WebApi.Entites;

namespace WebApi.App.DirectorMoviesOperation.Commands.Update
{
    public class UpdateDirectorMovieCommand
    {
        private readonly IMovieStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public DirectorMovieModel model;
        public int Id;
        public UpdateDirectorMovieCommand(IMovieStoreDbContext context, IMapper mapper)
        {
            _dbContext = context;
            _mapper = mapper;
        }
        public void Handle()
        {
            Director director = _dbContext.Directors.SingleOrDefault(s => s.Id == model.DirectorId);
            Movie movies = _dbContext.Movies.SingleOrDefault(s => s.Id == model.MovieId);
            DirectorMovies directorMovies = _dbContext.DirectorMovies.SingleOrDefault(s => s.Id == Id);

            if (director is null)
                throw new InvalidOperationException("Yönetmen bulunamadı!");
            else if (movies is null)
                throw new InvalidOperationException("Film bulunamadı!");
            else if(directorMovies is null)
                throw new InvalidOperationException("ilgili kayda ait veri bulunamadı.");

            directorMovies.DirectorId = model.DirectorId == default ? directorMovies.DirectorId : model.DirectorId;
            directorMovies.MovieId = model.MovieId == default ? directorMovies.MovieId : model.MovieId;

            _dbContext.DirectorMovies.Update(directorMovies);
            _dbContext.SaveChanges();
        }
    }
}