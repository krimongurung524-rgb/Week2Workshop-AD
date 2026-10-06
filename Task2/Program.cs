using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"PI = {Circle.PI}");

        // Step A: remove the // below to see the error, then put it back.
        //Circle.PI = 3.14159;

        double radius = 5;
        Console.WriteLine($"Area: {Circle.CalculateArea(radius)}");
        Console.WriteLine($"Perimeter: {Circle.CalculatePerimeter(radius)}");
    }
}