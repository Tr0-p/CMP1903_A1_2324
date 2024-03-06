using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Create a Game object and call its methods.
             * Create a Testing object to verify the output and operation of the other classes.
             */

            bool testingMode = true;
            Game activeGame = new Game();
            Testing activeTester = new Testing();

            if (testingMode)
            {
                activeTester.RunTest();
            }
            
            // Blank line for output aesthetic.
            Console.WriteLine();
            
            // Enable the starter game.
            activeGame.StartRoll();
            
            // Check for next step.
            Console.WriteLine("Would you like to roll more times? (Y/N): ");
            string answer = Console.ReadLine().ToLower();

            if (answer == "y")
            {
                activeGame.ExtraRolls();
            }

        }
    }
}
