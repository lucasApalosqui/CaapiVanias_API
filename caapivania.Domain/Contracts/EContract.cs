using caapivania.Domain.Entities;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caapivania.Domain.Contracts
{
    public static class EContract
    {
        #region Game Contracts
        public static Contract<GameEntity> CreateGame(string title, string description, string imageurl, string gameplayurl, string trailerurl)
        {
            return new Contract<GameEntity>()
                     .Requires()
                     .IsLowerThan(title.Length, 100, "title", "Title must be longer than 2 characters")
                     .IsGreaterThan(title.Length, 2, "title", "Title must be no longer than 100 characters")
                     .IsLowerThan(description.Length, 1200, "Description", "Description must be longer than 2 characters")
                     .IsGreaterThan(description.Length, 10, "Description", "description must be no longer than 1200 characters");
        }

        public static Contract<GameEntity> UpdateGame(string title, string description, string imageurl, string gameplayurl, string trailerurl)
        {
            return new Contract<GameEntity>()
                     .Requires()
                     .IsLowerThan(title.Length, 100, "title", "Title must be longer than 2 characters")
                     .IsGreaterThan(title.Length, 2, "title", "Title must be no longer than 100 characters")
                     .IsLowerThan(description.Length, 1200, "Description", "Description must be longer than 2 characters")
                     .IsGreaterThan(description.Length, 10, "Description", "description must be no longer than 1200 characters");
        }

        #endregion
    }
}
