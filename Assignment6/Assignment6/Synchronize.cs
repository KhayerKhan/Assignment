using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Assignment6
{
    class Synchronize
    {
        public static void Main(String[] args)
        {
            SortedList mysortedlist = new SortedList();
            mysortedlist.Add(2, "Two");
            mysortedlist.Add(1, "One");
            mysortedlist.Add(4, "Four");
            mysortedlist.Add(3, "Three");


            SortedList mySortedList_1 =
           SortedList.Synchronized(mysortedlist);


            Console.WriteLine("mySortedList SortedList is {0}.",
             mysortedlist.IsSynchronized ? "synchronized" :
                                        "not synchronized");

            Console.WriteLine("mySortedList_1 SortedList is {0}.",
                  mySortedList_1.IsSynchronized ? "synchronized" :
                                              "not synchronized");


            Console.ReadLine();


        }



    }
}
