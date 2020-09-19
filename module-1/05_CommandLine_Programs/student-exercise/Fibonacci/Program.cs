using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {

            int next;
            int start = 0;
            int previous;

            Console.WriteLine("Please enter the Fibonacci number");
            double fibNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("0,");
            previous = start++;
            do
            {
                next = start + previous;
                if (next >= fibNumber)
                {
                    break;
                }


                Console.WriteLine(next + ", ");

                previous = start;
                start = next;
                
                   
            }
            while (next < fibNumber);


        }
    }
}
