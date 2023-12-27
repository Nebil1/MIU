using System;

class Program
{
    static int nextPerfectSquare(int n)
    {
        if (n < 0) return 0;
        int root = (int)Math.Floor(Math.Sqrt(n)) + 1;
        return root * root;
    }
}