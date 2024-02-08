using System.Diagnostics;

namespace BowlingScore
{
    public class BowlingScore
    {
        public static int getRunningScore(int[] rolls)
        {
            int currentScore = 0;
            int Length = rolls.Length;

            for (int i = 0; i < Length; i++)
            {
                if ((i > 0) && (i % 2 == 0) && (rolls[i - 2] + rolls[i - 1] == 10))
                {
                    currentScore += 2 * rolls[i];
                }
                else
                {
                    currentScore += rolls[i];
                }
            }

            return currentScore;
        }
    }
}