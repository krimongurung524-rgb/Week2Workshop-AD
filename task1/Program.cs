using System;

class Program
{
    static void Main(string[] args)
    {
        string userName = "Krimon Gurung";   // 1. variable userName, initialized
        int luckyNumber = 9;             // 2. variable luckyNumber, single digit

        // 3. string interpolation: $"..." with {variable}
        Console.WriteLine($"Hello, {userName}! Your lucky number is {luckyNumber}.");
    }
}