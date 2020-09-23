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
         Given a list of Integers representing seat numbers, group them into ranges 1-10, 11-20, and 21-30.
         (Any seat number less than 1, or greater than 30 is invalid, and can be ignored.) Preserve the order
         in which the seat number entered their associated group. Return a list of the grouped Integers 1-10,
         11-20, and 21-30. (Hint: Think multiple queues)
         DIFFICULTY: HARD
		 BoardingGate( [1, 13, 43, 22, 8, 11, 30, 2, 4, 14, 21] ) -> [1, 8, 2, 4, 13, 11, 14, 22, 30, 21]
         BoardingGate( [29, 19, 9, 21, 11, 1, 0, 25, 15, 5, 31] ) -> [9, 1, 5, 19, 11, 15, 29, 21, 25]
         BoardingGate( [0, -1, 44, 31, 17, 7, 27, 16, 26, 6] ) -> [7, 6, 17, 16, 27, 26]
         */
        public List<int> BoardingGate(List<int> seatNumberList)
        {
            Queue<int> group1to10 = new Queue<int>();
            Queue<int> group11to20 = new Queue<int>();
            Queue<int> group21to30 = new Queue<int>();
            foreach (int seat in seatNumberList)
            {
                if (seat >=1 && seat <=10)
                {
                    group1to10.Enqueue(seat);
                }
                if (seat >= 11 && seat <= 20)
                {
                    group11to20.Enqueue(seat);
                }
                if (seat >= 21 && seat <= 30)
                {
                    group21to30.Enqueue(seat);
                }
            }
            List<int> seatNumberGroup = new List<int>();
            foreach (int seat in group1to10)
            {
                seatNumberGroup.Add(seat);
            }
            foreach (int seat in group11to20)
            {
                seatNumberGroup.Add(seat);
            }
            foreach (int seat in group21to30)
            {
                seatNumberGroup.Add(seat);
            }

            return seatNumberGroup;
        }
    }
}
