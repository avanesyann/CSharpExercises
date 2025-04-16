namespace Gemstones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> stones = new List<string>()
            {
                "abcdde", "baccd", "eeabg"
            };
            Console.WriteLine(Gemstones(stones));

        }

        static int Gemstones(List<string> arr)
        {
            HashSet<char> stones = new HashSet<char>(arr[0]);

            for (int i = 1; i < arr.Count; i++)
            {
                HashSet<char> current = new HashSet<char>(arr[i]);
                stones.IntersectWith(current);
            }

            return stones.Count;
            
        }
    }
}
