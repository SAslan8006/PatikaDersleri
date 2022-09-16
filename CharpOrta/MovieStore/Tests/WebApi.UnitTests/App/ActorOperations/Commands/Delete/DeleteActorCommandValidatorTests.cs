using FluentAssertions;
using WebApi.App.ActorMoviesOperation.Command.Delete;
using WebApi.App.ActorOperations.Commands.Delete;
using WebApi.UnitTests.TestSetup;
using Xunit;

namespace WebApi.UnitTests.App.ActorOperations.Commands.Delete
{
    public class DeleteActorMoviesCommandValidatorTests : IClassFixture<CommonTestFixture>
    {
        [Theory]
        [InlineData(-1)]
        [InlineData(0)]         
        public void WhenInvalidInputsAreGiven_Validator_ShouldBeReturnErorrs(int actorMovieId)
        {
            //arrange
            DeleteActorCommand command = new DeleteActorCommand(null);
            
            command.Id = actorMovieId;

            //act
            DeleteActorCommandValidator validator = new DeleteActorCommandValidator();
            var results = validator.Validate(command);

            //assert
            results.Errors.Count.Should().BeGreaterThan(0);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]         
        public void WhenValidInputsAreGiven_Validator_ShouldNotBeError(int actorMovieId)
        {
            //arrange
            DeleteActorCommand command = new DeleteActorCommand(null);
            
            command.Id = actorMovieId;

            //act
            DeleteActorCommandValidator validator = new DeleteActorCommandValidator();
            var results = validator.Validate(command);

            //assert
            results.Errors.Count.Should().BeLessThanOrEqualTo(0);
        }
    }
}