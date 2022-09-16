using AutoMapper;
using WebApi.App.ActorOperations.Queries.Get;
using WebApi.DbOperations;
using WebApi.Entites;

namespace WebApi.App.ActorOperations.Queries.GetDetail
{
    public class GetActorsDetailQuery
    {
        private readonly IMovieStoreDbContext _context;
        private readonly IMapper _mapper;
        public int Id { get; set; }

        public GetActorsDetailQuery(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public GetActorsQueryViewModel Handle()
        {
            Actor actor = _context.Actors.SingleOrDefault(x => x.Id == Id);
            if (actor is null)
                throw new InvalidOperationException("Oyuncu mevcut değil.");
            
            GetActorsQueryViewModel vm = _mapper.Map<GetActorsQueryViewModel>(actor);

            return vm;
        }
    }
}