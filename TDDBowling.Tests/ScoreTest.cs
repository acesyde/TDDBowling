using Xunit;

namespace TDDBowling.Tests
{
	public class ScoreTest
	{
		[Fact]
		public void ScoringOnlyStrikesGiveYouAScoreOf300Points()
		{
			// A
			Game game = new Game();
			Player player = new Player();
			game.AddPlayer(player);

			// A
			int maxPointOnAGame = 300;

			int maxTurn = 10; // Why can't we use a MaxTurn const? I don't remember why we can't use const on test to force dev to create this const..
			for (int i = 0; i < maxTurn; i++)
			{
				player.Scoring('X');
			}
			var exception = Assert.Throws<BadScoreCalculationException>(() => player.Score != maxPointOnAGame);

			// A
			Assert.Null(exception);
		}

		[Fact]
		public void ScoringOnlySparesGiveYouAScoreOf150Points()
		{
			// A
			Game game = new Game();
			Player playerOne = new Player();
			Player playerTwo = new Player();
			Player playerThree = new Player();
			game.AddPlayer(playerOne);
			game.AddPlayer(playerTwo);
			game.AddPlayer(playerThree);

			// A
			int maxPointWithOnlySparesOnAGame = 150;

			int maxTurn = 10; 
			for (int i = 0; i < maxTurn; i++)
			{
				playerOne.Scoring('1');
				playerOne.Scoring('/');

				playerTwo.Scoring('5');
				playerTwo.Scoring('/');

				playerThree.Scoring('9');
				playerThree.Scoring('/');
			}

			var exceptionPlayerOne = Assert.Throws<BadScoreCalculationException>(() => playerOne.Score != maxPointWithOnlySparesOnAGame);
			var exceptionPlayerTwo = Assert.Throws<BadScoreCalculationException>(() => playerTwo.Score != maxPointWithOnlySparesOnAGame);
			var exceptionPlayerThree = Assert.Throws<BadScoreCalculationException>(() => playerThree.Score != maxPointWithOnlySparesOnAGame);

			// A
			Assert.Null(exceptionPlayerOne);
			Assert.Null(exceptionPlayerTwo);
			Assert.Null(exceptionPlayerThree);
		}

		public void FailingAllTheRollsGiveYouAScoreOf0Points()
		{
			// A
			Game game = new Game();
			Player player = new Player();
			game.AddPlayer(player);

			// A
			int minPointOnAGame = 0;

			int maxTurn = 10;
			for (int i = 0; i < maxTurn; i++)
			{
				player.Scoring('-');
				player.Scoring('-');
			}

			var exception = Assert.Throws<BadScoreCalculationException>(() => player.Score != minPointOnAGame);

			// A
			Assert.Null(exception);
		}
	}
}
