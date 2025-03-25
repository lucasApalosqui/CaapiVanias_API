
using caapivania.Domain.Entities;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace caapivania.Tests.Entities
{
    [TestClass]
    public class GameTests
    {
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

    }
}
