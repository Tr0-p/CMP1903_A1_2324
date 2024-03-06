using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    /// <summary>
    /// Create a dice with 1 Roll method and 1 Attribute to store the current value of the dice.
    /// </summary>
    internal class Die
    {
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */

        //Property
        /// <summary>
        /// Stores the current value of the dice.
        /// </summary>
        public int CurrentValue { get; private set; }
        private static Random _roller = new Random();
        
        //Method
        /// <summary>
        /// Rolls the dice, stores it in the CurrentValue and returns said value.
        /// </summary>
        /// <returns>A number from 1 to 6.</returns>
        public int Roll()
        {
            CurrentValue = _roller.Next(1, 7);
            return CurrentValue;
        }


    }
}
