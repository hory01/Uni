using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    class RecursiveSort
    {

        //TODO: Comments...more comments....

        #region MergeSort
        public void MergeSort(int[] methodArray, int left, int right)
        {
            if (left < right)
            {
                int center = (left + right) / 2;
                MergeSort(methodArray, left, center);
                MergeSort(methodArray, center + 1, right);
                Merge(methodArray, left, center, right);
            }
        }

        public void Merge(int[] array, int left, int center, int right)
        {
            int arrayOneSize = center - left + 1;
            int arrayTwoSize = right - center;
            int[] arrayOne = new int[arrayOneSize + 1];
            int[] arrayTwo = new int[arrayTwoSize + 1];

            for (int t = 0; t < arrayOneSize; t++)
            {
                arrayOne[t] = array[left + t];
            }
            for (int u = 0; u < arrayTwoSize; u++)
            {
                arrayTwo[u] = array[center + u + 1];
            }
            arrayOne[arrayOneSize] = int.MaxValue;
            arrayTwo[arrayTwoSize] = int.MaxValue;
            int iLeft = 0;
            int jRight = 0;

            for (int k = left; k <= right; k++)
            {
                if (arrayOne[iLeft] <= arrayTwo[jRight])
                {
                    array[k] = arrayOne[iLeft];
                    iLeft++;
                }
                else
                {
                    array[k] = arrayTwo[jRight];
                    jRight++;
                }
            }
        }
        #endregion

        #region QuickSort
        public static void QuickSort(int[] unsortedArray, int left, int right)
        {
            int idx = Sort(unsortedArray, left, right);
            if (idx > left + 1)
                QuickSort(unsortedArray, left, idx - 1);
            if (idx < right - 1)
                QuickSort(unsortedArray, idx + 1, right);
        }

        public static int Sort(int[] unsortedArray, int left, int right)
        {
            int temp = unsortedArray[left];

            while (left < right)
            {
                while ((left < right) && (unsortedArray[right] > temp))
                    right--;

                if (left < right)
                {
                    unsortedArray[left] = unsortedArray[right];
                    left++;
                    while ((left < right) && unsortedArray[left] <= temp)
                        left++;
                    if (left < right)
                    {
                        unsortedArray[right] = unsortedArray[left];
                        right--;
                    }
                }

            }
            int idx = left;
            unsortedArray[idx] = temp;
            return idx;
        }
        #endregion

        #region HeapSort
        public static void HeapSort(int[] array, int arraySize)
        {
            CreateHeap(array, arraySize);

            for (int i = arraySize - 1; i > 0; i--)
            {
                int temp = array[0];
                array[0] = array[i];
                array[i] = temp;

                Heap(array, arraySize, i, 0);
            }
        }

        static void CreateHeap(int[] array, int arraySize)
        {
            for (int i = arraySize / 2; i > 0; i--)
                Heap(array, arraySize, arraySize, i - 1);
        }

        static void Heap(int[] array, int arraySize, int heap, int index)
        {
            int left = 2 * index;
            int right = 2 * index + 1;
            int max;

            if ((left < heap) && (array[left] > array[index]))
                max = left;
            else
                max = index;

            if ((right < heap) && (array[right] > array[max]))
                max = right;

            if (max != index)
            {
                int temp = array[index];
                array[index] = array[max];
                array[max] = temp;

                Heap(array, arraySize, heap, max);
            }
        }

    }
    #endregion
}
