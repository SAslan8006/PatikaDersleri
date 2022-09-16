using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebApi.Common.Mapper;
using WebApi.DbOperations;

namespace WebApi.UnitTests.TestSetup
{
    public class CommonTestFixture
    {
        public MovieStoreDbContext Context { get; set; }
        public IMapper Mapper { get; set; }

        public CommonTestFixture()
        {
            var options = new DbContextOptionsBuilder<MovieStoreDbContext>().UseInMemoryDatabase(databaseName: "MovieSotreTestDb").Options;
            Context = new MovieStoreDbContext(options);
            
            Context.Database.EnsureCreated(); 
            Context.AddData();
            Context.SaveChanges();

            Mapper = new MapperConfiguration(cfg => { cfg.AddProfile<MappingProfile>(); }).CreateMapper();
        }
    }

}