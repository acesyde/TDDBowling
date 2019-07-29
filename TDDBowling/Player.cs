namespace TDDBowling
{
	public class Player
	{
		private const int MaxShoot = 2;
		private int shoot = MaxShoot;

        public void Rolls()
        {
            if (shoot <= 0)
                throw new MaxTwoShootsException();

            shoot--;
        }

        public void ResetRolls()
        {
            shoot = MaxShoot;
        }
	}
}
