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
        public ReviewEntity Review {  get; private set; }
        public GroupEntity Group { get; private set; }
        public Guid GroupId { get; private set; }
        public IList<TagEntity> Tags { get; private set; } = new List<TagEntity>();

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

        public void AddToGroup(GroupEntity group)
        {
            if (group.IsValid)
            {
                Group = group;
                GroupId = Group.Id;
            }
        }

        public void AddTag(TagEntity tag)
        {
            if(tag.IsValid)
                Tags.Add(tag);
        }

        public void RemoveTag(TagEntity tag)
        {
            if(Tags.Contains(tag))
                Tags.Remove(tag);
        }

        public void ModifyGroup(GroupEntity group)
        {
            if(Group != group && group.IsValid == true)
            {
                Group = group;
                GroupId = Group.Id;
            }
        }

        public void CreateReview(string title, string description)
        {
            var review = new ReviewEntity(title, description, this);
            if(review.IsValid)
                Review = review;
        }

        public void GenSlug()
        {
            Slug = SlugUtils.With_One_String(Title).ToLower();
        }
    }
}
