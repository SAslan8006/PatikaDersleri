using FluentAssertions;
using WebApi.App.ActorMoviesOperation.Command.Create;
using WebApi.App.ActorOperations.Commands.Create;
using WebApi.UnitTests.TestSetup;
using Xunit;

namespace WebApi.UnitTests.App.ActorMoviesOpertaion.Commands.Create
{
    public class CreateActorMoviesCommandValidatorTests : IClassFixture<CommonTestFixture>
    {
        [Theory]
        [InlineData(0,0)]
        [InlineData(1,0)]
        [InlineData(0,1)]
        [InlineData(null,1)]
        [InlineData(1,null)]
        public void WhenInvalidInputsAreGiven_Validator_ShouldBeReturnErorrs(int movieId, int actorId)
        {
            //arrange
            CreateActorMoviesCommand command = new CreateActorMoviesCommand(null,null);
            command.model = new CreateActorMovieModel()
            {
                MovieId = movieId,
                ActorId = actorId
            };

            //act
            CreateActorMoviesCommandValidator validator = new CreateActorMoviesCommandValidator();
            var results = validator.Validate(command);

            //assert
            results.Errors.Count.Should().BeGreaterThan(0);
        }

        [Theory]
        [InlineData(1,1)]                                
        public void WhenValidInputsAreGiven_Validator_ShouldNotBeReturnErorrs(int movieId, int actorId)
        {
            //arrange
            CreateActorMoviesCommand command = new CreateActorMoviesCommand(null,null);
            command.model = new CreateActorMovieModel()
            {
                MovieId = movieId,
                ActorId = actorId
            };

            //act
            CreateActorMoviesCommandValidator validator = new CreateActorMoviesCommandValidator();
            var results = validator.Validate(command);

            //assert
            results.Errors.Count.Should().BeLessThanOrEqualTo(0);
        }

        
    }
}