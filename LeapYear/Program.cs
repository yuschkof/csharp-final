using System;

namespace leapYear.Test;

public class leapYears
{
    public static void Main(string[] args)
    {
        int n;
        Console.Write("Введите год: ");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine($"Год  {n} {(leapYear(n) ? "високосный" : "не високосный")}");
    }

    public static bool leapYear(int n)
    {
        if (n % 4 == 0 && (n % 100 != 0 || n % 400 == 0))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}