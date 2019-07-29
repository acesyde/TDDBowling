using System;

namespace TDDBowling
{
    public class MaxPlayerReachedException : Exception
    {
        public MaxPlayerReachedException()
			: base("A game can contain only 8 players")
        {
            
        }
    }
}