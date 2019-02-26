using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6
{
    class Stack
    {
        public static void Main(string[] args)
        {
            Stack<string> Name = new Stack<string>();

            Name.Push("Rasel");
            Name.Push("abid");
            Name.Push("Hasan Ali");
            Name.Push("Jahid Hasan");
            Name.Push("Tarek");
            Name.Push("Foysal"); 
                 // stack is  LIFO (Last In First Out)
            foreach (string item in Name)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nfirst item is popping: {0}",Name.Pop());
            Console.WriteLine("\nPeek at next item to destack: {0}",
             Name.Peek());
            Console.WriteLine("\nPopping '{0}'", Name.Pop());
            // Console.WriteLine("{0}",
            // Name.Count);


            Stack<string> stack2 = new Stack<string>(Name.ToArray());

            Console.WriteLine("\nContents of the first copy:");
            foreach (string item in stack2)
            {
                Console.WriteLine(item);
            }

            // string[] array2 = new string[Name.Count * 2];
            // Name.CopyTo(array2, Name.Count);

            string[] array2 = new string[Name.Count * 2];

            Name.CopyTo(array2, Name.Count);


            foreach (string item in array2)
            {
                Console.WriteLine(item);
            }


            Stack<string> stack3 = new Stack<string>(array2);
            Console.WriteLine("\nContents of the second copy, with duplicates and nulls:");


            foreach (string number in stack3)
            {
                Console.WriteLine(number);
            }


            Console.WriteLine("\nstack3.Contains(\"abid\") = {0}",
            stack3.Contains("abid"));

          

            Console.WriteLine("\nstack2.Clear()");
            stack2.Clear();
            Console.WriteLine("\nstack2.Count = {0}", stack2.Count);

            Console.WriteLine("\nstack3.Clear()");
            stack3.Clear();
            Console.WriteLine("\nstack3.Count = {0}", stack3.Count);

            Console.ReadLine();



        }

    }
}
