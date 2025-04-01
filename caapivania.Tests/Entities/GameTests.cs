
using caapivania.Domain.Entities;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace caapivania.Tests.Entities
{
    [TestClass]
    public class GameTests
    {
        private GameEntity validGame = new GameEntity("castlevania", "apenas uma descrição válida", "https://image", "https://gameplay", "https://trailer");
        [TestMethod]
        public void Given_a_game_with_correct_data_should_be_created()
        {
            var game = new GameEntity("castlevania", "apenas uma descrição válida", "https://image", "https://gameplay", "https://trailer");
            Assert.IsNotNull(game);
        }

        [TestMethod]
        public void given_a_game_with_less_than_2_and_more_than_100_char_title_should_not_be_created()
        {
            int count = 0;
            var game1 = new GameEntity("c", "apenas uma descrição válida", "https://image", "https://gameplay", "https://trailer");
            var game2 = new GameEntity("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut ut aliquam diam. Mauris vitae ligula ligula. Suspendisse eget justo vel dui aliquam pulvinar at sit amet quam. Sed eget tellus sit amet elit bibendum posuere quis eget neque. Curabitur elementum, augue vel tincidunt fringilla, nisl sem auctor leo, et eleifend enim tortor at quam. Mauris non ligula mattis, pretium odio sit amet, rutrum purus. In blandit vitae orci a suscipit. Phasellus sodales consectetur purus id tempor. Etiam lobortis facilisis nisl eget facilisis. Maecenas porttitor, eros sit amet varius iaculis, risus ex elementum massa, id ultricies magna erat ut ipsum.", "apenas uma descrição válida", "https://image", "https://gameplay", "https://trailer");
            if (!game1.IsValid && !game2.IsValid)
                count = 2;

            Assert.AreEqual(2, count);
        }

        [TestMethod]
        public void given_a_game_with_less_than_10_and_more_than_1200_char_description_should_not_be_created()
        {
            int count = 0;
            var game1 = new GameEntity("castlevania", "invalido", "https://image", "https://gameplay", "https://trailer");
            var game2 = new GameEntity("castlevania", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut ut aliquam diam. Mauris vitae ligula ligula. Suspendisse eget justo vel dui aliquam pulvinar at sit amet quam. Sed eget tellus sit amet elit bibendum posuere quis eget neque. Curabitur elementum, augue vel tincidunt fringilla, nisl sem auctor leo, et eleifend enim tortor at quam. Mauris non ligula mattis, pretium odio sit amet, rutrum purus. In blandit vitae orci a suscipit. Phasellus sodales consectetur purus id tempor. Etiam lobortis facilisis nisl eget facilisis. Maecenas porttitor, eros sit amet varius iaculis, risus ex elementum massa, id ultricies magna erat ut ipsum.\r\nLorem ipsum dolor sit amet, consectetur adipiscing elit. Ut ut aliquam diam. Mauris vitae ligula ligula. Suspendisse eget justo vel dui aliquam pulvinar at sit amet quam. Sed eget tellus sit amet elit bibendum posuere quis eget neque. Curabitur elementum, augue vel tincidunt fringilla, nisl sem auctor leo, et eleifend enim tortor at quam. Mauris non ligula mattis, pretium odio sit amet, rutrum purus. In blandit vitae orci a suscipit. Phasellus sodales consectetur purus id tempor. Etiam lobortis facilisis nisl eget facilisis. Maecenas porttitor, eros sit amet varius iaculis, risus ex elementum massa, id ultricies magna erat ut ipsum.", "https://image", "https://gameplay", "https://trailer");
            if (!game1.IsValid && !game2.IsValid)
                count = 2;

            Assert.AreEqual(2, count);
        }

        [TestMethod]
        public void update_a_game_with_less_than_10_and_more_than_1200_char_description_should_not_be_updated()
        {
            var count = 0;
            var game1 = new GameEntity("castlevania", "apenas uma descrição válida", "https://image", "https://gameplay", "https://trailer");
            var game2 = new GameEntity("castlevania2", "apenas uma descrição válida", "https://image", "https://gameplay", "https://trailer");
            game1.UpdateInfo("castlevania", "invalido", "https://image", "https://gameplay", "https://trailer");
            game2.UpdateInfo("castlevania", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut ut aliquam diam. Mauris vitae ligula ligula. Suspendisse eget justo vel dui aliquam pulvinar at sit amet quam. Sed eget tellus sit amet elit bibendum posuere quis eget neque. Curabitur elementum, augue vel tincidunt fringilla, nisl sem auctor leo, et eleifend enim tortor at quam. Mauris non ligula mattis, pretium odio sit amet, rutrum purus. In blandit vitae orci a suscipit. Phasellus sodales consectetur purus id tempor. Etiam lobortis facilisis nisl eget facilisis. Maecenas porttitor, eros sit amet varius iaculis, risus ex elementum massa, id ultricies magna erat ut ipsum.\r\nLorem ipsum dolor sit amet, consectetur adipiscing elit. Ut ut aliquam diam. Mauris vitae ligula ligula. Suspendisse eget justo vel dui aliquam pulvinar at sit amet quam. Sed eget tellus sit amet elit bibendum posuere quis eget neque. Curabitur elementum, augue vel tincidunt fringilla, nisl sem auctor leo, et eleifend enim tortor at quam. Mauris non ligula mattis, pretium odio sit amet, rutrum purus. In blandit vitae orci a suscipit. Phasellus sodales consectetur purus id tempor. Etiam lobortis facilisis nisl eget facilisis. Maecenas porttitor, eros sit amet varius iaculis, risus ex elementum massa, id ultricies magna erat ut ipsum.", "https://image", "https://gameplay", "https://trailer");

            if (!game1.IsValid && !game2.IsValid)
                count = 2;
            Assert.AreEqual(2, count);
        }

        [TestMethod]
        public void update_a_game_with_less_than_2_and_more_than_100_char_title_should_not_be_updated()
        {
            var count = 0;
            var game1 = new GameEntity("castlevania", "apenas uma descrição válida", "https://image", "https://gameplay", "https://trailer");
            var game2 = new GameEntity("castlevania2", "apenas uma descrição válida", "https://image", "https://gameplay", "https://trailer");
            game1.UpdateInfo("c", "apenas uma descrição válida", "https://image", "https://gameplay", "https://trailer");
            game2.UpdateInfo("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut ut aliquam diam. Mauris vitae ligula ligula. Suspendisse eget justo vel dui aliquam pulvinar at sit amet quam. Sed eget tellus sit amet elit bibendum posuere quis eget neque. Curabitur elementum, augue vel tincidunt fringilla, nisl sem auctor leo, et eleifend enim tortor at quam. Mauris non ligula mattis, pretium odio sit amet, rutrum purus. In blandit vitae orci a suscipit. Phasellus sodales consectetur purus id tempor. Etiam lobortis facilisis nisl eget facilisis. Maecenas porttitor, eros sit amet varius iaculis, risus ex elementum massa, id ultricies magna erat ut ipsum.", "apenas uma descrição válida", "https://image", "https://gameplay", "https://trailer");
            if (!game1.IsValid && !game2.IsValid)
                count = 2;
            Assert.AreEqual(2, count);
        }
        [TestMethod]
        public void update_a_game_with_correct_data_should_be_updated()
        {
            var count = 0;
            var game1 = new GameEntity("castlevania", "apenas uma descrição válida", "https://image", "https://gameplay", "https://trailer");
            var veri = new GameEntity("titulo_atualizado", "apenas uma descrição atualizada", "https://image_att", "https://gameplay_att", "https://trailer");
            game1.UpdateInfo("titulo_atualizado", "apenas uma descrição atualizada", "https://image_att", "https://gameplay_att", "https://trailer");

            if (game1.Title == veri.Title && game1.Description == veri.Description && game1.ImageUrl == veri.ImageUrl && game1.GameplayUrl == veri.GameplayUrl && game1.TrailerUrl == veri.TrailerUrl)
                count = 1;
            Assert.AreEqual(1, count);
        }

        [TestMethod]
        public void Add_game_to_valid_group_should_be_added()
        {
            var game = validGame;
            game.AddToGroup(new GroupEntity("On holding", "game must be played"));
            Assert.AreEqual(game.Group.Name, "On holding");
        }

        [TestMethod]
        public void Add_game_to_invalid_group_should_not_be_added()
        {
            var game = validGame;
            game.AddToGroup(new GroupEntity("On holding", "game"));
            Assert.IsNull(game.Group);
        }

        [TestMethod]
        public void Modify_game_to_valid_group_should_be_modified()
        {
            var game = validGame;
            game.AddToGroup(new GroupEntity("On holding", "game must be played"));
            game.ModifyGroup(new GroupEntity("Playing", "game must be played"));
            Assert.AreEqual(game.Group.Name, "Playing");
        }

        [TestMethod]
        public void Modify_game_to_invalid_group_should_not_be_modified()
        {
            var game = validGame;
            game.AddToGroup(new GroupEntity("On holding", "game must be played"));
            game.ModifyGroup(new GroupEntity("Playing", "game"));
            Assert.AreEqual(game.Group.Name, "On holding");
        }

        [TestMethod]
        public void Add_valid_review_should_be_added()
        {
            var game = validGame;
            game.CreateReview("My first review", "just a valid description for my review");
            Assert.IsNotNull(game.Review);
        }

        [TestMethod]
        public void Add_invalid_review_should_not_be_added()
        {
            var game = validGame;
            game.CreateReview("My first review", "ju");
            Assert.IsNull(game.Review);
        }

        [TestMethod]
        public void Add_valid_tag_should_be_added()
        {
            var game = validGame;
            game.AddTag(new TagEntity("platformer", "jump in platforms"));
            Assert.AreEqual(game.Tags.Count, 1);
        }

        [TestMethod]
        public void Add_invalid_tag_should_not_be_added()
        {
            var game = validGame;
            game.AddTag(new TagEntity("platformer", "ju"));
            Assert.AreEqual(game.Tags.Count, 0);
        }

        [TestMethod]
        public void remove_tag_should_be_removed()
        {
            var game = validGame;
            var tag = new TagEntity("platformer", "jump in platforms");
            game.AddTag(tag);
            game.RemoveTag(tag);
            Assert.AreEqual(game.Tags.Count, 0);
        }

    }
}
