﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture
{
    public partial class LectureExample
    {

        /*
         13. Write an if/else statement that returns 
            "Fizz" if the parameter is 3, 
            "Buzz" if the parameter is 5 
            and an empty string "" for anything else.
            TOPIC: Conditional Logic
         */
        public string ReturnFizzOrBuzzOrNothing(int number)
        {
            string result = "";
            if(number == 3)
            {
                result = "Fizz";
            }
            else if(number == 5)
            {
                result = "Buzz";
            }
            return result;
        }
    }
}
