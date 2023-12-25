using System;

class Program
{
    static int centerdArray(int[] arr)
    {
        if (arr == null || arr.Length % 2 == 0) 
        {
            return 0;
        }
        int midIndex = (arr.Length - 1) / 2 ;
        int midElement = arr[midIndex];

        for( int i=0; i < arr.Length; i++)
        {
            if (i != midIndex && midElement >= arr[i])
                   return 0;
        }         
        return 1;
    }

    // Driver code
    static void Main(string[] args)
    {
      int[] a = {3,2,1,4,5};
      Console.WriteLine(centerdArray(a));
    }
}