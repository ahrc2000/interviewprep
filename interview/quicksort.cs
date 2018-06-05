using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interview
{
    public class quicksort
    {

        public static int[] Quicksort(int[] arr)
        {

            Quicksort(arr, 0, arr.Length - 1);

            return arr; 

        }

        public static void Quicksort(int [] Arr, int Left, int Right)
        {
            if (Left >= Right)
                return;

            int pivot = (Right + Left) / 2;

            int index = partition(Arr, Left, Right, pivot);

            Quicksort(Arr, Left, index-1);
            Quicksort(Arr, index, Right);
            
        }

        private static int partition(int []arr, int left, int right, int pivot)
        {
            while(left <= right)
            {
                while(arr[left] < arr[pivot])
                {
                    left++;
                }

                while(arr[right] > arr[pivot])
                {
                    right--;
                }

                if (left <= right)
                {
                    swap(arr, left, right);
                    left++;
                    right--;
                }
                
            }
            return left;
        }

        private static void swap(int[] arr, int left, int right)
        {
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;
        }
    }
}
