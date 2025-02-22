namespace CatchTheMouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CatAndMouse(2, 1, 3));
        }

        static string CatAndMouse(int x, int y, int z)
        {
            int catA = Math.Abs(z - x);
            int catB = Math.Abs(z - y);
            if (catA > catB)
                return "Cat B";
            if (catA < catB)
                return "Cat A";

            return "Mouse C";
        }
    }
}
