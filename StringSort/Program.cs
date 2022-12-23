class Program
{
    static void Main(string[] args)
    {
        // Читаем строки из файла
        string path = "string.txt";
        string[] lines = File.ReadAllLines(path);
        // Сортируем массив строк
        for (int i = 0; i < lines.Length - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < lines.Length; j++)
            {
                if (String.Compare(lines[j], lines[minIndex]) < 0)
                {
                    minIndex = j;
                }
            }
            if (minIndex != i)
            {
                string temp = lines[i];
                lines[i] = lines[minIndex];
                lines[minIndex] = temp;
            }
        }

        // Выводим отсортированный массив на экран
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}
