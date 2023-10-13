using System;
class Eight
{
    static void Main()
    {
        int x;
        Console.WriteLine("Enter Number:");
        x = Convert.ToInt32(Console.ReadLine());
        NestedCheck(x);
    }

    static void NestedCheck(int number)
    {
        if (number%3 == 0)
        {
            Console.WriteLine("Divisible by 3.");
        }
        else if (number%7 == 0)
        {
            Console.WriteLine("Divisible by 7.");
        }
        else
        {
            if (number%2 == 0)
            {
                Console.WriteLine("Even number.");
            }
            else
            {
                Console.WriteLine("Odd number.");
            }
        }
    }
}