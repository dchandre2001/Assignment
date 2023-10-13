using System;
class Six
{
    public static void Main()
    {
        string inputString = "lol";
        string result = LowUpper(inputString);
        Console.WriteLine(result);
        Count(result);
    }

    public static string LowUpper(string input1)
    {
        string lowerCase1 = input1.ToLower();
        string upperCase1 = input1.ToUpper();
        return lowerCase1 + upperCase1;
    }

    public static void Count(string x)
    {
        int charCount1 = x.Length;
        Console.WriteLine($"The amount of characters in string is {charCount1}.");
    }
}