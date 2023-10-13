using System;
class Seven
{
    static void Main()
    {
        int x;
        Console.WriteLine("Enter Number:");
        x = Convert.ToInt32(Console.ReadLine());
        Check(x);
    }
    static void Check(int number)
    {
        if (number % 2 == 0)
        {
            Console.WriteLine("Even");
        }
        else
        {
            Console.WriteLine("Odd");
        }
    }
}