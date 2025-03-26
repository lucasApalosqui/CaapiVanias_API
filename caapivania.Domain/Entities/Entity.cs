using Flunt.Notifications;

namespace caapivania.Domain.Entities
{
    public abstract class Entity : Notifiable<Notification>, IEquatable<Entity>
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
        public string Slug { get; set; }

        public bool Equals(Entity other) =>
            Id == other.Id;

    }
}
