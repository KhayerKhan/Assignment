using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6
{
    class List
    {
        static void Main(string[] args)
        {
            List<string> StudentName = new List<string>();

            StudentName.Add("Abid"); 
            StudentName.Add("Rasel");
            StudentName.Add("Khayer");
            StudentName.Add("Jahid");


            foreach (string name in StudentName)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Total count:{0}", StudentName.Count);
            Console.WriteLine("\nContains(\"Abid\"): {0}",
            StudentName.Contains("Abid"));

            Console.WriteLine("\nInsert(1, \"Rasel\")");
            StudentName.Insert(1, "Hasan");

            Console.WriteLine("insert 1 :{0} ", StudentName[1]);
            Console.WriteLine("\nRemove(\"Hasan\")\n");
            StudentName.Remove("Hasan\n");

            foreach (string name in StudentName)
            {
                Console.WriteLine(name);
            }
            StudentName.Clear();

            Console.WriteLine("\nClear all Data: {0}", StudentName.Count);
            Console.ReadLine();
        }

    }
}
