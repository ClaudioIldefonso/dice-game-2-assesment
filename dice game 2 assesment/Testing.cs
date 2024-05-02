using CMP1903_A1_2324;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dice_game_2_assesment
{
    internal class Testing
    {
        /* the die test works the same way as the test game*/
        private void testDie()
        {
            Random random = new Random();
            Die die = new Die(random);
            int DieResult = die.Roll();

            Debug.Assert(DieResult >= 1 && DieResult <= 6, "invalid Die Value");

            Console.WriteLine($" test die roll result: {DieResult}");
        }
        /* this error handling works by using the Debug.assert to take the 
         roll total value*/

        private void testThreeOrMore()
        {
            ThreeOrMore game = new ThreeOrMore();
        }
        private void TestSevensOut() 
        { 
           SevensOut game2 = new SevensOut();
            int Total = game2.RollTotalAddUp();
            Debug.Assert(Total >= 2 && Total <= 12, "invalid roll total");
            Console.WriteLine($" test roll total is {Total}");
        }
        public Testing() 
        { 
            testDie();
            testThreeOrMore();
            TestSevensOut();
        }
    }
}
