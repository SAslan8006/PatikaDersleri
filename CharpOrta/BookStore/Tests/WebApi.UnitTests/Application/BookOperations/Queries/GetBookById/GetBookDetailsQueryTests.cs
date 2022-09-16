using System;
using System.Linq;
using AutoMapper;
using FluentAssertions;
using TestSetup;
using WebApi.Application.BookOperations.Queries.GetById;
using WebApi.DBOperations;
using Xunit;

namespace WebApi.UnitTests.Application.BookOperations.Queries.GetBookById
{
    public class GetBookDetailsQueryTests : IClassFixture<CommonTestFixture>
    {
        private int BookId{get;set;}
        private readonly BookStoreDbContext _context;
        private readonly IMapper _mapper;
        public GetBookDetailsQueryTests(CommonTestFixture testFixture)
        {
            _context = testFixture.Context;
            _mapper = testFixture.Mapper;

        }
        [Fact]
        public void WhenNotAlreadyExistBookIdIsGiven_InvalidOperationException_ShouldBeReturn()
        {
            GetByIdQuery query = new GetByIdQuery(_context, _mapper);
            BookId = _context.Books.OrderByDescending(x=>x.Id).FirstOrDefault().Id+1;
           // var book = _context.Books.SingleOrDefault(x=>x.Id == BookId);

            FluentActions.
            Invoking(()=>query.Handle()).
            Should().Throw<InvalidOperationException>().
            And.Message.Should().Be("Kitap Bulunamadı");
        }
    }
}