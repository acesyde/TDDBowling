using System;

namespace TDDBowling
{
    public class MaxTwoShootsException : Exception
    {
		public MaxTwoShootsException()
			: base("A player can't shoot more than 2 times per turn.")
		{

		}
    }
}