using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6
{
    class LikedListNode1
    {
        public static void Main(String[] args)
        {

            LinkedListNode<string> mynode = new LinkedListNode<string>("orange");
            Console.WriteLine("After creating the node ....");
            DisplayProperties(mynode);

            LinkedList<String> myList = new LinkedList<String>();

            // Add the "orange" node and display its properties.
            myList.AddLast(mynode);
            Console.WriteLine("After adding the node to the empty LinkedList ....");
            DisplayProperties(mynode);

           
            myList.AddFirst("red");
            myList.AddLast("yellow");
            Console.WriteLine("After adding red and yellow ....");
            DisplayProperties(mynode);

            myList.RemoveFirst();
            Console.WriteLine("After removing first ...");
            DisplayProperties(mynode);




            Console.ReadLine();






        }

        public static void DisplayProperties(LinkedListNode<String> lln)
        {
            if (lln.List == null)
                Console.WriteLine("   Node is not linked.");
            else
                Console.WriteLine("   Node belongs to a linked list with {0} elements.", lln.List.Count);

            if (lln.Previous == null)
                Console.WriteLine("   Previous node is null.");
            else
                Console.WriteLine("   Value of previous node: {0}", lln.Previous.Value);

            Console.WriteLine("   Value of current node:  {0}", lln.Value);

            if (lln.Next == null)
                Console.WriteLine("   Next node is null.");
            else
                Console.WriteLine("   Value of next node:     {0}", lln.Next.Value);

            Console.WriteLine();
        }
        }
}
