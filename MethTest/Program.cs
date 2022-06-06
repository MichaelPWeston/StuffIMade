using System;


class MethTest
{
    static void MathMeth( int x,int y, out int sum)
    {
        sum = x + y;
    }
    static void Main()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int sum;
        MathMeth(a, b, out sum);
        int sum1 = sum;
        
        int c = Convert.ToInt32(Console.ReadLine());
        int d = Convert.ToInt32(Console.ReadLine());
        MathMeth(c, d, out sum);
        int sum2 = sum;
        Console.WriteLine(sum1 + ", " + sum2);
        Console.ReadKey();
    }
}