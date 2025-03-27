using caapivania.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caapivania.Tests.Entities
{
    [TestClass]
    public class TagTests
    {
        private GameEntity validGame = new GameEntity("castlevania", "its just a valid description", "https://", "https://", "https://");
        private GameEntity invalidGame = new GameEntity("c", "its just a valid description", "https://", "https://", "https://");
        private TagEntity validTag = new TagEntity("platformer", "a game about jump in platforms");
        private TagEntity invalidNameTag = new TagEntity("p", "a game about jump in platforms");
        private TagEntity invalidDescTag = new TagEntity("platformer", "a game");

        [TestMethod]
        public void Given_a_Tag_with_incorrect_Data_should_not_be_created()
        {
            var count = 0;
            if (!invalidNameTag.IsValid && !invalidDescTag.IsValid)
                count = 2;
            Assert.AreEqual(2, count);
        }

        [TestMethod]
        public void Given_a_Tag_with_correct_Data_should_be_created()
        {
            Assert.IsTrue(validTag.IsValid);
        }

        [TestMethod]
        public void Update_a_Tag_with_correct_Data_should_be_updated()
        {
            bool validate = false;
            var tag = validTag;
            string upName = "roguelite";
            string upDesc = "a style of difficulty game";

            tag.UpdateTag(upName, upDesc);
            if(tag.Name == upName && tag.Description == upDesc)
                validate = true;

            Assert.IsTrue(validate);
            
        }

        [TestMethod]
        public void Update_a_Tag_with_incorrect_Data_should_be_not_updated()
        {
            bool validate = false;
            var tag = validTag;
            string upName = "roguelite";
            string upDesc = "a style";

            tag.UpdateTag(upName, upDesc);
            if (tag.Name == upName && tag.Description == upDesc)
                validate = true;

            Assert.IsFalse(validate);
        }

        [TestMethod]
        public void Add_a_correct_game_should_be_addicted()
        {
            var tag = validTag;
            tag.AddGame(validGame);
            Assert.AreEqual(tag.Games.Count, 1);

        }

        [TestMethod]
        public void Add_a_incorrect_game_should_not_be_addicted()
        {
            var tag = validTag;
            tag.AddGame(invalidGame);
            Assert.AreEqual(tag.Games.Count, 0);
        }

        [TestMethod]
        public void Remove_a_game_should_be_removed()
        {
            var tag = validTag;
            tag.AddGame(validGame);
            tag.RemoveGame(validGame);
            Assert.AreEqual(tag.Games.Count, 0);
        }
    }
}
