namespace SherlockAndSquares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Squares(3, 9));
            Console.WriteLine(Squares(35, 84));
            Console.WriteLine(Squares(17, 48));
            Console.WriteLine(Squares(121, 1984));
        }

        static int Squares(int a, int b)
        {
            int rootOfA = (int)Math.Ceiling(Math.Sqrt(a));
            int rootOfB = (int)Math.Floor(Math.Sqrt(b));

            int perfectSquares = rootOfB - rootOfA + 1;

            return perfectSquares;
        }
    }
}
