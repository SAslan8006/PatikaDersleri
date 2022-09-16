using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApi.Entities;

namespace WebApi.DBOperations
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BookStoreDbContext(serviceProvider.GetRequiredService<DbContextOptions<BookStoreDbContext>>()))
            {
                if (context.Books.Any())
                {
                    return;
                }
                context.Genres.AddRange(
                    new Genre
                    {
                        Name = "Personal Growth"
                    },
                    new Genre
                    {
                        Name = "Science Fiction"
                    },
                    new Genre
                    {
                        Name = "Romance"
                    }
                );
                context.Books.AddRange(new Book
                {
                    //Id = 1,
                    Title = "Lean Startup",
                    GenreId = 1,//Personal Growth
                    AuthorId =1,
                    PageCount = 200,
                    PublishDate = new DateTime(2001, 06, 12)
                }, new Book
                {
                    //Id = 2,
                    Title = "Herland",
                    GenreId = 2,//Science Fiction
                    AuthorId =2,
                    PageCount = 250,
                    PublishDate = new DateTime(2010, 05, 23)
                }, new Book
                {
                    //Id = 3,
                    Title = "Dune",
                    GenreId = 2,//Science Fiction
                    AuthorId =3,
                    PageCount = 540,
                    PublishDate = new DateTime(2002, 12, 21)
                }
            );
                context.Authors.AddRange(
                    new Author
                    {
                        FirstName ="Eric",
                        LastName ="Ries",
                        BirthOfDate =new DateTime(1978,09,22)

                    },
                    new Author
                    {
                        FirstName ="Charlotte Perkins",
                        LastName ="Gilman",
                        BirthOfDate =new DateTime(1860,07,03)

                    },
                    new Author
                    {
                        FirstName ="Frank",
                        LastName ="Herbert",
                        BirthOfDate =new DateTime(1920,10,08)

                    }
                );
                
                context.SaveChanges();
            }
        }
    }
}