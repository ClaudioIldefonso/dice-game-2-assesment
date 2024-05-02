﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        // variables
        private int _dieValue;
        private Random random;

        /*using encapslaltion to allow _dieValue 
         * to store the die value */
        public int DieValue
        {
            get { return _dieValue; }
            set { _dieValue = value; }

        }
        /* this is the method to roll a single Die and 
         * return it as an int*/
        public int Roll()
        {
            int RandomGenerator = random.Next(1, 7);
            _dieValue = RandomGenerator;
            
            return _dieValue;

        }
        public Die(Random rand)
        {
            random = rand;
        }
    }
}