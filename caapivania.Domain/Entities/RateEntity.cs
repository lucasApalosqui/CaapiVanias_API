using caapivania.Domain.Contracts;
using caapivania.Domain.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caapivania.Domain.Entities
{
    public class RateEntity : Entity
    {

        public RateEntity(string name, string description)
        {
            AddNotifications(EContract.CreateRate(name, description));
            Name = name;
            Description = description;
            GenSlug();
        }

        public string Name { get; private set; }
        public string Description { get; private set; }

        private void GenSlug()
        {
            if (IsValid)
                Slug = SlugUtils.With_One_String(Name).ToLower();
        }

        public void UpdateRate(string name, string description)
        {
            AddNotifications(EContract.UpdateRate(name, description));
            if (IsValid)
            {
                Name = name;
                Description = description;
            }

        }




    }
}
