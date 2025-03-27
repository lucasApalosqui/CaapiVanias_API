using caapivania.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caapivania.Tests.Entities
{
    [TestClass]
    public class RateTests
    {
        private RateEntity validRate = new RateEntity("ArtStyle", "Art styless");
        private RateEntity invalidRate = new RateEntity("a", "a");

        [TestMethod]
        public void Given_a_Rate_with_incorrect_Data_should_not_be_created()
        {
            var Rate = invalidRate;
            Assert.IsFalse(invalidRate.IsValid);
        }

        [TestMethod]
        public void Given_a_Tag_with_correct_Data_should_be_created()
        {
            Assert.IsTrue(validRate.IsValid);
        }

        [TestMethod]
        public void Update_a_Tag_with_correct_Data_should_be_updated()
        {
            bool validate = false;
            var rate = validRate;
            string upName = "Difficulty";
            string upDesc = "a Difficulty of the game";

            rate.UpdateRate(upName, upDesc);
            if (rate.Name == upName && rate.Description == upDesc)
                validate = true;

            Assert.IsTrue(validate);

        }

        [TestMethod]
        public void Update_a_Tag_with_incorrect_Data_should_be_not_updated()
        {
            bool validate = false;
            var rate = validRate;
            string upName = "Difficulty";
            string upDesc = "a style";

            rate.UpdateRate(upName, upDesc);
            if (rate.Name == upName && rate.Description == upDesc)
                validate = true;

            Assert.IsFalse(validate);
        }
    }
}
