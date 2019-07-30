using System.Collections.Generic;

namespace TDDBowling
{
    public class Game
    {
        public int TurnNumber { get; private set; }
        public const int MaxTurn = 10;
        public const int MaxPlayer = 8;

        public List<Player> players;

		public Game()
        {
            players = new List<Player>();
        }

        public void AddPlayer(Player player)
        {
            if (players.Count >= MaxPlayer)
            {
                throw new MaxPlayerReachedException();
            }

            players.Add(player);
        }

        public void PlayATurn()
        {
            if (TurnNumber > MaxTurn)
            {
                throw new MaxTenTurnsException();
            }

			TurnNumber++;
            foreach (var player in players)
            {
                player.ResetRolls();
            }
        }
    }
}
