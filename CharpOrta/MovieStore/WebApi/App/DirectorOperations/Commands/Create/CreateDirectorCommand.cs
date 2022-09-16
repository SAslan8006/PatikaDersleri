using AutoMapper;
using Microsoft.AspNetCore.Server.IIS.Core;
using WebApi.DbOperations;
using WebApi.Entites;

namespace WebApi.App.DirectorOperations.Commands.Create
{
    public class CreateDirectorCommand
    {
        private readonly IMovieStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public DirectorModel model;

        public CreateDirectorCommand(IMovieStoreDbContext context, IMapper mapper)
        {
            _dbContext = context;
            _mapper = mapper;
        }
        public void Handle()
        {
            Director list = _dbContext.Directors.SingleOrDefault(s => s.Name.Trim().ToLower() == model.Name.Trim().ToLower() && s.SurName.Trim().ToLower() == model.SurName.Trim().ToLower());
            if (list is not null)
                throw new InvalidOperationException("Yönetmen zaten kayıtlı.");
            
            Director director = _mapper.Map<Director>(model);

            _dbContext.Directors.Add(director);
            _dbContext.SaveChanges();            
        }
    }

    public class DirectorModel
    {
        public string Name { get; set; }
        public string SurName { get; set; }
    }
}