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
         Given a string, return a version without both the first and last char of the string. The string
         may be any length, including 0.
         WithoutEnd2("Hello") → "ell"
         WithoutEnd2("abc") → "b"
         WithoutEnd2("ab") → ""
         */
        public string WithoutEnd2(string str)
        {
            string result = str; 
            if (str.Length==0)
            {
                result = "";
            }
            else if (str.Length==1)
            {
                result = result.Remove(0, 1);

            }
            else
            {
                result = result.Remove(result.Length - 1).Remove(0, 1);
            }
            return result;
        }
    }
}
