using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        public static void QuickSort(int[] array)
        {
            QuickSort(array, 0, array.Length - 1);
        }

        public static void QuickSort(int[] array, int left, int right)
        {
            if (left >= right)
            {
                return;
            }

            int pivot = array[(left + right) / 2];
            int index = Partition(array, left, right, pivot);
            QuickSort(array, left, index - 1);
            QuickSort(array, index, right);
        }

        private static int Partition(int[] array, int left, int right, int pivot)
        {

            while (left <= right)
            {
                while (array[left] < pivot)
                {
                    left++;
                }

                while (array[right] > pivot)
                {
                    right--;
                }

                if (left <= right)
                {
                    int temp = array[right];
                    array[right] = array[left];
                    array[left] = temp;
                    left++;
                    right--;
                }
            }
            return left;
        }
 

        static void Main(string[] args)
        {
            int[] array = { 5,5,5,5,12,17,1,2};

            QuickSort(array);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
