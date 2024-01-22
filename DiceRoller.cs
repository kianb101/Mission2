using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{

    internal class DiceRoller
    {
        private Random random = new Random();

        public int[] RollDice(int rolls)
        {
            int[] results = new int[13];
            for (int i = 0; i < rolls; i++)
            {
                int roll = random.Next(1, 7) + random.Next(1, 7);
                results[roll]++;
            }
            return results;
        }
    }
}
