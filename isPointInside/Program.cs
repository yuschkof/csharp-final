namespace isPointInside;

public class isPointInside
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите координату x точки:");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите координату y точки:");
        double y = double.Parse(Console.ReadLine());

        Console.WriteLine($"Координаты  ({x},{y}) {(PointInside(x, y) ? "в круге!" : "не в круге")}");
    }

    public static bool PointInside(double x, double y)
    {
        return (Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y + 1, 2)) <= 2) ? true : false;
    }
}
