using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoIntersect
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] L = { 1, 2, 3, 4, 5 };
            int[] R = { 3, 4, 5, 6, 7 };
            int[] A = new int[L.Length + R.Length];

            Array.Resize(ref L, L.Length + 1);
            Array.Resize(ref R, R.Length + 1);

            L[L.Length - 1] = Int32.MaxValue;
            R[R.Length - 1] = Int32.MaxValue;

            int i = 0;
            int j = 0;

            for (int k = 0; k < 10; k++)
            {
                if (L[i] < R[j])
                {
                    if (j != 0)
                    {
                        if (L[i] == R[j - 1])
                        {
                            i++; continue;
                        }
                    }
                    A[k] = L[i];
                    i++;
                }
                else if (L[i] > R[j])
                {
                    if (i != 0)
                    {
                        if (R[j] == L[i - 1])
                        {
                            j++; continue;
                        }
                    }
                    A[k] = R[j];
                    j++;
                }
                else
                {
                    if ((i + 1) < L.Length && (j + 1) < R.Length)
                    {
                        i++;
                        j++;
                    }
                }
            }

            foreach (var item in A.ToList())
            {
                if(item != 0)
                Console.Write(" " + item + " ");
            }
            Console.ReadKey();
        }
    }
}
