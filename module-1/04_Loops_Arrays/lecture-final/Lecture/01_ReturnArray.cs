﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture
{
    public partial class LectureProblem
    {

        /*
        1a. This method expects an array of integers to be returned.            
            Create an array and return it.

            TOPIC: Array Creation
        */
        public int[] ReturnNewArray()
        {
            int[] result = new int[5];
            return result;
        }


        /*
        1b. This method expects an array of integers size 100 to be returned.
            Create an array of size 100 and return it.

            TOPIC: Array Creation
        */
        public int[] ReturnArrayOfKnownSize()
        {
            int[] result = new int[100];
            return result;
        }

        /*
        1c. This method expects an array of strings size n to be returned.
            As long as the array size is set to an integer, its ok to not know when we create it.

            TOPIC: Array Creation
        */
        public string[] ReturnArrayOfUnknownSize(int n)
        {
            string[] result = new string[n];
            return result;
        }

        
    }
}
