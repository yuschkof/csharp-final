﻿class MultiplicationTable
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write("{0,4}", i * j);
            }
            Console.WriteLine();
        }
    }
}
