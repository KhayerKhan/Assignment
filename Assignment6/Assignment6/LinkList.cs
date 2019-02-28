using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6
{
    class LinkList
    {

        public static void Main(string[] args)
        {
            LinkedList<string> myList1 = new LinkedList<string>();
            myList1.AddLast("One");
            myList1.AddLast("Two");
            myList1.AddLast("Three");
            myList1.AddLast("Four");

            myList1.AddFirst("0");

            myList1.AddBefore(myList1.First, "1");
            myList1.AddAfter(myList1.First.Next.Next, "Add one after");

            LinkedListNode<string> marks = myList1.First;  // Move the first node to be the last node.
            myList1.RemoveFirst();
            myList1.AddFirst(marks);
           

            

            myList1.RemoveLast();
            myList1.AddLast("Yesterday");  // Change the last node to 'yesterday'.

            marks = myList1.Last;  // Move the last node to be the first node.
            myList1.RemoveLast();
            myList1.AddFirst(marks);


            // Indicate the last occurence of 'the'.
            myList1.RemoveFirst();
            LinkedListNode<string> current = myList1.FindLast("the");
            


            // Add 'lazy' and 'old' after 'the' (the LinkedListNode named current).
            try
            {
                myList1.AddAfter(current, "old");
                myList1.AddAfter(current, "lazy");
            }
            catch (System.ArgumentNullException)
            {

                Console.WriteLine("wrong");
            }



            foreach (string item in myList1)
            {
                Console.WriteLine(item);
            }

            string[] sArray = new string[myList1.Count];
            myList1.CopyTo(sArray, 0);

            foreach (string s in sArray)
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();

        }

       
        
    


}
}
