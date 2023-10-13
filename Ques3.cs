using System;
class THIRD
{
    static void Main()
    {
        Console.Write("Enter a string here: ");
        string inputString = Console.ReadLine();
        Console.Write("Enter the character to search: ");
        char searchChar = Console.ReadLine()[0];
        int indexOfChar = inputString.IndexOf(searchChar);
        Console.WriteLine($"Index of '{searchChar}' in the string: {indexOfChar}");
        Console.Write("Enter your first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Enter your last name: ");
        string lastName = Console.ReadLine();
        string fullName = firstName + " " + lastName;
        Console.WriteLine($"Full Name: {fullName}");
    }
}