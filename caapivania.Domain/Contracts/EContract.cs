using caapivania.Domain.Entities;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        #region Group Contracts
        public static Contract<GroupEntity> CreateGroup(string name, string description)
        {
            return new Contract<GroupEntity>()
                   .Requires()
                   .IsBetween(name.Length, 2, 100, "Name", "Name must be between 2 and 100 characters")
                   .IsBetween(description.Length, 10, 600, "description", "Description must be between 10 and 600 characters");
        }

        public static Contract<GroupEntity> UpdateGroup(string name, string description)
        {
            return new Contract<GroupEntity>()
                   .Requires()
                   .IsBetween(name.Length, 2, 100, "Name", "Name must be between 2 and 100 characters")
                   .IsBetween(description.Length, 10, 600, "description", "Description must be between 10 and 600 characters");
        }
        #endregion

        #region Tag Contracts
        public static Contract<TagEntity> CreateTag(string name, string description)
        {
            return new Contract<TagEntity>()
                   .Requires()
                   .IsBetween(name.Length, 2, 100, "Name", "Name must be between 2 and 100 characters")
                   .IsBetween(description.Length, 10, 400, "description", "Description must be between 10 and 400 characters");
        }

        public static Contract<TagEntity> UpdateTag(string name, string description)
        {
            return new Contract<TagEntity>()
                   .Requires()
                   .IsBetween(name.Length, 2, 100, "Name", "Name must be between 2 and 100 characters")
                   .IsBetween(description.Length, 10, 600, "description", "Description must be between 10 and 400 characters");
        }
        #endregion

        #region Rate Contracts
        public static Contract<RateEntity> CreateRate(string name, string description)
        {
            return new Contract<RateEntity>()
                   .Requires()
                   .IsBetween(name.Length, 2, 100, "Name", "Name must be between 2 and 100 characters")
                   .IsBetween(description.Length, 10, 400, "description", "Description must be between 10 and 400 characters");
        }

        public static Contract<RateEntity> UpdateRate(string name, string description)
        {
            return new Contract<RateEntity>()
                   .Requires()
                   .IsBetween(name.Length, 2, 100, "Name", "Name must be between 2 and 100 characters")
                   .IsBetween(description.Length, 10, 600, "description", "Description must be between 10 and 400 characters");
        }
        #endregion

        #region Rate Contracts
        public static Contract<ReviewEntity> CreateReview(string title, string description, GameEntity game)
        {
            return new Contract<ReviewEntity>()
                   .Requires()
                   .IsBetween(title.Length, 2, 100, "Title", "Title must be between 2 and 100 characters")
                   .IsBetween(description.Length, 10, 5000, "description", "Description must be between 10 and 5000 characters")
                   .IsTrue(game.IsValid, "Game", "Game must be Valid");
        }

        public static Contract<ReviewEntity> UpdateReview(string title, string description)
        {
            return new Contract<ReviewEntity>()
                   .Requires()
                   .IsBetween(title.Length, 2, 100, "Title", "Title must be between 2 and 100 characters")
                   .IsBetween(description.Length, 10, 5000, "description", "Description must be between 10 and 5000 characters");
        }
        #endregion

        #region RateReview Contracts
        public static Contract<RateReviewEntity> CreateRateReview(ReviewEntity review, RateEntity rate, int value)
        {
            return new Contract<RateReviewEntity>()
                   .Requires()
                   .IsBetween(value, 1, 10, "Value", "The Value must between 1 and 10")
                   .IsTrue(rate.IsValid, "Rate", "Rate must be valid")
                   .IsTrue(review.IsValid, "Review", "Review must be valid");
        }

        public static Contract<RateReviewEntity> UpdateRateReview(int value)
        {
            return new Contract<RateReviewEntity>()
                   .Requires()
                   .IsBetween(value, 1, 10, "Value", "The Value must between 1 and 10");
        }
        #endregion
    }
}
