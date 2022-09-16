using System;
using System.Linq;
using AutoMapper;
using WebApi.DBOperations;
using WebApi.Entities;

namespace WebApi.Application.AuthorOperations.Commands.UpdateAuthor
{
    public class UpdateAuthorCommand
    {
        public int AuthorId { get; set; }
        public UpdateAuthorModel Model { get; set; }
        private BookStoreDbContext _context;
        private IMapper _mapper;

        public UpdateAuthorCommand(BookStoreDbContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }
        public void Handle()
        {
            var author = _context.Authors.SingleOrDefault(x=>x.Id == AuthorId);
            if (author is null)
                throw new InvalidOperationException("Aramaya çalıştığınız yazarı bulamadık");
            author.FirstName = Model.FirstName != default ? Model.FirstName : author.FirstName;
            author.LastName = Model.LastName != default ? Model.LastName : author.LastName;
            author.BirthOfDate = Model.BirthOfDate != default ? Model.BirthOfDate : author.BirthOfDate;

            _context.SaveChanges();

        }
    }
    public class UpdateAuthorModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthOfDate { get; set; }

    }
}
