using caapivania.Domain.Contracts;
using caapivania.Domain.Utils;

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
            if(IsValid)
                Slug = SlugUtils.With_One_String(name).ToLower();
        }
            

    }
}
