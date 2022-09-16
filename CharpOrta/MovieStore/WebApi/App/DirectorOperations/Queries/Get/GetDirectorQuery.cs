using System.ComponentModel;
using AutoMapper;
using WebApi.DbOperations;
using WebApi.Entites;

namespace WebApi.App.DirectorOperations.Queries.Get
{
    public class GetDirectorQuery
    {
        private readonly IMovieStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public GetDirectorQuery(IMovieStoreDbContext context, IMapper mapper)
        {
            _dbContext = context;
            _mapper = mapper;
        }

        public List<DirectorQueryViewModel> Handle()
        {
            List<Director> list = _dbContext.Directors.OrderBy(x => x.Id).ToList();
            List<DirectorQueryViewModel> vm = _mapper.Map<List<DirectorQueryViewModel>>(list);

            return vm;
        }
    }

    public class DirectorQueryViewModel
    {
        public string NameSurname { get; set; }
        public IReadOnlyList<string> Movies { get; set; }
    }
}