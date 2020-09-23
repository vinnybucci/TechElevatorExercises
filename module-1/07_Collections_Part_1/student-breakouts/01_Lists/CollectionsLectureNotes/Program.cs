using System;
using System.Collections.Generic;
using System.Transactions;

namespace CollectionsLectureNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            // LIST<T>
            //
            // Lists allow us to hold collections of data. They are declared with a type of data that they hold
            // only allowing items of that type to go inside of them.
            //
            // The syntax used for declaring a new list of type T is
            //      List<T> list = new List<T>();
            //
            //

            // Create two lists of integers
            List<int> integers1 = new List<int>();
            List<int> integers2 = new List<int>();


            // Create list of strings
            List<string> string1 = new List<string>();
            // Write these variables to the console
            Console.WriteLine(integers1);
            Console.WriteLine(integers2);
            Console.WriteLine(string1);
            // Discuss: What did you see on the console? Is that what you expected?

            /////////////////


            //////////////////
            // OBJECT EQUALITY
            //////////////////

            // Check if the first list you created is equal to the second list

            // If they are equal, write "They are the same" to the console.
            // If they are not equal, write "They are not the same" to the console.
            // Discuss: Why did you get that result?
            if (integers1 == integers2)
            {
                Console.WriteLine("They are the same");

            }
            else
            {
                Console.WriteLine("They are not the same");
            }
            // Assign the first integer list to the second integer list

            // Check if the first list you created is equal to the second list
            // If they are equal, write "They are the same" to the console.
            // If they are not equal, write "They are not the same" to the console.
            // Discuss: Why did you get that result?


            /////////////////
            // ADDING ITEMS
            /////////////////

            // Add three numbers to one of the integer lists
            integers1.Add(42);
            integers1.Add(54);
            integers1.Add(56);
            // Add four words to the list of strings
            string1.Add("dog");
            string1.Add("cat");
            string1.Add("fish");
            string1.Add("rabbit");

            //////////////////
            // ACCESSING BY INDEX
            //////////////////
            // Use a for loop to access each element by its index
            // Write each element to the console. 
            // Do this for both the integer list and the string list.
            for (int i=0; i<string1.Count;i++)
            {
                Console.WriteLine(string1[i]);
            }

            for (int i = 0; i < integers1.Count; i++)
            {
                Console.WriteLine(integers1[i]);
            }
            Console.ReadLine();

        }
    }
}
