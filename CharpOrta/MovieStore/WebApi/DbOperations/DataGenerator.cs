using Microsoft.EntityFrameworkCore;
using WebApi.Entites;

namespace WebApi.DbOperations
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MovieStoreDbContext(serviceProvider.GetRequiredService<DbContextOptions<MovieStoreDbContext>>()))
            {

                context.Movies.AddRange(
                    new Movie
                    {
                        Name = "test",                        
                        //ActorsId = 1,
                        GenreId = 1,
                        Price = 100,
                        PublishDate = new DateTime(1997, 01, 07),

                    },
                    new Movie
                    {
                        Name = "test2",                        
                        //ActorsId = 3,
                        GenreId = 2,
                        Price = 200,
                        PublishDate = new DateTime(1999, 08, 28),
                    },
                    new Movie
                    {
                        Name = "test3",                        
                        //ActorsId = 3,
                        GenreId = 3,
                        Price = 300,
                        PublishDate = new DateTime(2022, 05, 01),
                    },
                    new Movie
                    {
                        Name = "test4",                        
                        //ActorsId = 3,
                        GenreId = 3,
                        Price = 300,
                        PublishDate = new DateTime(2022, 05, 01),
                    }
                );

                context.Actors.AddRange(
                    new Actor
                    {
                        Name = "actor1",
                        SurName = "actorSurname1",                        

                    },
                    new Actor
                    {
                        Name = "actor2",
                        SurName = "actorSurname2",                        
                    },
                    new Actor
                    {
                        Name = "actor3",
                        SurName = "actorSurname3",                        
                    },
                    new Actor
                    {
                        Name = "actor3",
                        SurName = "actorSurname3",                        
                    }
                );

                context.ActorMovies.AddRange(
                    new ActorMovies
                    {
                        ActorId = 1,
                        MovieId = 1
                    },
                    new ActorMovies
                    {
                        ActorId = 1,
                        MovieId = 2
                    },
                    new ActorMovies
                    {
                        ActorId = 2,
                        MovieId = 1
                    },
                    new ActorMovies
                    {
                        ActorId = 3,
                        MovieId = 1
                    },
                    new ActorMovies
                    {
                        ActorId = 4,
                        MovieId = 4
                    }
                );

                context.Directors.AddRange(
                    new Director
                    {
                        Name = "Director1",
                        SurName = "DirectorSurname1",                        

                    },
                    new Director
                    {
                        Name = "Director2",
                        SurName = "DirectorSurname2",                        
                    },
                    new Director
                    {
                        Name = "Director3",
                        SurName = "DirectorSurname3",                        
                    },
                    new Director
                    {
                        Name = "Director3",
                        SurName = "DirectorSurname3",                        
                    }
                );

                context.DirectorMovies.AddRange(
                    new DirectorMovies
                    {
                        DirectorId = 1,
                        MovieId = 1
                    },
                    new DirectorMovies
                    {
                        DirectorId = 2,
                        MovieId = 2
                    },
                    new DirectorMovies
                    {
                        DirectorId = 3,
                        MovieId = 3
                    },
                    new DirectorMovies
                    {
                        DirectorId = 4,
                        MovieId = 4
                    }

                );

                context.Customers.AddRange(
                    new Customer
                    {
                        Name = "Customer1",
                        SurName = "CustomerSurname1",    
                        Email = "ad1@ad.com",
                        Password = "1"                    
                    },
                    new Customer
                    {
                        Name = "Customer2",
                        SurName = "CustomerSurname2",  
                        Email = "ad2@ad.com",
                        Password = "2"                           
                    },
                    new Customer
                    {
                        Name = "Customer3",
                        SurName = "CustomerSurname3",
                        Email = "ad3@ad.com",
                        Password = "3"                             
                    },
                    new Customer
                    {
                        Name = "Customer4",
                        SurName = "CustomerSurname4",
                        Email = "ad4@ad.com",
                        Password = "4"                             
                    },
                    new Customer() 
                    { 
                        Name = "testName", 
                        SurName = "testSurname" , 
                        Email = "test@gmail.com", 
                        Password = "test"
                    }
                );

                context.PurchasedMovies.AddRange(
                    new PurchasedMovies
                    {
                        movieStatus = true,
                        purchasedTime = new DateTime(2022,01,5),
                        CustomerId = 1,
                        MovieId = 1
                    },
                    new PurchasedMovies
                    {
                        movieStatus = true,
                        purchasedTime = new DateTime(2022,05,2),
                        CustomerId = 1,
                        MovieId = 2
                    },
                    new PurchasedMovies
                    {
                        movieStatus = true,
                        purchasedTime = new DateTime(2022,03,7),
                        CustomerId = 1,
                        MovieId = 3
                    },
                    new PurchasedMovies
                    {
                        movieStatus = true,
                        purchasedTime = new DateTime(2019,05,4),
                        CustomerId = 2,
                        MovieId = 4
                    },
                    new PurchasedMovies
                    {
                        movieStatus = false,
                        purchasedTime = new DateTime(2020,02,6),
                        CustomerId = 2,
                        MovieId = 1
                    },
                    new PurchasedMovies
                    {
                        movieStatus = true,
                        purchasedTime = new DateTime(2020,02,6),
                        CustomerId = 3,
                        MovieId = 4
                    }
                );

                context.FavoritesGenres.AddRange(
                    new FavoritesGenre
                    {
                        CustomerId = 1,
                        FavoritesGenreId = 1
                    },
                    new FavoritesGenre
                    {
                        CustomerId = 1,
                        FavoritesGenreId = 2
                    },
                    new FavoritesGenre
                    {
                        CustomerId = 1,
                        FavoritesGenreId = 3
                    },
                    new FavoritesGenre
                    {
                        CustomerId = 2,
                        FavoritesGenreId = 4
                    },
                    new FavoritesGenre
                    {
                        CustomerId = 2,
                        FavoritesGenreId = 1
                    }
                );

                context.SaveChanges();
            }

        }
    }
}