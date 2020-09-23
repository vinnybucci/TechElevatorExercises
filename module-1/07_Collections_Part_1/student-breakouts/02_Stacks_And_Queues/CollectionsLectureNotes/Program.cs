using System;
using System.Collections.Generic;

namespace CollectionsLectureNotes
{
    class Program
    {
        static void Main(string[] args)
        {

            // QUEUE <T>
            //
            // Queues are a special type of data structure that follow First-In First-Out (FIFO).
            // With Queues, we Enqueue (add) and Dequeue (remove) items.

            // Create a queue of strings
            Queue<string> tasks = new Queue<string>();
            // Add four tasks to the queue that you do every day
            tasks.Enqueue("eat");
            tasks.Enqueue("sleep");
            tasks.Enqueue("homework");
            tasks.Enqueue("read");
            /////////////////////
            // PROCESSING ITEMS IN A QUEUE
            /////////////////////

            // Print each task to the console in the order they were entered (FIFO)
            while (tasks.Count>0)
            {
                string currentTask = tasks.Dequeue();
                Console.WriteLine(currentTask);
            }
            // STACK <T>
            //
            // Stacks are another type of data structure that follow Last-In First-Out (LIFO).
            // With Stacks, we Push (add) and Pop (remove) items. 

            // Create a stack of strings
            Stack<string> breakfast = new Stack<string>();
            // Add to the stack four things you might eat for breakfast
            breakfast.Push("Eggs");
            breakfast.Push("bacon");
            breakfast.Push("pancakes");
            breakfast.Push("ham");

            ////////////////////
            // POPPING THE STACK
            ////////////////////

            // Print each breakfast item to the console in reverse order (LIFO)
            while (breakfast.Count>0)
            {
                Console.WriteLine(breakfast.Pop());
            }
            Console.ReadLine();

        }
    }
}
