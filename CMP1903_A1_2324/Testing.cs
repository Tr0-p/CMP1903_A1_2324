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

        /// <summary>
        /// Run the testing criterion and test each class.
        /// </summary>
        public void RunTest()
        {
            // Create instances of the Game Class and Die Class
            Game testGame = new Game();
            Die testDie = new Die();
            
            // Die Testing
            int testCases = 50; // Define how many test cases to do.

            for (int i = 0; i < testCases; i++)
            {
                // Create a new dice each time and ensure the rolls are in range.
                int newRoll = testDie.Roll();
                
                Debug.Assert(newRoll < 7, "Dice Roll too high.");
                Debug.Assert(newRoll >= 1, "Dice Roll too low.");
            }
            
            // Game Testing
            // Create a roll, ensure the addition of the dice matches the result.
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
