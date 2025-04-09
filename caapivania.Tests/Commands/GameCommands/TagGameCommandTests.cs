using caapivania.Domain.Commands.GameCommands;

namespace caapivania.Tests.Commands.GameCommands
{
    [TestClass]
    public class TagGameCommandTests
    {
        [TestMethod]
        public void given_a_valid_command_should_be_created()
        {
            var command = new TagGameCommand(Guid.NewGuid(), Guid.NewGuid());
            command.Validate();
            Assert.IsTrue(command.IsValid);
        }
    }
}
