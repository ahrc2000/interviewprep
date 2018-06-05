using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interview
{
    class Program
    {
        static void Main(string[] args)
        {
            //LinkedList_imp k = new LinkedList_imp();
            //k.InsertAtHead(1);
            //k.InsertAtHead("2");
            //k.insertAtEnd(3);
            //k.insertAtEnd(4);

            //k.print();

            Queues i = new Queues();
            i.queueAdd(1);
            i.queueAdd(2);
            i.queueAdd(3);
            Console.WriteLine(i.remove().Data);
            Console.WriteLine(i.Size);


            //Binarysearch o = new Binarysearch();
            //int[] arr = { 1, 2,5,8,8,8,8,8,8,10,12,15,16,20,31,33,37,40,45,47,48,49 };
            //int t = o.search(arr, 8);
            //int k = o.searchfirst(arr, 8);
            //int l = o.searchlast(arr, 8);

            //int[] sort = { 4, 6, 8, 1, 3, 8, 21, 7, 12,9,10,21,18,13,11,1,2,5 };
            //sort = quicksort.Quicksort(sort);




        }
    }
}
