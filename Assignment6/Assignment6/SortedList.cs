using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6
{
    class SortedList
    {
        public static void Main(String[] args)
        {

            SortedList<int, string> mysortedList = new SortedList<int, string>();

            mysortedList.Add(2, "Two");
            mysortedList.Add(4, "Four");
            mysortedList.Add(3, "Three");
            mysortedList.Add(1, "One");
            mysortedList.Add(5, "Five");

            foreach (KeyValuePair<int, string> item in mysortedList)
            {
                Console.WriteLine("Key = {0} Value = {1} ", item.Key, item.Value);
            }

            IList<int> IlistKey = mysortedList.Keys;

            Console.WriteLine("\nSortedList of key");
            foreach (int item in IlistKey)
            {
                Console.WriteLine("Key = {0}",item);
            }

            IList<string> IlistValue = mysortedList.Values;

            Console.WriteLine("\nSortedList of Value");
            foreach (string item in IlistValue)
            {
                Console.WriteLine("Value = {0}",item);
            }

            Console.WriteLine("\nTotal count: {0}", mysortedList.Count);
            mysortedList.Remove(1);

            Console.WriteLine("\nafter remove  then total count : {0}", mysortedList.Count);

            if (mysortedList.ContainsKey(2))
                Console.WriteLine("2 keys is a present");
            else
                Console.WriteLine("2 keys is not present");

            if (mysortedList.ContainsValue("C#"))
                Console.WriteLine("C# value is present");
            else
                Console.WriteLine("C# value is not present");
            try
            {
                mysortedList.Add(2, "Two");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("An element with Key = \"Two\" already exists.");
            }


            mysortedList[3] = "Six";
            Console.WriteLine("For key = \"3\", value = {0}.",
                mysortedList[3]);

            try
            {
                Console.WriteLine("For key = \"Six\", value = {0}.",
                    mysortedList[6]);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Key = \"Six\" is not found.");
            }

            Console.WriteLine("\nRemove(\"8\")");
            mysortedList.Remove(8);

            if (!mysortedList.ContainsKey(8))
            {
                Console.WriteLine("Key \"8\" is not found.");
            }

            if (!mysortedList.ContainsKey(9))
            {
                mysortedList.Add(9, "Nine");
                Console.WriteLine("\nValue added for key = \"Nine\": {0}",
                    mysortedList[9]);
            }

            // Checking if a SortedList object
        // contains a specific key 
            Console.WriteLine(mysortedList.ContainsKey(4));

            Console.ReadLine();
        }
    }
}
