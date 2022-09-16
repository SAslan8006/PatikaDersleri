using AutoMapper;
using WebApi.App.DirectorOperations.Queries.Get;
using WebApi.DbOperations;
using WebApi.Entites;

namespace WebApi.App.DirectorOperations.Queries.GetDetail
{
    public class GetDirectorQueryDetail
    {
        private readonly IMovieStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public int Id;

        public GetDirectorQueryDetail(IMovieStoreDbContext context, IMapper mapper)
        {
            _dbContext = context;
            _mapper = mapper;
        }

        public DirectorQueryViewModel Handle()
        {
            Director director = _dbContext.Directors.SingleOrDefault(s => s.Id == Id);
            DirectorQueryViewModel vm = _mapper.Map<DirectorQueryViewModel>(director);

            return vm;
        }
    }
}