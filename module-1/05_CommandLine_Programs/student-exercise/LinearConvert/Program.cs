using System;

namespace LinearConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter length");
            decimal length = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Is the measurement in (m)eter, or (f)eet");
           string measurment = Console.ReadLine();

            if (measurment == "M" || measurment == "m")
            {
                decimal feet = (length * 3.2808399m);
                Console.WriteLine($"{length} in meters is {feet} in feet.");
            }
            else if (measurment == "F" || measurment == "f")
            {
                decimal meters = (length * 0.3048m);
                Console.WriteLine($"{length} in feet is {meters} in meters.");
            }

        }
    }
}
