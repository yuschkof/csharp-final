public class isPointInside
{
    static void Main(string[] args)
    {
        // Prompt the user to enter the x and y coordinates of the point
        Console.WriteLine("Введите координату x точки:");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите координату y точки:");
        double y = double.Parse(Console.ReadLine());

        // Calculate the distance between the point and the center of the circle
        double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y + 1, 2));

        // Check if the distance is less than or equal to the radius of the circle
        if (distance <= 2)
        {
            Console.WriteLine("Точка находится в пределах круга.");
        }
        else
        {
            Console.WriteLine("Точка находится за пределами круга.");
        }
    }
}
