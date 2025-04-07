using Flunt.Notifications;
using Flunt.Validations;

namespace caapivania.Domain.Commands.GameCommands
{
    public class CreateGameCommand : Notifiable<Notification>
    {
        public CreateGameCommand() { }

        public CreateGameCommand(string title, string description, string imageUrl, string gameplayUrl, string trailerUrl)
        {
            Title = title;
            Description = description;
            ImageUrl = imageUrl;
            TrailerUrl = trailerUrl;
            GameplayUrl = gameplayUrl;
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public string ImageUrl { get; private set; }
        public string GameplayUrl { get; private set; }
        public string TrailerUrl { get; private set; }


        public void Validate()
        {
            AddNotifications(
                new Contract<CreateGameCommand>()
                 .Requires()
                 .IsLowerThan(Title.Length, 100, "title", "Title must be longer than 2 characters")
                 .IsGreaterThan(Title.Length, 2, "title", "Title must be no longer than 100 characters")
                 .IsLowerThan(Description.Length, 1200, "Description", "Description must be longer than 2 characters")
                 .IsGreaterThan(Description.Length, 10, "Description", "description must be no longer than 1200 characters")
            );
        }

    }
}
