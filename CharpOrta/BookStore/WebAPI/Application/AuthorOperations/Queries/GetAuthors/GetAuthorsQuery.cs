using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using WebApi.DBOperations;

namespace WebApi.Application.AuthorOperations.Queries.GetAuthors
{
    public class GetAuthorsQuery
    {
        private readonly BookStoreDbContext _context;
        private readonly IMapper _mapper;

        public GetAuthorsQuery(BookStoreDbContext context, IMapper mapper )
        {
            _context = context;
            _mapper = mapper;
        }
        public List<GetAllAuthorsViewModel> Handle()
        {
            var authors = _context.Authors.ToList();
            List<GetAllAuthorsViewModel> obj = _mapper.Map<List<GetAllAuthorsViewModel>>(authors);
            return obj;
        }

    }
    public class GetAllAuthorsViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string BirthOfDate { get; set; }
    }
}