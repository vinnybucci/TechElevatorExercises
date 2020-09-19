using System;

namespace TempConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the temperature");
            string temp = Console.ReadLine();
            double tempnumber = double.Parse(temp);

            Console.WriteLine("Is the temperature in (C)elsius, or (F)ahrenheit?");
            string recordedTemp = Console.ReadLine();
            char temperatureRecorded = char.Parse(recordedTemp);

            if (temperatureRecorded == 'C' || temperatureRecorded == 'c')
            {
                double fTemp = (tempnumber * 1.8 + 32);

                Console.WriteLine(fTemp);

            }
            else if (temperatureRecorded =='F' || temperatureRecorded == 'f')

            {


                double ctemp = (tempnumber - 32) / 1.8;
                Console.WriteLine(ctemp);
            }

            else
            {
                Console.WriteLine("Print something else");
            }
        }
    }
}
