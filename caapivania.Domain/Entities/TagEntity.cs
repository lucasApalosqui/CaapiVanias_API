using caapivania.Domain.Contracts;
using caapivania.Domain.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caapivania.Domain.Entities
{
    public class TagEntity : Entity
    {
        public TagEntity(string name, string description)
        {
            AddNotifications(EContract.CreateTag(name, description));
            Name = name;
            Description = description;
            GenSlug();
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public IList<GameEntity> Games { get; private set; } = new List<GameEntity>();

        public void AddGame(GameEntity game)
        {
            if(game.IsValid)
                Games.Add(game);
        }

        public void RemoveGame(GameEntity game)
        {
            if(Games.Contains(game))
                Games.Remove(game);
        }

        private void GenSlug()
        {
            if(IsValid)
                Slug = SlugUtils.With_One_String(Name).ToLower();
        }

        public void UpdateTag(string name, string description)
        {
            AddNotifications(EContract.UpdateTag(name, description));
            if (IsValid)
            {
                Name = name;
                Description = description;
            }
                
        }
    }
}
