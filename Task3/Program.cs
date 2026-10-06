using System;

class Program
{
    static void Main(string[] args)
    {
        byte b = 200;
        short s = 30000;
        int i = 2000000000;
        long l = 9000000000L;
        float f = 3.14f;
        double d = 3.14159265359;
        decimal m = 19.99m;
        char c = 'A';
        bool flag = true;

        Console.WriteLine($"byte    : {b} ({b.GetType()})");
        Console.WriteLine($"short   : {s} ({s.GetType()})");
        Console.WriteLine($"int     : {i} ({i.GetType()})");
        Console.WriteLine($"long    : {l} ({l.GetType()})");
        Console.WriteLine($"float   : {f} ({f.GetType()})");
        Console.WriteLine($"double  : {d} ({d.GetType()})");
        Console.WriteLine($"decimal : {m} ({m.GetType()})");
        Console.WriteLine($"char    : {c} ({c.GetType()})");
        Console.WriteLine($"bool    : {flag} ({flag.GetType()})");

        int number = 42;
        string numberAsString = number.ToString();
        Console.WriteLine($"int 42 to string: \"{numberAsString}\" ({numberAsString.GetType()})");

        string text = "3.14";
        double parsed = Convert.ToDouble(text);
        Console.WriteLine($"string \"3.14\" to double: {parsed} ({parsed.GetType()})");
    }
}