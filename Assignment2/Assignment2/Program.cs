using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        }

        //Define Brute Force Algorithm 
        static int BruteForceMedian(int[] A)
        {
            int ParameterLength = A.Length;
            int k = ParameterLength / 2;
            int n = A[A.Length - 1];
            for (int i = 0; i < n-1; i++)
            {
                int numSmaller = 0;
                int numEqual = 0;
                for (int j = 0; i < n-1; i++)
                {
                    //A[j] is less then A[i]
                    if (A[j] < A[i])
                    {
                        numSmaller = numSmaller + 1;
                    }
                    else
                    {
                        if (A[j] == A[i])
                        {
                            numEqual = numEqual + 1;
                        }
                    }
                }
                if (numSmaller < k && k <= (numSmaller + numEqual))
                {
                    return A[i];
                }
            }
            //return [];
        }
        //Get the median value of a list 
        static int Median(int[] A)
        {
            int n = A[A.Length - 1];
            if (n == 1)
            {
                return A[0];
            }
            else
            {
                return Select(A, 0, n / 2, n - 1);
            }
        }
    }
}
