namespace WebApi.UnitTests.Application.BookOperations.Commands.DeleteBook
{
    using System;
    using System.Linq;
    using FluentAssertions;
    using global::WebApi.Application.BookOperations.Commands.DeleteBook;
    using global::WebApi.DBOperations;
    using TestSetup;
    using Xunit;

 
        public class DeleteBookCommandTests : IClassFixture<CommonTestFixture>
        {
            private int BookId { get; set; }
            private readonly BookStoreDbContext _context;
            public DeleteBookCommandTests(CommonTestFixture testFixture)
            {
                _context = testFixture.Context;
            }
            [Fact]
            public void WhenNotAlreadyExistBookIdIsGiven_InvalidOperationException_ShouldBeReturn()
            {
                //arrange(Hazırlık)
                DeleteBookCommand command = new DeleteBookCommand(_context);
                BookId = _context.Books.OrderByDescending(x => x.Id).FirstOrDefault().Id + 1;
                command.BookId = BookId;


                //act & assert(Çalıştırma)
                FluentActions.
                Invoking(() => command.Handle()).
                Should().Throw<InvalidOperationException>().And.Message.Should().Be("Silinecek Kitap Bulunamadı");
                //assert(Doğrulama)
            }
            [Fact]
            public void WhenValidInputsAreGiven_Book_ShouldBeDeleted()
            {
                DeleteBookCommand command = new DeleteBookCommand(_context);
                BookId = _context.Books.OrderBy(x => x.Id).FirstOrDefault().Id;
                command.BookId = BookId;

                FluentActions.Invoking(() => command.Handle()).Invoke();

                var book = _context.Books.SingleOrDefault(x=>x.Id == BookId);
                book.Should().BeNull();

            }

        }
}