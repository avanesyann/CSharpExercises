namespace UtopianTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(UtopianTree(0));
            Console.WriteLine(UtopianTree(1));
            Console.WriteLine(UtopianTree(2));
            Console.WriteLine(UtopianTree(3));
            Console.WriteLine(UtopianTree(4));
            Console.WriteLine(UtopianTree(20));
            Console.WriteLine(UtopianTree(-20));
        }

        static int UtopianTree(int cycles)
        {
            if (cycles < 0) return 0;

            int treeHeight = 1;
            for (int i = 0; i < cycles; i++)
            {
                if (i % 2 == 0)
                    treeHeight *= 2;
                else
                    treeHeight++;
            }
            return treeHeight;
        }
    }
}
