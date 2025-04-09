using Flunt.Notifications;
using Flunt.Validations;

namespace caapivania.Domain.Commands.GameCommands
{
    public class GameGroupCommand : Notifiable<Notification>
    {
        public GameGroupCommand() { }

        public GameGroupCommand(Guid gameId, Guid groupId)
        {
            GameId = gameId;
            GroupId = groupId;
        }

        public Guid GameId { get; set; }
        public Guid GroupId { get; set; }

        public void Validate()
        {
            AddNotifications(
                new Contract<GameGroupCommand>()
                    .Requires()
                    .IsNotNull(GameId, "Game", "Game must be not null")
                    .IsNotNull(GroupId, "Group", "Group must be not null")
             );
        }
    }
}
