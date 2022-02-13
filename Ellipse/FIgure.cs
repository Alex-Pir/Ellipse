namespace Ellipse
{
    public class Figure
    {
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
            return Math.PI * HorizontalRadius * VerticalRadius;
        }

        public double GetLength()
        {
            return Math.PI * (HorizontalRadius + VerticalRadius);
        }

        protected int checkRadius(int radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius cannot be negative");
            }

            return radius;
        }
    }
}
