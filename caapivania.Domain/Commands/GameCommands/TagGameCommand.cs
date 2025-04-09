using Flunt.Notifications;
using Flunt.Validations;
using System.Text.RegularExpressions;

namespace caapivania.Domain.Commands.GameCommands
{
    public class TagGameCommand : Notifiable<Notification>
    {
        public TagGameCommand() { }

        public TagGameCommand(Guid gameId, Guid tagId)
        {
            GameId = gameId;
            TagId = tagId;
        }

        public Guid GameId { get; set; }
        public Guid TagId { get; set; }

        public void Validate()
        {
            AddNotifications(
                new Contract<TagGameCommand>()
                    .Requires()
                    .IsNotNull(GameId, "Game", "Game must be not null")
                    .IsNotNull(TagId, "Tag", "Tag must be not null")
            );
        }
    }
}
