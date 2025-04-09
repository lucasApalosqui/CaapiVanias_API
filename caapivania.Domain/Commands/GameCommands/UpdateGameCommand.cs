using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caapivania.Domain.Commands.GameCommands
{
    public class UpdateGameCommand : Notifiable<Notification>
    {
        public UpdateGameCommand() { }

        public UpdateGameCommand(string title, string description, string imageUrl, string gameplayUrl, string trailerUrl, Guid gameId)
        {
            Title = title;
            Description = description;
            ImageUrl = imageUrl;
            GameplayUrl = gameplayUrl;
            TrailerUrl = trailerUrl;
            GameId = gameId;
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public string ImageUrl { get; private set; }
        public string GameplayUrl { get; private set; }
        public string TrailerUrl { get; private set; }
        public Guid GameId { get; private set; }
        

        public void Validate()
        {
            AddNotifications(
                new Contract<UpdateGameCommand>()
                    .Requires()
                    .IsLowerThan(Title.Length, 100, "title", "Title must be longer than 2 characters")
                    .IsGreaterThan(Title.Length, 2, "title", "Title must be no longer than 100 characters")
                    .IsLowerThan(Description.Length, 1200, "Description", "Description must be longer than 2 characters")
                    .IsGreaterThan(Description.Length, 10, "Description", "description must be no longer than 1200 characters")
                    .IsNotNullOrEmpty(GameId.ToString(), "Game", "Game must be not null or empty")
            );
        }
    }
}
