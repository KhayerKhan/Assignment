using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Assignment6
{
    class SortedSet
    {

        public static void Main(string[] args)
        {
            SortedSet<int> mySorted = new SortedSet<int>();
            
            for(int i=2; i<10; i++) 
            {
                mySorted.Add(i);
            }

            mySorted.Add(1);
            mySorted.Add(0);

            Console.WriteLine("My sorted element :");
            foreach (int item in mySorted)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("The number of elements in mySortedSet are: "
                                               + mySorted.Count);
            Console.WriteLine("\nMinimum Element of sorted List:" + mySorted.Min);

            SortedSet<int> mysorted1 = new SortedSet<int>();
            for(int i=0; i<5;i++)
            {
                mysorted1.Add(i);
            }

            Console.WriteLine("\nMy sorted set1 : ");
            foreach (int item in mysorted1)
            {
                Console.WriteLine(item);
            }

           
            Console.WriteLine("Two sorted set are: {0}",mySorted.Equals(mysorted1));
            Console.WriteLine("My sorted set and sorted set1 is subset : {0}",mySorted.IsSubsetOf(mysorted1));
            Console.WriteLine("my two sorted set is superset : {0}",mySorted.IsSupersetOf(mysorted1));
            Console.WriteLine("My 2nd sorted set is subset of 1st sorted set : {0}",mysorted1.IsSubsetOf(mySorted));

            Console.ReadLine();
        }

       
    }
}
