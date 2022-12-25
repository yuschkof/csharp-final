ConsoleKeyInfo keyInfo;
while (true)
{
    Console.Clear();
    keyInfo = Console.ReadKey();

    if (keyInfo.Key == ConsoleKey.LeftArrow)
    {
        Console.WriteLine("<-");
    }
    else if (keyInfo.Key == ConsoleKey.RightArrow)
    {
        Console.WriteLine("->");
    }
    else if (keyInfo.Key == ConsoleKey.UpArrow)
    {
        Console.WriteLine("↑");
    }
    else if (keyInfo.Key == ConsoleKey.DownArrow)
    {
        Console.WriteLine("↓");
    }
}
