using System;
using System.IO;

namespace FizzWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string directory = Environment.CurrentDirectory;
            string fileName = "FizzBuzz.txt";
            string fullPath = Path.Combine(directory, fileName);
            try
            {
                using (StreamWriter sw = new StreamWriter(fullPath, true))
                {
                    string result;
                    for (int i = 0; i <= 300; i++)
                    {
                        if (i % 3 == 0 && i % 5 == 0)
                        {
                            result = "FizzBuzz";
                        }
                        else if (i % 3 == 0)
                        {
                            result = "Fizz";
                        }
                        else if (i % 5 == 0)
                        {
                            result = "Buzz";
                        }
                        else
                        {
                            result = i.ToString();
                        }
                            sw.WriteLine(result);



                    }


                }
            }
            catch (Exception e)
            {

            }

        }
    }
}
