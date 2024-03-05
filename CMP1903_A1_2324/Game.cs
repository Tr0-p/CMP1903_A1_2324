﻿using System;
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

        public int StartRoll()
        {
            int result = 0;
            
            Die dieOne = new Die();
            Die dieTwo = new Die();
            Die dieThree = new Die();

            int rollOne = dieOne.Roll();
            int rollTwo = dieTwo.Roll();
            int rollThree = dieThree.Roll();
            
            result = rollOne + rollTwo + rollThree;
            Console.WriteLine($"\nDice 1: {rollOne}");
            Console.WriteLine($"Dice 2: {rollTwo}");
            Console.WriteLine($"Dice 3: {rollThree}");
            Console.WriteLine($"Sum: {result}");

            return result;
        }
    }
}

