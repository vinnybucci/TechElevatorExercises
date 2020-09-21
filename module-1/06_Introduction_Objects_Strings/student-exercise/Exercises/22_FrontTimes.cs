using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Given a string and a non-negative int n, we'll say that the front of the string is the first 3 chars, or
         whatever is there if the string is less than length 3. Return n copies of the front;
         FrontTimes("Chocolate", 2) → "ChoCho"
         FrontTimes("Chocolate", 3) → "ChoChoCho"
         FrontTimes("Abc", 3) → "AbcAbcAbc"
         */
        public string FrontTimes(string str, int n)
        {
            string frontChar = "";
            string result = "";

            if (str.Length == 0)
            {
                frontChar = "";
            }
            else if (str.Length == 1)
            {
                frontChar = str.Substring(0, 1);
            }
            else if (str.Length == 2)
            {
                frontChar = str.Substring(0, 2);
            }
            else
            {
                frontChar = str.Substring(0, 3);
            }


            for (int i = 0; i < n; ++i)
            {
                result += frontChar;
            }

            return result;
        }

    }
}
