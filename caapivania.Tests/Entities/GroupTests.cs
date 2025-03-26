using caapivania.Domain.Entities;
using NuGet.Frameworks;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caapivania.Tests.Entities
{
    [TestClass]
    public class GroupTests
    {
        private GameEntity validGame = new GameEntity("castlevania", "its just a valid description", "https://", "https://", "https://");
        private GameEntity invalidGame = new GameEntity("c", "its just a valid description", "https://", "https://", "https://");
        private GroupEntity validGroup = new GroupEntity("On Holding", "Just a valid description");

        [TestMethod]
        public void Given_a_group_with_correct_data_should_be_created()
        {
            var group = validGroup;
            Assert.IsTrue(group.IsValid);
        }

        [TestMethod]
        public void Given_a_group_title_without_between_2_and_100_characters_should_not_be_created()
        {
            var count = 0;
            var group1 = new GroupEntity("O", "Just a valid description");
            var group2 = new GroupEntity("Sed porta est at dui sagittis, et elementum eros faucibus. Curabitur ultrices erat quam, quis aliquet neque molestie ac. Mauris lectus enim, tempor in mauris nec, placerat blandit eros. Curabitur aliquam odio at lacus commodo, quis imperdiet ligula molestie. Mauris est ante, volutpat gravida hendrerit nec, tempus nec elit. Proin id dapibus sapien. Fusce placerat congue ligula, ut mollis diam molestie vitae.", "Just a valid description");
            if (!group1.IsValid && !group2.IsValid)
                count = 2;

            Assert.AreEqual(2, count);
        }

        [TestMethod]
        public void Given_a_group_description_without_between_10_and_600_characters_should_not_be_created()
        {
            var count = 0;
            var group1 = new GroupEntity("On Holding", "Descri");
            var group2 = new GroupEntity("On Holding", "Sed porta est at dui sagittis, et elementum eros faucibus. Curabitur ultrices erat quam, quis aliquet neque molestie ac. Mauris lectus enim, tempor in mauris nec, placerat blandit eros. Curabitur aliquam odio at lacus commodo, quis imperdiet ligula molestie. Mauris est ante, volutpat gravida hendrerit nec, tempus nec elit. Proin id dapibus sapien. Fusce placerat congue ligula, ut mollis diam molestie vitae.Sed porta est at dui sagittis, et elementum eros faucibus. Curabitur ultrices erat quam, quis aliquet neque molestie ac. Mauris lectus enim, tempor in mauris nec, placerat blandit eros. Curabitur aliquam odio at lacus commodo, quis imperdiet ligula molestie. Mauris est ante, volutpat gravida hendrerit nec, tempus nec elit. Proin id dapibus sapien. Fusce placerat congue ligula, ut mollis diam molestie vitae.");
            if (!group1.IsValid && !group2.IsValid)
                count = 2;

            Assert.AreEqual(2, count);
        }

        [TestMethod]
        public void Update_a_group_description_with_invalid_data_should_not_be_updated()
        {
            var group = validGroup;
            group.UpdateGroup("Playing", "jus");
            Assert.AreNotEqual(group.Description, "jus");
        }

        [TestMethod]
        public void Update_a_group_title_with_invalid_data_should_not_be_updated()
        {
            var group = validGroup;
            group.UpdateGroup("P", "just a valid description");
            Assert.AreNotEqual(group.Name, "P");
        }

        [TestMethod]
        public void Update_group_with_correct_data_should_be_updated()
        {
            bool verify = false;
            var group = validGroup;
            group.UpdateGroup("Playing", "just a valid description");
            if(group.Name == "Playing" && group.Description == "just a valid description")
                verify = true;

            Assert.IsTrue(verify);
        }

        [TestMethod]
        public void Add_valid_game_in_group_should_be_sucessfully_added()
        {
            var group = validGroup;
            group.AddGameToGroup(validGame);
            Assert.AreEqual(group.Games.Count, 1);
        }

        [TestMethod]
        public void Add_invalid_game_in_group_should_be_not_sucessfully_added()
        {
            var group = validGroup;
            group.AddGameToGroup(invalidGame);
            Assert.AreEqual(group.Games.Count, 0);
        }

        [TestMethod]
        public void Remove_game_in_group_should_be_sucessfully_removed()
        {
            var group = validGroup;
            group.AddGameToGroup(validGame);
            group.RemoveGameToGroup(validGame);
            Assert.AreEqual(group.Games.Count, 0);
        }
    }
}
