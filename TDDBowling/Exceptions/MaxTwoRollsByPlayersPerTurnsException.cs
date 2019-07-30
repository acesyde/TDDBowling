using System;

namespace TDDBowling
{
    public class MaxTwoRollsByPlayersPerTurnsException : Exception
    {
		public MaxTwoRollsByPlayersPerTurnsException()
			: base("A player can't rools more than 2 times per turn.")
		{

		}
    }
}