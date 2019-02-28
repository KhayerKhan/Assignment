using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6
{
    class Dictionary
    {
        

        public static void Main(string[] args)
        {
            Dictionary<string, string> myDict = new Dictionary<string, string>();
            myDict.Add("1", "C");
            myDict.Add("2", "C++");
            myDict.Add("3", "Python");
            myDict.Add("4", "C#");
            myDict.Add("5", "Java");
            Console.WriteLine("Total key/value pairs" +
                         " in myDict are : " + myDict.Count);
            foreach (KeyValuePair<string,string> item in myDict)
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                               item.Key, item.Value);
            }

            Dictionary<string, string>.KeyCollection keyColl =
                                              myDict.Keys;
            foreach (string item in keyColl)
            {
                Console.WriteLine("Key = {0} ", item);
            }

            Dictionary<string, string>.ValueCollection valueColl = myDict.Values;

            foreach (string item in valueColl)
            {
                Console.WriteLine("Value = {0}", item);
            }

            Console.WriteLine("\nTotal count: {0}",myDict.Count);
            myDict.Remove("1");

            Console.WriteLine("\nafter remove  then total count : {0}",myDict.Count);

            if(myDict.ContainsKey("2"))
                Console.WriteLine("2 keys is a present");
            else
                Console.WriteLine("2 keys is not present");

            if(myDict.ContainsValue("C#"))
                Console.WriteLine("C# value is present");
            else
                Console.WriteLine("C# value is not present");
            try
            {
                myDict.Add("2", "C#");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("An element with Key = \"2\" already exists.");
            }


            myDict["3"] = "Assembly";
            Console.WriteLine("For key = \"3\", value = {0}.",
                myDict["3"]);

            try
            {
                Console.WriteLine("For key = \"javasrcript\", value = {0}.",
                    myDict["javascript"]);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Key = \"javascript\" is not found.");
            }

            Console.ReadLine();
        }
    }
}
