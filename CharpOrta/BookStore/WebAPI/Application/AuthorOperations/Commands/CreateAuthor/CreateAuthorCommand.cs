using System;
using System.Linq;
using AutoMapper;
using WebApi.DBOperations;
using WebApi.Entities;

namespace WebApi.Application.AuthorOperations.Commands.CreateAuthor
{
    public class CreateAuthorCommand
    {
        public CreateAuthorModel Model { get; set; }
        private BookStoreDbContext _context;
        private IMapper _mapper;

        public CreateAuthorCommand(BookStoreDbContext context,IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }
        public void Handle()
        {
            var author = _context.Authors.SingleOrDefault(x=>x.FirstName == Model.FirstName && x.LastName == Model.LastName);
            if(author is not null)
                throw new InvalidOperationException("Eklemeye Çalıştığınız Yazar Zaten Sistemimize Kayıtlıdır");
            author = _mapper.Map<Author>(Model);

            _context.Authors.Add(author);
            _context.SaveChanges();

        }
    }
    public class CreateAuthorModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthOfDate { get; set; }

    }
}