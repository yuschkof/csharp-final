
Console.WriteLine("\t\t\tТаблица умножения:");
for (int j = 2; j < 11; j++)
{
    for (int i = 2; i < 6; i++)
    {
        if (j == 10)
            Console.Write($"{i} * {j}= {j * i}\t");
        else
            Console.Write($"{i} * {j} = {j * i}\t");
        
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int j = 2; j < 11; j++)
{
    for (int i = 6; i < 10; i++)
    {
        if (j == 10)
            Console.Write($"{i} * {j}= {j * i}\t");
        else
            Console.Write($"{i} * {j} = {j * i}\t");
    }
    Console.WriteLine();
}