using System;

class Program
{
    static int centeredArray(int[] arr)
    {
        if (arr == null || arr.Length % 2 == 0) 
            return 0;
        int midIndex = (arr.Length - 1) / 2 ;
        int midElement = arr[midIndex];

        for( int i=0; i < arr.Length; i++){
            if (i != midIndex && midElement >= arr[i])
                   return 0;
        }         
        return 1;
    }
}