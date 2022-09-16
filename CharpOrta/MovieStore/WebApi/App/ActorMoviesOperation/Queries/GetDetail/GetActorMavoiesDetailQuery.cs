using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebApi.App.ActorMoviesOperation.Queries.Get;
using WebApi.DbOperations;
using WebApi.Entites;

namespace WebApi.App.ActorMoviesOperation.Queries.GetDetail
{
    public class GetActorMoviesDetailQuery
    {
        private readonly IMovieStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public int Id { get; set; }

        public GetActorMoviesDetailQuery(IMovieStoreDbContext context, IMapper mapper)
        {
            _dbContext = context;
            _mapper = mapper;
        }
        public GetActorMovieViewModel Handle()
        {
            Actor actors = _dbContext.Actors.Include(i=> i.ActorMovies).ThenInclude(t=> t.Movie).SingleOrDefault(x=> x.Id == Id);
            if(actors is null)
                throw new InvalidOperationException("Oyuncu bulunamadı.");

            GetActorMovieViewModel vm = _mapper.Map<GetActorMovieViewModel>(actors);

            return vm;
        }
    }
}