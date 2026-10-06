using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> fruits = new List<string> { "Apple", "Mango", "Banana" };
        fruits.Add("Orange");
        fruits.Remove("Banana");

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Dictionary<int, string> fruitDict = new Dictionary<int, string>
        {
            { 1, "Apple" },
            { 2, "Mango" },
            { 3, "Banana" }
        };
        fruitDict.Add(4, "Orange");

        foreach (KeyValuePair<int, string> pair in fruitDict)
        {
            Console.WriteLine($"ID {pair.Key}: {pair.Value}");
        }
    }
}