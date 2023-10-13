using System;
class Five
{
    static void Main()
    {
        string friend1 = "Dipali";
        string friend2 = "Radhika";
        string friend3 = "Laxmi";

        GreetFriend(friend1);
        GreetFriend(friend2);
        GreetFriend(friend3);
    }

    static void GreetFriend(string friendName)
    {
        Console.WriteLine($"Hi {friendName}, my friend!");
    }
}