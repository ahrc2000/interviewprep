using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interview
{
    class Binarysearch
    {


        public Binarysearch() { }

        public int search(int [] arr, int u)
        {
            int start = 0;
            int end = arr.Length - 1;

            while (start <= end)
            {
                int mid =start +( (end - start) / 2);
                Console.WriteLine("the middle index is: " + mid);


                if (arr[mid] == u)
                    return mid;
                else if (arr[mid] < u)
                {
                    start = mid + 1;
                    Console.WriteLine("the elemenet was not in the first half of the array");
                    Console.WriteLine("the new start point of the array is now: " + start);
                }
                else
                {
                    end = mid - 1;
                    Console.WriteLine("the element was not in the last half of the array");
                    Console.WriteLine("the new end point of the array is now: " + end);
                }

            }

           
            return -1;
        }


        public int searchfirst(int[] arr, int u)
        {
            int start = 0;
            int end = arr.Length - 1;
            int firstocc = int.MinValue;
            bool flag = false;
            while (start <= end)
            {
                int mid = start + ((end - start) / 2);
                Console.WriteLine("the middle index is: " + mid);


                if (arr[mid] == u )
                {
                    flag = true;
                    firstocc = mid;
                    end = mid-1;
                }
                else if (arr[mid] < u)
                {
                    start = mid + 1;
                    Console.WriteLine("the elemenet was not in the first half of the array");
                    Console.WriteLine("the new start point of the array is now: " + start);
                }
                else
                {
                    end = mid - 1;
                    Console.WriteLine("the element was not in the last half of the array");
                    Console.WriteLine("the new end point of the array is now: " + end);
                }

            }

            if (flag)
                return firstocc;
            else
                return -1;
        }

        public int searchlast(int[] arr, int u)
        {
            int start = 0;
            int end = arr.Length - 1;
            int lastoccu = int.MaxValue;
            bool flag = false;
            while (start <= end)
            {
                int mid = start + ((end - start) / 2);
                Console.WriteLine("the middle index is: " + mid);


                if ( arr[mid] == u)
                {
                    flag = true;
                    lastoccu = mid;
                    start = mid+1;
                }
                else if (arr[mid] < u)
                {
                    start = mid + 1;
                    Console.WriteLine("the elemenet was not in the first half of the array");
                    Console.WriteLine("the new start point of the array is now: " + start);
                }
                else
                {
                    end = mid - 1;
                    Console.WriteLine("the element was not in the last half of the array");
                    Console.WriteLine("the new end point of the array is now: " + end);
                }

            }

            if (flag)
                return lastoccu;
            else

                return -1;
        }

    }
    




}



