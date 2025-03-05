using System.Security.Cryptography.X509Certificates;

namespace SequenceEquation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 5, 2, 1, 3, 4 };
            List<int> list2 = new List<int>() { 2, 3, 1 };

            Console.WriteLine(string.Join(" ", PermutationEquation(list)));
            Console.WriteLine(string.Join(" ", PermutationEquation(list2)));
        }

        static List<int> PermutationEquation(List<int> p)
        {
            List<int> result = new List<int>();

            for (int x = 1; x <= p.Count; x++)
            {
                int firstIndex = p.IndexOf(x) + 1;
                int secondIndex = p.IndexOf(firstIndex) + 1;

                result.Add(secondIndex);
            }

            return result;
        }
    }
}