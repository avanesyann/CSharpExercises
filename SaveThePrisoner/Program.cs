namespace SaveThePrisoner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SaveThePrisoner(7, 19, 2));
        }

        static int SaveThePrisoner(int prisoners, int treats, int startingChair)
        {
            //for (int i = 1; i <= treats; i++)
            //{
            //    if (startingChair > prisoners)
            //        startingChair = 1;

            //    Console.WriteLine("Prisoner No.{0}", startingChair);

            //    startingChair++;
            //}

            //return --startingChair;

            return (startingChair + treats - 1) % prisoners;
        }
    }
}
