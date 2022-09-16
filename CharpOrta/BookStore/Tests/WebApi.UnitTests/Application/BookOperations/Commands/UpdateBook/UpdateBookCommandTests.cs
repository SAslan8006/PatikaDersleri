using System;
using System.Linq;
using FluentAssertions;
using global::WebApi.Application.BookOperations.Commands.UpdateBook;
using global::WebApi.DBOperations;
using TestSetup;
using Xunit;

namespace WebApi.UnitTests.Application.BookOperations.Commands.UpdateBook
{
    public class UpdateBookCommandTests : IClassFixture<CommonTestFixture>
    {
        private int BookId { get; set; }
        private readonly BookStoreDbContext _context;
        public UpdateBookCommandTests(CommonTestFixture testFixture)
        {
            _context = testFixture.Context;
        }
        [Fact]
        public void WhenNotAlreadyExistBookIdIsGiven_InvalidOperationException_ShouldBeReturnError()
        {
            UpdateBookCommand command = new UpdateBookCommand(_context);
            BookId = _context.Books.OrderByDescending(x => x.Id).FirstOrDefault().Id + 1;
            command.BookId = BookId;

            FluentActions.
            Invoking(() => command.Handle()).
            Should().Throw<InvalidOperationException>().And.Message.Should().Be("Güncellenecek Kitap Bulunamadı");
        }
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void WhenValidInputsIsGiven_Book_ShouldBeUpdated(int bookId)
        {
            UpdateBookCommand command = new UpdateBookCommand(_context);
            command.BookId = bookId;
            UpdateBookModel model = new UpdateBookModel()
            {
                Title = "Hobbit",
                PageCount = 1000,
                PublishDate = DateTime.Now.Date.AddYears(-10),
                GenreId = 1,
                AuthorId = 1
            };
            command.Model = model;
            FluentActions.Invoking(() => command.Handle()).Invoke();

            var book = _context.Books.SingleOrDefault(book => book.Id == bookId);
            book.Should().NotBeNull();
            book.PageCount.Should().Be(model.PageCount);
            book.PublishDate.Should().Be(model.PublishDate);
            book.GenreId.Should().Be(model.GenreId);
            book.AuthorId.Should().Be(model.AuthorId);
        }
    }
}

