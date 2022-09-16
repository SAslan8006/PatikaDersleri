using System.Runtime.InteropServices;
using FluentAssertions;
using WebApi.App.ActorMoviesOperation.Command.Update;
using WebApi.UnitTests.TestSetup;
using Xunit;

namespace WebApi.UnitTests.App.ActorOperations.Commands.Update
{
    public class UpdateActorMoviesCommandValidatorTests : IClassFixture<CommonTestFixture>
    {
        [Theory]
        [InlineData(1,0,0)]
        [InlineData(1,1,0)]
        [InlineData(1,0,1)]
        [InlineData(1,null,1)]
        [InlineData(1,1,null)]
        [InlineData(0,1,1)]
        [InlineData(null,1,1)]
        public void WhenInvalidInputsAreGiven_Validator_ShouldBeReturnErorrs(int actorMovieId ,int movieId, int actorId)
        {
            //arrange
            UpdateActorMovieCommand command = new UpdateActorMovieCommand(null,null);
            command.model = new UpdateActorMovieModel()
            {
                MovieId = movieId,
                ActorId = actorId
            };
            command.Id = actorMovieId;

            //act
            UpdateActorMovieCommandValidator validator = new UpdateActorMovieCommandValidator();
            var results = validator.Validate(command);

            //assert
            results.Errors.Count.Should().BeGreaterThan(0);
        }

        [Theory]
        [InlineData(1,1,1)]                                
        public void WhenValidInputsAreGiven_Validator_ShouldNotBeReturnErorrs(int actorMovieId ,int movieId, int actorId)
        {
            //arrange
            UpdateActorMovieCommand command = new UpdateActorMovieCommand(null,null);
            command.model = new UpdateActorMovieModel()
            {
                MovieId = movieId,
                ActorId = actorId
            };
            command.Id = actorMovieId;

            //act
            UpdateActorMovieCommandValidator validator = new UpdateActorMovieCommandValidator();
            var results = validator.Validate(command);

            //assert
            results.Errors.Count.Should().BeLessThanOrEqualTo(0);
        }
    }
}