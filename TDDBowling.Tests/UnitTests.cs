using System;
using Xunit;

namespace TDDBowling.Tests
{
    public class UnitTests
    {
        [Fact]
        public void AGameCanContainsMaximumHeightPlayers()
        {
            // A
            var game = new Game();
            var playerOne = new Player();
            var playerTwo = new Player();
            var playerThree = new Player();
            var playerFour = new Player();
            var playerFive = new Player();
            var playerSix = new Player();
            var playerSeven = new Player();
            var playerHeight = new Player();
            var playerNine = new Player();

            // A
            game.AddPlayer(playerOne);
            game.AddPlayer(playerTwo);
            game.AddPlayer(playerThree);
            game.AddPlayer(playerFour);
            game.AddPlayer(playerFive);
            game.AddPlayer(playerSix);
            game.AddPlayer(playerSeven);
            game.AddPlayer(playerHeight);
            var exception = Assert.Throws<MaxPlayerReachedException>(() =>game.AddPlayer(playerNine));

            // A
            Assert.NotNull(exception);
            Assert.Equal("A game can contain only 8 players", exception.Message);
        }

        [Fact]
        public void AGameCanNotContainsMoreThanTenTurns()
        {
            // A
            var game = new Game();
            var playerOne = new Player();
            game.AddPlayer(playerOne);

            // A
            for (int i = 0; i < 10; i++)
            {
                game.PlayATurn();
            }

            var exception = Assert.Throws<MaxTenTurnsException>(() => game.PlayATurn());

            // A
            Assert.NotNull(exception);
            Assert.Equal("A game can't contains more than 10 turns.", exception.Message);
        }

        [Fact]
        public void AFrameCanNotContainsMoreThanTwoShoots()
        {
            //A
            var game = new Game();
            var playerOne = new Player();
            //A
            playerOne.Shoot();
            playerOne.Shoot();

            var exception = Assert.Throws<MaxTwoShootsException>(() => playerOne.Shoot());


            // A
            Assert.NotNull(exception);
            Assert.Equal("A player can't shoot more than 2 times per turn.", exception.Message);

        }
    }
}
