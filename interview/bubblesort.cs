using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interview
{
    public class bubblesort
    {

        public static void sort(int[] arr)
        {
            bool sorted = false;
            int size = arr.Length - 1;


            while (!sorted)
            {
                sorted = true;
                for (int i = 0; i < size; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        swap(arr, i, i + 1);
                        sorted = false;
                    }
                }
                size--;
            }


        }
        private static void swap(int[] arr, int left, int right)
        {
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;
        }

    }
}
