using caapivania.Domain.Commands.GameCommands;
using caapivania.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caapivania.Tests.Commands.GameCommands
{
    [TestClass]
    public class UpdateGameCommandTests
    {
        private readonly GameEntity _validGameEntity = new GameEntity("Castlevania", "Just a valid description", "https:", "https:", "https:");

        [TestMethod]
        public void given_a_valid_command_should_be_created()
        {
            UpdateGameCommand validUpdateGameCommand = new UpdateGameCommand("Bloodstained", "Just a valid description", "https:", "https:", "https:", _validGameEntity.Id);
            validUpdateGameCommand.Validate();
            Assert.IsTrue(validUpdateGameCommand.IsValid);
        }

        [TestMethod]
        public void given_a_invalid_command_should_not_be_created()
        {
            UpdateGameCommand invalidUpdateGameCommand = new UpdateGameCommand("Bloodstained", "invalid", "https:", "https:", "https:", _validGameEntity.Id);
            invalidUpdateGameCommand.Validate();
            Assert.IsFalse(invalidUpdateGameCommand.IsValid);
        }
    }
}
