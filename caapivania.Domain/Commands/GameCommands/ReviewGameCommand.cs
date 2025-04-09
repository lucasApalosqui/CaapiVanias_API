
using Flunt.Notifications;
using Flunt.Validations;

namespace caapivania.Domain.Commands.GameCommands
{
    public class ReviewGameCommand : Notifiable<Notification>
    {
        public ReviewGameCommand() { }

        public ReviewGameCommand(Guid gameId, string title, string description)
        {
            GameId = gameId;
            Title = title;
            Description = description;
        }

        public Guid GameId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public void Validate()
        {
            AddNotifications(
                new Contract<ReviewGameCommand>()
                    .Requires()
                    .IsNotNull(GameId, "Game", "Game must be not null")
                    .IsBetween(Title.Length, 2, 100, "Title", "Title must be between 2 and 100 characters")
                    .IsBetween(Description.Length, 10, 5000, "description", "Description must be between 10 and 5000 characters")
            );
        }
    }
}
