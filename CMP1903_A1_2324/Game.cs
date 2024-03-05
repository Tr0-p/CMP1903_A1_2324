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

        //Methods

        public int Result { get; set; } = 0;
        
        private static Die _dieOne = new Die();
        private static Die _dieTwo = new Die();
        private static Die _dieThree = new Die();

        public int rollOne = _dieOne.Roll();
        public int rollTwo = _dieTwo.Roll();
        public int rollThree = _dieThree.Roll();
        
        public Game()
        {
            Result = rollOne + rollTwo + rollThree;
        }
    }
}

