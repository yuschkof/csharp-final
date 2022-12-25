using System;
public class PrimeNumberExample
{
    public static void Main(string[] args)
    {
        int n;
        Console.Write("Введите число: ");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine($"Число {n} {(isPrimeNumber(n) ? "простое" : "не является простым")}");
    }

    public static bool isPrimeNumber(int number)
    {
        if (number == 1) return false;
        if (number == 2) return true;

        var limit = Math.Ceiling(Math.Sqrt(number));

        for (int i = 2; i <= limit; ++i)
            if (number % i == 0)
                return false;
        return true;
    }
}