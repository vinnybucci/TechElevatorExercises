using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace WordSearch
{
    class Program
    {
        static void Main(string[] args)
        {

            //1. Ask the user for the search string

            //2. Ask the user for the file path
            Console.WriteLine("What is fully qualified name of the file that should be searched?");
            string filePath = Console.ReadLine();
            Console.WriteLine("What is the search word you are looking for?");
            string userInput = Console.ReadLine();
            Console.WriteLine("Should the search be case sensitive? (Y\\N)");
            string caseSensitive = Console.ReadLine();
            // C:\Users\Student\workspace\vincentbucci-c\module-1\16_ExceptionHandling_File_Reading\student-exercise\\alices_adventures_in_wonderland.txt
            //3. Open the file

            //is file
            bool fileExists = File.Exists(filePath);
            if (fileExists)
                try
                {
                    int count = 1;

                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        while (!sr.EndOfStream)
                        {
                            
                            string line = sr.ReadLine();
                            if (line.ToUpper().Contains(userInput.ToUpper()) && caseSensitive == "N")
                            {
                                Console.WriteLine($"{count}) {line}");

                            }
                            if (line.Contains(userInput) && caseSensitive =="Y")
                            {
                                Console.WriteLine($"{count}) {line}");
                                
                            }
                            count++;
                        }

                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Error reading the file");
                    Console.WriteLine(e.Message);
                }
            //4. Loop through each line in the file
            //5. If the line contains the search string, print it out along with its line number
        }
    }
}
