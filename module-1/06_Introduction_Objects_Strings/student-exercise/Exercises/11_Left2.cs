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
         Given a string, return a "rotated left 2" version where the first 2 chars are moved to the end.
         The string length will be at least 2.
         Left2("Hello") → "lloHe"
         Left2("java") → "vaja"
         Left2("Hi") → "Hi"
         */
        public string Left2(string str)
        {
            string result;
            string firstChar = str.Substring(0, 2);
            string move = str.Substring(2);
            result = move + firstChar;
            return result;
        }
    }
}
