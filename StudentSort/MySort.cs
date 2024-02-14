using System;
using System.Collections.Generic;
namespace Delegates
{
    internal class MySort<T>
    {
        public static void BubbleSort(ref List<T> arr, Comparison<T> comparisonDelegate)
        {
            int n = arr.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (comparisonDelegate(arr[j], arr[j + 1])>0)
                    {
                        T temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }
}
