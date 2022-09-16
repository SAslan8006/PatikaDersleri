using System;
using System.Linq;
using WebApi.DBOperations;

namespace WebApi.Application.AuthorOperations.Commands.DeleteAuthor
{
    public class DeleteAuthorCommand
    {
        public int AuthorId { get; set; }
        private BookStoreDbContext _context;
        public DeleteAuthorCommand(BookStoreDbContext context)
        {
            _context = context;
        }
        public void Handle()
        {
            var author = _context.Authors.SingleOrDefault(x=>x.Id == AuthorId);
            if(author is null)
                throw new InvalidOperationException("Silinecek Yazar Bulunamadı");
            bool isAuthorHasBook = _context.Books.Any(x=>x.AuthorId == AuthorId);
            if(isAuthorHasBook)
                throw new InvalidOperationException("Bu Yazarın kitabı vardır silmeden önce ilk kayıtlı kitapların silinmesi gerekiyor");

            _context.Authors.Remove(author);
            _context.SaveChanges();
            
        }
    }
}