using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime birthDate = new DateTime(2005, 1, 15);   // year, month, day: use yours
        DateTime now = DateTime.Now;

        TimeSpan difference = now - birthDate;            // subtract two DateTimes
        int ageInYears = (int)(difference.TotalDays / 365.25);

        Console.WriteLine($"Birthdate    : {birthDate:dd MMM yyyy}");
        Console.WriteLine($"Current date : {now:dd MMM yyyy HH:mm:ss}");
        Console.WriteLine($"Age in years : {ageInYears}");

        DateTime plusTen = birthDate.AddDays(10);
        Console.WriteLine($"Birthdate + 10 days: {plusTen:dd MMM yyyy}");
    }
}