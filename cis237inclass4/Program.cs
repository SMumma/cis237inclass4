using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass4
{
    class Program
    {
        static void Main(string[] args)
        {

            //Here is a generic linked list that stores strings.
            IGenericLinkedList<string> myGenericLinkedList = new GenericLinkedList<string>();

            //Here is a generic linked list that stores any class that implements the IComparable Interface.
            IGenericLinkedList<IComparable> myComparableLinkedList = new GenericLinkedList<IComparable>();

            //Let's use the string one
            myGenericLinkedList.AddToFront("Foo");
            myGenericLinkedList.AddToFront("Dave");
            myGenericLinkedList.AddToFront("Bear");
            myGenericLinkedList.AddToFront("Barnes");

            myGenericLinkedList.AddToBack("Back 3");
            myGenericLinkedList.AddToBack("Back 2");
            myGenericLinkedList.AddToBack("Back 1");

            myGenericLinkedList.Display();

            string frontGuy = myGenericLinkedList.RemoveFromFront();

            Console.WriteLine(frontGuy);

            myGenericLinkedList.Display();
        }
    }
}
