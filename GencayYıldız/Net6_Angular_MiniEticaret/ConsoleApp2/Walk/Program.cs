using System;

public class GfG
{
    public static int countWays(int n)
    {
        int[] res = new int[n + 2];
        res[0] = 0;
        res[1] = 1;
        res[2] = 2;

        for (int i = 3; i <= n; i++)
            res[i] = res[i - 1] + res[i - 2] + res[i - 3];

        return res[n];
    }

    public static void Main()
    {
        int n = 4;
        Console.WriteLine(countWays(n));
    }
}