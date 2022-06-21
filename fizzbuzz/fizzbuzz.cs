using System;

class FizzBuzz
{
    static void Main()
    {
        int x, y;
        Console.WriteLine("Please enter first value:");

        
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter second value");
        y = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("\n");

        for (int i = 1; i <= 100; i++)
        {
            string output = "";

            if (i % x == 0) { output += "fizz";}
            if (i % y == 0) { output += "buzz";}
            if (output == "") { output = i.ToString();}
            Console.WriteLine(output);
        }
        
        

    }
}