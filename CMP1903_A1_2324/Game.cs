using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */
        
        /// <summary>
        /// Rolls 3 Dice and calculates their value.
        /// </summary>
        /// <returns>A Table containing the 3 Dice and the resulting addition value.</returns>
        
        public (Die, Die, Die, int) StartRoll()
        {
            // Setup a variable for storing the result.
            int result = 0;
            
            // Create 3 dice and roll each dice.
            Die dieOne = new Die();
            Die dieTwo = new Die();
            Die dieThree = new Die();

            int rollOne = dieOne.Roll();
            int rollTwo = dieTwo.Roll();
            int rollThree = dieThree.Roll();
            
            // Sum the values of the dice and output them in a user friendly way.
            result = rollOne + rollTwo + rollThree;
            Console.WriteLine($"\nDice 1: {rollOne}");
            Console.WriteLine($"Dice 2: {rollTwo}");
            Console.WriteLine($"Dice 3: {rollThree}");
            Console.WriteLine($"Sum: {result}");
            
            // Return the 3 dice objects and the result of the addition.
            return (dieOne, dieTwo, dieThree, result);
        }
        
        /// <summary>
        /// Rolls the dice a user-defined definite amount of times to produce different results then sums the results.
        /// </summary>
        /// <returns>The total sum of the values.</returns>
        /// <exception cref="FormatException">Thrown if an invalid input is given.</exception>
        public int ExtraRolls()
        {
            int result = 0;  // Stores the result of the addition.
            Die dieToRoll = new Die();  // Creates a new dice object to roll.
            int numberOfRolls = 0;  // Stores how many rolls to perform.
            
            // Setup an infinite loop to allow the user to keep retrying inputs.
            while (true)
            { 
                Console.WriteLine("\nNumber of Rolls to execute: ");
                
                try
                {
                    // Find out how many rolls the user wishes to perform.
                    numberOfRolls = Int32.Parse(Console.ReadLine());
                    
                    // Ensure the value is a positive integer, if not raise an exception.
                    if (numberOfRolls < 1)
                    {
                        throw new FormatException("Number of rolls out of bounds.");
                    }
                    
                    // If no exceptions have been raised, the loop can be broken and the code can continue.
                    break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("This is an invalid input value. Please try again.");
                } 
            }
            
            Console.WriteLine("\nPress enter to continue to next Die value!"); 
            
            // Run the dice the definite amount of times and wait for a read key before doing the next value.
            for (int i = 0; i < numberOfRolls; i++)
            {
                int rollResult = dieToRoll.Roll();
                Console.WriteLine($"Roll Result: {rollResult}");
                result += rollResult;
                Console.ReadKey();
            }
            
            // Give the user the final result and return it back to the calling code.
            Console.WriteLine($"Final Result: {result}");
            Console.ReadKey();
            
            return result;
        }
    }
}

