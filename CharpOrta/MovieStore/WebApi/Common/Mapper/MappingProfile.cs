using AutoMapper;
using WebApi.App.ActorMoviesOperation.Command.Create;
using WebApi.App.ActorMoviesOperation.Command.Update;
using WebApi.App.ActorMoviesOperation.Queries.Get;
using WebApi.App.ActorOperations.Commands.Create;
using WebApi.App.ActorOperations.Commands.Update;
using WebApi.App.ActorOperations.Queries.Get;
using WebApi.App.CustomerOperations.Commands.Create;
using WebApi.App.CustomerOperations.Queries.Get;
using WebApi.App.DirectorMoviesOperation.Commands.Create;
using WebApi.App.DirectorMoviesOperation.Queries.Get;
using WebApi.App.DirectorOperations.Commands.Create;
using WebApi.App.DirectorOperations.Queries;
using WebApi.App.DirectorOperations.Queries.Get;
using WebApi.App.FavoritesGenreOperations.Commands.Create;
using WebApi.App.FavoritesGenreOperations.Queries.Get;
using WebApi.App.MovieOperations.Commands.Create;
using WebApi.App.MovieOperations.Queries.Get;
using WebApi.App.PurchasedMoviesOperation.Commands.Create;
using WebApi.App.PurchasedMoviesOperation.Queries.Get;
using WebApi.App.PurchasedMoviesOperation.Queries.GetDetail;
using WebApi.Common.Enums.GenreEnums;
using WebApi.DbOperations;
using WebApi.Entites;

namespace WebApi.Common.Mapper
{
    public class MappingProfile : Profile
    {
        

        public MappingProfile()
        {
            //movie mapper
            CreateMap<Movie, MovieQueryViewModel>()
                .ForMember(dest => dest.Actors, opt => opt.MapFrom(m => m.ActorMovies.Select(s => s.Actor.Name + " " + s.Actor.SurName)))
                .ForMember(dest=> dest.Director, opt=> opt.MapFrom(m=> m.DirectorMovies.Select(s => s.Director.Name + " " + s.Director.SurName)))
                .ForMember(dest=> dest.Genre, opt=> opt.MapFrom(m=> (GenreEnums)m.GenreId));
            CreateMap<CreateMovieModel, Movie>();

            //actor mapper
            CreateMap<Actor, GetActorsQueryViewModel>();
            CreateMap<CreateActorModel, Actor>();
            CreateMap<Actor, GetActorMovieViewModel>()
                .ForMember(dest => dest.NameSurName, opt => opt.MapFrom(m => m.Name + " " + m.SurName))
                .ForMember(dest => dest.Movies, opt => opt.MapFrom(m => m.ActorMovies.Select(s => s.Movie.Name)));

            //actor movie mapper
            CreateMap<CreateActorMovieModel, ActorMovies>();           

            //director mapper    
            CreateMap<Director, DirectorQueryViewModel>()
                .ForMember(dest => dest.NameSurname, opt => opt.MapFrom(m => m.Name + " " + m.SurName));
                //.ForMember(dest => dest.Movies, opt => opt.MapFrom(m => m.ActorMovies.Select(s => s.Movie.Name))); 
            CreateMap<DirectorModel, Director>();

            //director movie mapper
            CreateMap<Director, GetDirectorMovieViewModel>()
                .ForMember(dest => dest.NameSurName, opt => opt.MapFrom(m => m.Name + " " + m.SurName))
                .ForMember(dest => dest.Movies, opt => opt.MapFrom(m => m.DirectorMovies.Select(s => s.Movie.Name)));
            CreateMap<DirectorMovieModel, DirectorMovies>();

            //customer mapper
            CreateMap<Customer, CustomerQueryViewModel>();
            CreateMap<CustomerModel, Customer>();

            //purchased movies mapper
            CreateMap<PurchasedMoviesModel, PurchasedMovies>();
            CreateMap<Customer, PurchasedMoviesViewModel>()
                .ForMember(dest => dest.NameSurname , opt => opt.MapFrom(m => m.Name + " " + m.SurName))
                .ForMember(dest => dest.Movies, opt => opt.MapFrom(m => m.PurchasedMovies.Select(s => s.Movie.Name)))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(m => m.PurchasedMovies.Select(s => s.Movie.Price)))
                .ForMember(dest => dest.PurchasedDate, opt => opt.MapFrom(m => m.PurchasedMovies.Select(s => s.purchasedTime)));
                

            //favorites genre mapper
             CreateMap<Customer, FavoritesGenreQueryViewModel>()
                .ForMember(dest => dest.NameSurname , opt => opt.MapFrom(m => m.Name + " " + m.SurName))
                .ForMember(dest => dest.Genres, opt => opt.MapFrom(m => m.FavoritesGenres.Select(s => (GenreEnums)s.FavoritesGenreId)));
            CreateMap<FavoriteGenresModel, FavoritesGenre>();


        }
    }
}