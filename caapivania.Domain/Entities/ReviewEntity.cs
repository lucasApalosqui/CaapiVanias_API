using caapivania.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caapivania.Domain.Entities
{
    public class ReviewEntity : Entity
    {

        public ReviewEntity(string title, string description, GameEntity game)
        {
            AddNotifications(EContract.CreateReview(title, description, game));
            Title = title;
            Description = description;
            Game = game;
            GameId = game.Id;
            Date = DateTime.Now;
            GenSlug();
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime Date {  get; private set; }
        public int Average {  get; private set; }
        public GameEntity Game { get; private set; }
        public Guid GameId { get; private set; }
        public IList<RateReviewEntity> RateReviews { get; private set; } = new List<RateReviewEntity>();

        public void UpdateReview(string title, string description)
        {
            AddNotifications(EContract.UpdateReview(title, description));
            if (IsValid)
            {
                Title = title;
                Description = description;
                Date = DateTime.Now;
            }
        }

        public void CreateRateReview(RateEntity rate, int value)
        {
            RateReviews.Add(new RateReviewEntity(this, rate, value));
        }

        public void GenSlug()
        {
            Slug = $"{Game.Slug}-review";
        }
    }
}
