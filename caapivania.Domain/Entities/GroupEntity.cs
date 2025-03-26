using caapivania.Domain.Contracts;
using caapivania.Domain.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caapivania.Domain.Entities
{
    public class GroupEntity : Entity
    {
        public GroupEntity(string name, string description)
        {
            AddNotifications(EContract.CreateGroup(name, description));
            Name = name;
            Description = description;
            GenSlug(Name);
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public IList<GameEntity> Games { get; private set; } = new List<GameEntity>();

        public void AddGameToGroup(GameEntity game)
        {
            if (game.IsValid)
                Games.Add(game);
        }

        public void RemoveGameToGroup(GameEntity game)
        {
            if(Games.Contains(game))
                Games.Remove(game);
        }

        public void UpdateGroup(string name, string description)
        {
            AddNotifications(EContract.UpdateGroup(name, description));
            if (IsValid)
            {
                Name = name;
                Description = description;
                GenSlug(name);
            }
        }

        private void GenSlug(string name)
        {
            Slug = SlugUtils.With_One_String(name).ToLower();
        }
            

    }
}
