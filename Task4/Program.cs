using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 9, 3, 7, 1, 5 };      // your 5 favorite numbers

        Array.Sort(numbers);                     // ascending
        Array.Reverse(numbers);                  // reverse the sorted array

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"numbers[{i}] = {numbers[i]}");
        }

        int search = 7;
        int index = Array.IndexOf(numbers, search);
        Console.WriteLine($"Index of {search}: {index}");   // -1 = not found
    }
}