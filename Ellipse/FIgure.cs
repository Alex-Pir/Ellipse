namespace Ellipse
{
    public class Figure
    {
        protected const int FRACTION_LENGTH = 2;

        public Point Center;
        public int HorizontalRadius { get; set; }
        public int VerticalRadius { get; set; }

        public Figure(Point center, int horizontalRadius, int verticalRadius)
        {
            HorizontalRadius = checkRadius(horizontalRadius);
            VerticalRadius = checkRadius(verticalRadius);

            Center = center;
        }

        public double GetSquare()
        {
            double square = Math.PI * HorizontalRadius * VerticalRadius;
            return Math.Round(square, Figure.FRACTION_LENGTH);
        }

        public double GetLength()
        {
            double length = Math.PI * (HorizontalRadius + VerticalRadius);
            return Math.Round(length, Figure.FRACTION_LENGTH);
        }

        protected int checkRadius(int radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius cannot be negative or 0");
            }

            return radius;
        }
    }
}
