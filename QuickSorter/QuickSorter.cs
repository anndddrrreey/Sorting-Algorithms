using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class QuickSorter : ISorter
    {
        public void Sort(int[] array)
        {
            if (array == null || array.Length == 0)
                return;

            Sort(array, 0, array.Length - 1);
        }

        private void Sort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex < maxIndex)
            {
                int pi = Partition(array, minIndex, maxIndex);
                Sort(array, minIndex, pi - 1);
                Sort(array, pi + 1, maxIndex);
            }
        }

        private int Partition(int[] array, int minIndex, int maxIndex)
        {
            int pivot = array[maxIndex];
            int i = minIndex - 1;
            for (int j = minIndex; j < maxIndex; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    (array[j], array[i]) = (array[i], array[j]);
                }
            }
            (array[i + 1], array[maxIndex]) = (array[maxIndex], array[i + 1]);
            return i + 1;
        }
    }
}
