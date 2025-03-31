using Flunt.Validations;
using caapivania.Domain.Contracts;
using caapivania.Domain.Utils;

namespace caapivania.Domain.Entities
{
    public class GameEntity : Entity
    {
        public GameEntity(string title, string description, string imageurl, string gameplayurl, string trailerurl)
        {
            AddNotifications(EContract.CreateGame(title, description, imageurl, gameplayurl, trailerurl));

            Title = title; 
            Description = description;
            ImageUrl = imageurl;
            TrailerUrl = trailerurl;
            GameplayUrl = gameplayurl;
            GenSlug();
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public string ImageUrl { get; private set; }
        public string GameplayUrl { get; private set; }
        public string TrailerUrl { get; private set; }

        public void UpdateInfo(string title, string description, string imageurl, string gameplayurl, string trailerurl)
        {
            AddNotifications(EContract.UpdateGame(title, description, imageurl, gameplayurl, trailerurl));
            if (IsValid)
            {
                Title = title;
                Description = description;
                ImageUrl = imageurl;
                GameplayUrl = gameplayurl;
                TrailerUrl = trailerurl;
                GenSlug();
            }
        }

        public void GenSlug()
        {
            Slug = SlugUtils.With_One_String(Title).ToLower();
        }
    }
}
