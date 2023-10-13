using System;

class Program {
  public static void Main(string[] args)
{
    string stringForFloat = "0.85";
    float floatVariable = float.Parse(stringForFloat); // Parse the string into a float

    string stringForInt = "12345";
    int intVariable = int.Parse(stringForInt); // Parse the string into an int

    Console.WriteLine($"Parsed float: {floatVariable}");
    Console.WriteLine($"Parsed int: {intVariable}");
}
}

//OUTPUT
Parsed float: 0.85
Parsed int: 12345