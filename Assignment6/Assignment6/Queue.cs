using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6
{
    class Queue
    {
        public static void Main(string[] agrs)
        {

            Queue<string> numberQueue = new Queue<string>(); // Queue is First In First Out

            numberQueue.Enqueue("One");
            numberQueue.Enqueue("Two");
            numberQueue.Enqueue("Three");
            numberQueue.Enqueue("Four");   

          

            foreach (string item in numberQueue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nDequeuing '{0}'", numberQueue.Dequeue());
            Console.WriteLine("\nPeek at next item to dequeue: {0}",
                numberQueue.Peek());
            Console.WriteLine("\nDequeuing '{0}'\n", numberQueue.Dequeue());


            Queue<string> Queuecopy = new Queue<string>(numberQueue.ToArray());

            Console.WriteLine("\nContents of the first copy:");
            foreach (string item in Queuecopy)
            {
                Console.WriteLine(item);
            }

            string[] arry2 = new string[numberQueue.Count * 2];
            numberQueue.CopyTo(arry2,numberQueue.Count);
            
            foreach (string item in arry2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(arry2.GetType());


            Console.WriteLine("\nContents of the second copy, with duplicates and nulls:");
            Queue<string> queueCopy2 = new Queue<string>(arry2);
            foreach (string  item in queueCopy2)
            {
                Console.WriteLine(item);
            }

            
            numberQueue.Clear();
            Console.WriteLine("\nnumberqueue.Count = {0}", numberQueue.Count);


            Console.ReadLine();

        }
    }
}
