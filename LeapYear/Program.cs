using System;
public class PrimeNumber
{
    public static void Main(string[] args)
    {
        int n;
        Console.Write("Введите год: ");
        n = int.Parse(Console.ReadLine());
        if (n % 4 == 0 && (n % 100 != 0 || n % 400 == 0))
        {
            Console.Write("Год високосный");
        }
        else
        {
            Console.Write("Год не високосный");
        }
    }
}