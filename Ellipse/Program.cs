using Ellipse;

class Program
{
    public static void Main(string[] args)
    {
        Point center = new Point {
            X = 10,
            Y = 10
        };

        try
        {
            Figure ellipse = new Figure(center, 10, 12);
            Console.WriteLine($"Длина эллипса: {ellipse.GetLength()}");
            Console.WriteLine($"Площадь эллипса: {ellipse.GetSquare()}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}