using System;

class Program
{
    static int primeCount(int start, int end)
    {
        int primeCount = 0;
        for (int i = start; i <= end ; i++){
            bool isPrime = false;
            if (i > 1){
                isPrime = true;
                for (int j = 2; j * 2 <= i; j++){
                    if (i % j == 0){
                        isPrime = false;
                        break;
                    }
                }
            }
            if (isPrime)
                primeCount++;
        }
        return primeCount;
    }
}
