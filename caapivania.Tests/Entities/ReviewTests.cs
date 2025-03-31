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
    public class ReviewTests
    {
        private ReviewEntity validReview = new ReviewEntity("my castlevania review", "just a review of castlevania", new GameEntity("Castlevania symphony of the night", "just only a valid description", "https:", "https:", "https:"));
        private ReviewEntity invalidReview = new ReviewEntity("m", "just", new GameEntity("Castlevania", "just only a valid description", "https:", "https:", "https:"));

        [TestMethod]
        public void Given_a_Review_with_incorrect_Data_should_not_be_created()
        {
            Assert.IsFalse(invalidReview.IsValid);
        }

        [TestMethod]
        public void Given_a_Review_with_correct_Data_should_be_created()
        {
            Assert.IsTrue(validReview.IsValid);
        }

        [TestMethod]
        public void Update_a_Review_with_correct_Data_should_be_updated()
        {
            var validator = false;
            var review = validReview;
            review.UpdateReview("another review of castlevania", "just another valid description");
            if (review.Title == "another review of castlevania" && review.Description == "just another valid description" && review.Date.Day == DateTime.Now.Day)
                validator = true;
            Assert.IsTrue(validator);
        }

        [TestMethod]
        public void Update_a_Review_with_incorrect_Data_should_not_be_updated()
        {
            var validator = false;
            var review = validReview;
            review.UpdateReview("a", "just another valid description");
            if (review.Title == "a" && review.Description == "just another valid description" && review.Date.Day == DateTime.Now.Day)
                validator = true;
            Assert.IsFalse(validator);
        }
    }
}
