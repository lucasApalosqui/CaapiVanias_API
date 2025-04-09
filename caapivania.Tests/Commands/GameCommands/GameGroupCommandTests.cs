using caapivania.Domain.Commands.GameCommands;

namespace caapivania.Tests.Commands.GameCommands
{
    [TestClass]
    public class GameGroupCommandTests
    {
        [TestMethod]
        public void given_a_valid_command_should_be_created()
        {
            var command = new GameGroupCommand(new Guid(), new Guid());
            command.Validate();
            Assert.IsTrue(command.IsValid);
        }
    }
}
