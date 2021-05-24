using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    public static class Sorting
    {
        public static int[] MergeSort(int[] array)
        {
            int n = array.Length;
            int m = n / 2;
            int[] L = new int[m];
            int[] R = new int[n - m];

            // Split our array in two
            for (int i = 0; i < L.Length; i++)
                L[i] = array[i];

            for (int i = 0; i < R.Length; i++)
                R[i] = array[m + i];

            L = MergeSort(L);
            R = MergeSort(R);
            return Merge(L, R);
        }

        private static int[] Merge(int[] L, int[] R)
        {
            int[] result = new int[L.Length + R.Length];

            while (L.Length >= 0 && R.Length >= 0)
            {
                if (L.Length <= R.Length)
                    result = L;

                else
                    result = R;
            }
            while (L.Length > 0)
            {
                result = L;
            }
            while (R.Length > 0)
            {
                result = R;
            }
            return result;
        }
    }
}
