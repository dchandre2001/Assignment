using System;
class SEC
{
   public static void Main(string[] args)
    {
        string userInput;

        Console.WriteLine("Please enter your Name and press enter:");
        userInput = Console.ReadLine();
        string upperCase = userInput.ToUpper();
        Console.WriteLine("Uppercase: " + upperCase);
        string lowerCase = userInput.ToLower();
        Console.WriteLine("Lowercase: " + lowerCase);
        string trimmed = userInput.Trim();
        Console.WriteLine("Trimmed: " + trimmed);
        string substring = userInput.Substring(0, Math.Min(userInput.Length, 5));
        Console.WriteLine("Substring (first 5 characters): " + substring);
    }
}