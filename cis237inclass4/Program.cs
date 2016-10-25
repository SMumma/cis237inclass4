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
            IIntegerLinkedList myLinkedList = new IntegerLinkedList();

            myLinkedList.AddToFront(5);
            myLinkedList.AddToFront(4);
            myLinkedList.AddToFront(3);

            myLinkedList.AddToBack(6);
            myLinkedList.AddToBack(7);
            myLinkedList.AddToBack(8);

            myLinkedList.Display();
        }
    }
}
