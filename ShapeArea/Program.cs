namespace ShapeArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>()
            {
                new Circle(4),
                new Rectangle(5, 10),
                new Rectangle(6, 12),
                new Circle(8),
                new Square(6)
            };

            foreach (Shape shape in shapes)
            {
                shape.DisplayArea();
            }
        }
    }
}
