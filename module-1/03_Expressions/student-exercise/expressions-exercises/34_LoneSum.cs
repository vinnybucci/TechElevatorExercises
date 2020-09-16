﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given 3 int values, a b c, return their sum. However, if one of the values is the same as another
         of the values, it does not count towards the sum.
         LoneSum(1, 2, 3) → 6
         LoneSum(3, 2, 3) → 2
         LoneSum(3, 3, 3) → 0
         */
        public int LoneSum(int a, int b, int c)
        {
            if ((a == b) && (a != c))
            {
                return c;
            }
            if ((a == c) && (a != b))
            {
                return b;
            }
            if ((b == c) && (b != a))
            {
                return a;
            }
            if (a == b && a == c)
            {
                return 0;
            }
            return a + b + c;
        }

    }
}
