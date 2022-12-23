ConsoleKeyInfo keyInfo;
while (true)
{
    Console.Clear();
    keyInfo = Console.ReadKey();

    if (keyInfo.Key == ConsoleKey.LeftArrow)
    {
        // Отображаем стрелочку налево
        Console.WriteLine("<-");
    }
    else if (keyInfo.Key == ConsoleKey.RightArrow)
    {
        // Отображаем стрелочку направо
        Console.WriteLine("->");
    }
    else if (keyInfo.Key == ConsoleKey.UpArrow)
    {
        // Отображаем стрелочку направо
        Console.WriteLine("↑");
    }
    else if (keyInfo.Key == ConsoleKey.DownArrow)
    {
        // Отображаем стрелочку направо
        Console.WriteLine("↓");
    }
}
