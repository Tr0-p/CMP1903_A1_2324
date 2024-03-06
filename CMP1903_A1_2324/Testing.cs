using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */

        //Method

        public void RunTest()
        {
            Game testGame = new Game();
            Die testDie = new Die();
            
            // Die Testing
            int testCases = 50;

            for (int i = 0; i < testCases; i++)
            {
                int newRoll = testDie.Roll();
                
                Debug.Assert(newRoll < 7 && newRoll > 0, "Dice Roll detected as out of bounds.");
            }
            
            // Game Testing
            var gameResults = testGame.StartRoll();
            int sumOfDie = gameResults.Item1.CurrentValue + gameResults.Item2.CurrentValue +
                           gameResults.Item3.CurrentValue;
            
            // Check for general addition errors.
            Debug.Assert(sumOfDie == gameResults.Item4, "Error in the addition of Die Values ");
            
            // Check the boundaries of the sum (3 being the minimum, 18 being the maximum)
            Debug.Assert(sumOfDie <= 18 && sumOfDie >= 3, "Sum is out of bounds.");
        }
    }
}
