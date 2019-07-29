using Xunit;

namespace TDDBowling.Tests
{
	public class PlayerTest
	{
		[Fact]
		public void APlayerCanNotRollsMoreThan20TimesOnAGame()
		{
			// A
			Game game = new Game();
			Player player = new Player();
			game.AddPlayer(player);

			// A
			int maxRolls = 20;
			for (int i = 0; i < maxRolls; i++)
			{
				player.Rolls();
			}

			var exception = Assert.Throws<Max20RollsOnAGameException>(() => game.Rolls());

			// A
			Assert.NotNull(exception);
			Assert.Equal("A player can't rolls more than 20 times on a game", exception.Message);
		}

		[Theory]
		[InlineData(1)]
		[InlineData(2)]
		[InlineData(5)]
		public void AGameHaveOnly2RollsByPlayersPerTurns(int nbPlayer)
		{
			//A
			var game = new Game();
			for (int i = 0; i < nbPlayer; i++)
			{
				game.AddPlayer(new Player());
			}

			//A
			int gameTurnNumber = game.TurnNumber;

			for (int i = 0; i < nbPlayer; i++)
			{
				game.players[i].Rolls();
				game.players[i].Rolls();
			}

			var exception = Assert.Throws<MaxTwoRollsByPlayersPerTurnsException>(() => game.TurnNumber == gameTurnNumber + 1);

			// A
			Assert.NotNull(exception);
			Assert.Equal("A player can't rools more than 2 times per turn.", exception.Message);
		}
	}
}
