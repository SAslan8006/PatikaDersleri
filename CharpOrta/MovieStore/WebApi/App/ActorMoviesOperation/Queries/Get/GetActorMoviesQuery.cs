using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebApi.DbOperations;
using WebApi.Entites;

namespace WebApi.App.ActorMoviesOperation.Queries.Get
{
    public class GetActorMoviesQuery
    {
        private readonly IMovieStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public GetActorMoviesQuery(IMovieStoreDbContext context, IMapper mapper)
        {
            _dbContext = context;
            _mapper = mapper;
        }
        public List<GetActorMovieViewModel> Handle()
        {
            var actors = _dbContext.Actors.Include(i=> i.ActorMovies).ThenInclude(t=> t.Movie).OrderBy(x=> x.Id).ToList();
            List<GetActorMovieViewModel> vm = _mapper.Map<List<GetActorMovieViewModel>>(actors);

            return vm;
        }
    }

    public class GetActorMovieViewModel
    {
        public string NameSurName { get; set; }
        public IReadOnlyList<string> Movies { get; set; }
    }
}