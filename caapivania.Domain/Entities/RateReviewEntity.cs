using caapivania.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caapivania.Domain.Entities
{
    public class RateReviewEntity : Entity
    {
        public RateReviewEntity(ReviewEntity review, RateEntity rate, int value)
        {
            AddNotifications(EContract.CreateRateReview(review, rate, value));
            Rate = rate;
            RateId = rate.Id;
            Review = review;
            ReviewId = review.Id;
            Value = value;
        }

        public RateEntity Rate { get; private set; }
        public Guid RateId { get; private set; }
        public ReviewEntity Review { get; private set; }
        public Guid ReviewId { get; private set; }
        public int Value { get; private set; }

        public void UpdateRateReview(int value)
        {
            AddNotifications(EContract.UpdateRateReview(value));
            if(IsValid)
                Value = value;
        }
    }
}
