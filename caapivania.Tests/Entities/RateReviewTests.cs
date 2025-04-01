using caapivania.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caapivania.Tests.Entities
{
    [TestClass]
    public class RateReviewTests
    {
        private ReviewEntity validReview = new ReviewEntity("review of castlevania", "A valid description of castle", new GameEntity("Castlevania", "Justa a valid description", "https:", "https:", "https:"));
        private ReviewEntity invalidReview = new ReviewEntity("r", "A valid description of castle", new GameEntity("Castlevania", "Justa a valid description", "https:", "https:", "https:"));
        private RateEntity validRate = new RateEntity("Difficulty", "Just a valid description");
        private RateEntity invalidRate = new RateEntity("Difficulty", "Just");

        [TestMethod]
        public void Given_a_RateReview_with_incorrect_Data_should_not_be_created()
        {
            var rateReview = new RateReviewEntity(validReview, invalidRate, 0);
            Assert.IsFalse(rateReview.IsValid);
        }

        [TestMethod]
        public void Given_a_RateReview_with_correct_Data_should_be_created()
        {
            var rateReview = new RateReviewEntity(validReview, validRate, 5);
            Assert.IsTrue(rateReview.IsValid);
        }

        [TestMethod]
        public void Update_a_RateReview_with_correct_Data_should_be_updated()
        {
            var validator = false;
            var rateReview = new RateReviewEntity(validReview, validRate, 5);
            rateReview.UpdateRateReview(10);
            if (rateReview.Value == 10)
                validator = true;
            Assert.IsTrue(validator);
        }

        [TestMethod]
        public void Update_a_RateReview_with_incorrect_Data_should_not_be_updated()
        {
            var validator = false;
            var rateReview = new RateReviewEntity(validReview, invalidRate, 5);
            rateReview.UpdateRateReview(10);
            if (rateReview.Value == 10)
                validator = true;
            Assert.IsFalse(validator);
        }

    }
}
