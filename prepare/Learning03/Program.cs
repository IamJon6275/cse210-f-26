using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction frac1 = new Fraction();
        // frac1.fraction();
        // frac1.SetTop(1);
        // Console.WriteLine(frac1.GetTop());
        // frac1.SetBottom(1);
        // Console.WriteLine(frac1.GetBottom());
        // frac1.fraction(6);
        // frac1.SetTop(6);
        // Console.WriteLine(frac1.GetTop());
        // frac1.SetBottom(1);
        // Console.WriteLine(frac1.GetBottom());
        // frac1.fraction(6, 7);
        // frac1.SetTop(6);
        // Console.WriteLine(frac1.GetTop());
        // frac1.SetBottom(7);
        // Console.WriteLine(frac1.GetBottom());
        frac1.fraction();
        Console.WriteLine(frac1.GetFractionString());
        Console.WriteLine(frac1.GetDecimalValue());
        frac1.fraction(5);
        Console.WriteLine(frac1.GetFractionString());
        Console.WriteLine(frac1.GetDecimalValue());
        frac1.fraction(3, 4);
        Console.WriteLine(frac1.GetFractionString());
        Console.WriteLine(frac1.GetDecimalValue());
        frac1.fraction(1, 3);
        Console.WriteLine(frac1.GetFractionString());
        Console.WriteLine(frac1.GetDecimalValue());

        int i = 1;
        Fraction frac2 = new Fraction();
        while (i < 20)
        {
            i++;
            int topFrac = Random.Shared.Next(1, 100);
            int bottomFrac = Random.Shared.Next(1, 100);
            frac2.fraction(topFrac, bottomFrac);
            Console.WriteLine($"Fraction {i}: string: {frac2.GetFractionString()}\nNumber: {frac2.GetDecimalValue()}");
        };
    }
}