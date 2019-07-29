using System.Collections.Generic;

namespace TDDBowling
{
    public class Game
    {
        private int Turn = 1;
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
            if (Turn > MaxTurn)
            {
                throw new MaxTenTurnsException();
            }

            Turn++;
            foreach (var player in players)
            {
                player.ResetShoot();
            }
        }
    }
}
