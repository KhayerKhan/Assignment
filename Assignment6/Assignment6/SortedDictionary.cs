using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6
{
    class SortedDictionary
    {
        public static void Main(String[] args)
        {
            SortedDictionary<int, string> mysortedDict = new SortedDictionary<int, string>();
            mysortedDict.Add(2, "Two");
            mysortedDict.Add(4, "Four");
            mysortedDict.Add(3, "Three");
            mysortedDict.Add(1, "One");
            mysortedDict.Add(5, "Five");

            foreach (KeyValuePair<int,string> item in mysortedDict)
            {
                Console.WriteLine("Key = {0} Value = {1}",
                    item.Key,item.Value);
            }

            SortedDictionary<int, string>.KeyCollection MyKey = mysortedDict.Keys;
            Console.WriteLine("\nKey collection of SortedDictionary : ");
            foreach (int item in MyKey)
            {
                Console.WriteLine("Key = {0}",item);
            }

            SortedDictionary<int, string>.ValueCollection valueColl = mysortedDict.Values;

            Console.WriteLine("\nValue collection of Sorted Dictionary :");
            foreach (string item in valueColl)
            {
                Console.WriteLine("Value = {0}",item);
            }

            Console.WriteLine("\nTotal count: {0}", mysortedDict.Count);
            mysortedDict.Remove(1);

            Console.WriteLine("\nafter remove  then total count : {0}", mysortedDict.Count);

            Console.WriteLine("\nKey is present or not");
            if (mysortedDict.ContainsKey(2))
                Console.WriteLine("2 keys is a present");
            else
                Console.WriteLine("2 keys is not present");

            Console.WriteLine("Value is present or absent:");
            if(mysortedDict.ContainsValue("Six"))
                Console.WriteLine("Value six is present");
            else
                Console.WriteLine("value six is not present");

            try
            {
                mysortedDict.Add(2, "Two");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("An element with Key = \"Two\" already exists.");
            }


            mysortedDict[3] = "Six";
            Console.WriteLine("For key = \"3\", value = {0}.",
                mysortedDict[3]);

            try
            {
                Console.WriteLine("For key = \"Six\", value = {0}.",
                    mysortedDict[6]);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Key = \"Six\" is not found.");
            }

            Console.WriteLine("\nRemove(\"8\")");
            mysortedDict.Remove(8);

            if (!mysortedDict.ContainsKey(8))
            {
                Console.WriteLine("Key \"8\" is not found.");
            }

            if (!mysortedDict.ContainsKey(9))
            {
                mysortedDict.Add(9, "Nine");
                Console.WriteLine("\nValue added for key = \"Nine\": {0}",
                    mysortedDict[9]);
            }

            // Checking if a SortedList object
            // contains a specific key 
            Console.WriteLine("Have key 4? {0}",mysortedDict.ContainsKey(4));

            Console.WriteLine("Have ContainsValue Eight  :{0} ",mysortedDict.ContainsValue("Eight"));

            Console.ReadLine();
        }


    }
}
