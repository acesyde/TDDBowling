using System;
using Xunit;

namespace TDDBowling.Tests
{
    public class UnitTests
    {
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
