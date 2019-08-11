using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extras
{
    public class ExtraGenerics<T> where T : IComparable
    {
        /// <summary>
        /// Finds the element at the given index if the collection was sorted
        /// </summary>
        /// <param name="index">Index of the elemnt to be found</param>
        /// <param name="generic">The collection to be searched</param>
        /// <returns></returns>
        public int ElementAtIndexIfSorted(int index, IList<T> list)
        {
            if (!(0 < index && index < list.Count - 1))
                throw new IndexOutOfRangeException("Index must be in bounds of list");
            return ElementAtIndexIfSorted(index, list, 0, list.Count - 1);
        }

        private int ElementAtIndexIfSorted(int index, IList<T> list, int start, int end)
        {
            int pivot = start;
            for (int i = start; i < end; i++)
            {
                if (list[i].CompareTo(list[end]) < 0)
                {
                    swap(list, i, pivot);
                    pivot++;
                }
            }

            swap(list, pivot, end);

            if (index < pivot)
                return ElementAtIndexIfSorted(index, list, 0, pivot - 1);
            else if (pivot < index)
                return ElementAtIndexIfSorted(index, list, pivot + 1, end);
            else
                return pivot;
        }

        private static void swap(IList<T> arr, int index1, int index2)
        {
            T temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }
    }
}