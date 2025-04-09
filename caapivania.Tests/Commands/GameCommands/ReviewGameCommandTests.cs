

using caapivania.Domain.Commands.GameCommands;

namespace caapivania.Tests.Commands.GameCommands
{
    [TestClass]
    public class ReviewGameCommandTests
    {
        [TestMethod]
        public void given_a_valid_command_should_be_created()
        {
            var validCommand = new ReviewGameCommand(Guid.NewGuid(), "Just a review", "Just a valid review of the game");
            validCommand.Validate();
            Assert.IsTrue(validCommand.IsValid);
        }

        [TestMethod]
        public void given_a_invalid_command_should_not_be_created()
        {
            var invalidCommand = new ReviewGameCommand(Guid.Empty, "Just a review", "invalid");
            invalidCommand.Validate();
            Assert.IsFalse(invalidCommand.IsValid);
        }
    }
}
