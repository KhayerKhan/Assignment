using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6
{
    class HashSet
    {
       public static void Main(string [] args)
        {
            HashSet<int> evenNumbers = new HashSet<int>();
            HashSet<int> oddnumbers = new HashSet<int>();

            for(int i=0; i<6; i++)
            {

                evenNumbers.Add(i * 2);
                oddnumbers.Add((i * 2) + 1);
            }

            Console.Write("evenNumbers contains {0} elements: ", evenNumbers.Count);
            DisplaySet(evenNumbers);

            Console.Write("oddNumbers contains {0} elements: ", oddnumbers.Count);
            DisplaySet(oddnumbers);

            HashSet<int> numbers = new HashSet<int>(evenNumbers);
            Console.WriteLine("numbers UnionWith oddNumbers...");
            numbers.UnionWith(oddnumbers);

            Console.Write("numbers contains {0} elements: ", numbers.Count);
            DisplaySet(numbers);


            if (evenNumbers.Contains(6))
                Console.WriteLine("Required Element is present");
            else
                Console.WriteLine("Required Element is not present");




            // Check if a HashSet mySet1 is a subset 
            // of the HashSet mySet2 
            Console.Write("Even numbers is dubset of numbers: ");
            Console.WriteLine(evenNumbers.IsSubsetOf(numbers));



            Console.ReadLine();
        }

        private static void DisplaySet(HashSet<int> set)
        {
            Console.Write("{");
            foreach (int i in set)
            {
                Console.Write(" {0}", i);
            }
            Console.WriteLine(" }");
        }
    }
}
