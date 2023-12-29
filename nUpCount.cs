using System;

class Program{

    static int nUpCount(int[] a, int n)
    {
        int upCount = 0;
        int partialSum = 0;

        for (int i = 0; i < a.Length; i++)
        {
            int previousPartailSum = partialSum;
            partialSum += a[i];
            
            if (partialSum > n && previousPartailSum <= n)
            {
                upCount++;
            }
        }
        return upCount;
    } 
}