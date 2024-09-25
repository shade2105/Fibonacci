using System;

int n = int.Parse(Console.ReadLine());
Fibonacci.Write(n);
Console.ReadLine();
public class Fibonacci
{
    public static void Write(int n)
    {
        Console.WriteLine(0);
        Console.WriteLine(1);
        int X1 = 0;
        int X2 = 1;
        while (X2<n)
        {
            int Output = X1 + X2;
            X1 = X2;
            X2 = Output;
            if (X2 <= n)
            {
                Console.WriteLine(X2);
            }
        }
        return;
    }
}
