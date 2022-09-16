using System.Diagnostics.Contracts;
using AutoMapper;
using WebApi.DbOperations;
using WebApi.Entites;

namespace WebApi.App.ActorMoviesOperation.Command.Update
{
    public class UpdateActorMovieCommand
    {
        private readonly IMovieStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public UpdateActorMovieModel model;
        public int Id;
        public UpdateActorMovieCommand(IMovieStoreDbContext context, IMapper mapper)
        {
            _dbContext = context;
            _mapper = mapper;
        }
        public void Handle()
        {
            Actor actor = _dbContext.Actors.SingleOrDefault(s => s.Id == model.ActorId);
            Movie movies = _dbContext.Movies.SingleOrDefault(s => s.Id == model.MovieId);
            ActorMovies actorMovies = _dbContext.ActorMovies.SingleOrDefault(s => s.Id == Id);

            if (actor is null)
                throw new InvalidOperationException("Oyuncu bulunamadı");
            else if (movies is null)
                throw new InvalidOperationException("Film bulunamadı");
            else if (actorMovies is null)
                throw new InvalidOperationException("ilgili kayda ait veri bulunamadı.");

            actorMovies.ActorId = model.ActorId == default ? actorMovies.ActorId : model.ActorId;
            actorMovies.MovieId = model.MovieId == default ? actorMovies.MovieId : model.MovieId;

            _dbContext.ActorMovies.Update(actorMovies);
            _dbContext.SaveChanges();
        }
    }

    public class UpdateActorMovieModel
    {
        public int MovieId { get; set; }
        public int ActorId { get; set; }
    }
}