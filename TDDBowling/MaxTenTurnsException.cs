using System;

namespace TDDBowling
{
    public class MaxTenTurnsException : Exception
    {
        public MaxTenTurnsException()
            : base("A game can't contains more than 10 turns.")
        {

        }
    }
}