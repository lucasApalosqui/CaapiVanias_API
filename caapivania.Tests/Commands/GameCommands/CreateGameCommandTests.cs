using caapivania.Domain.Commands.GameCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caapivania.Tests.Commands.GameCommands
{
    [TestClass]
    public class CreateGameCommandTests
    {
        private readonly CreateGameCommand _invalidCommand = new CreateGameCommand("c", "just a valid description", "https", "https", "https");
        private readonly CreateGameCommand _validCommand = new CreateGameCommand("castlevania", "just a valid description", "https", "https", "https");

        [TestMethod]
        public void given_a_valid_command_should_be_created()
        {
            _validCommand.Validate();
            Assert.IsTrue(_validCommand.IsValid);
        }
           
        [TestMethod]
        public void given_a_invalid_command_should_not_be_created()
        {
            _invalidCommand.Validate();
            Assert.IsFalse(_invalidCommand.IsValid);
        }
    }
}
