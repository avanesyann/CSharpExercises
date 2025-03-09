using System.Security.Cryptography.X509Certificates;

namespace ShapeArea
{
    public class Circle : Shape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius <= 0) throw new ArgumentException("Radius must be greater than zero.");
            Radius = radius;
        }
        public override double CalculateArea()
        {
            return Radius * Radius * Math.PI;
        }
    }
    public class Rectangle : Shape
    {
        public double Width { get; }
        public double Length { get; }

        public Rectangle(double width, double length)
        {
            if (width <= 0 || length <= 0) throw new ArgumentException("Width and Length must be greater than zero.");
            Width = width;
            Length = length;
        }
        public override double CalculateArea()
        {
            return Width * Length;
        }
    }
    public class Square : Shape
    {
        public double Side { get; }

        public Square(double side)
        {
            if (side <= 0) throw new ArgumentException("Size must be greater than zero.");
            Side = side;
        }
        public override double CalculateArea()
        {
            return Side * Side;
        }
    }
    public abstract class Shape
    {
        public abstract double CalculateArea();

        public void DisplayArea()
        {
            Console.WriteLine("The area of the shape is: {0:F2}", CalculateArea());
        }
    }
}
