using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass4
{
    interface IIntegerLinkedList
    {
        void AddToFront(int Data);
        void AddToBack(int Data);
        int RemoveFromFront();
        int RemoveFromBack();
        void Display();
        bool IsEmpty { get; }
        int Size { get; }
    }
}
