namespace Ellipse
{
    public class Figure
    {
        protected const int EXACTITUDE = 2;

        public Point Center { get; private set };
        public int HorizontalRadius { get; private set; }
        public int VerticalRadius { get; private set; }

        public Figure(Point center, int horizontalRadius, int verticalRadius)
        {
            HorizontalRadius = CheckRadius(horizontalRadius);
            VerticalRadius = CheckRadius(verticalRadius);

            Center = center;
        }

        public double GetSquare()
        {
            double square = Math.PI * HorizontalRadius * VerticalRadius;
            return Math.Round(square, Figure.EXACTITUDE);
        }

        public double GetLength()
        {
            double length = Math.PI * (HorizontalRadius + VerticalRadius);
            return Math.Round(length, Figure.EXACTITUDE);
        }

        protected int CheckRadius(int radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius cannot be negative or 0");
            }

            return radius;
        }
    }
}
