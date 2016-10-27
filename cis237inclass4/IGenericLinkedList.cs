using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass4
{
    //This linked list takes in a Type called T
    //It is declared in the <> portion
    //The name can be anything, we chose T, but it
    //can easily be FOO, or BAR, or whatever you want.
    //You can even do multiple ones that look like this:
    //IGenericLinkedList<T1,T2>
    interface IGenericLinkedList<T>
    {
        //Since the type we want has come into this interface as
        //type T, we will use T as the type for the data.
        //This means that if this linked list is declared with T being
        //a string, this list will hold strings.  If double is sent into T
        //it will hold doubles and so on.
        void AddToFront(T GenericData);
        void AddToBack(T GenericData);
        T RemoveFromFront();
        T RemoveFromBack();
        void Display();
        bool IsEmpty { get; }
        int Size { get; }
    }
}
