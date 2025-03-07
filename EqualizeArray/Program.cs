namespace EqualizeArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>() { };
            List<int> list2 = new List<int>() { 1, 2, 3, 1, 2, 3, 3, 3 };
            List<int> list3 = new List<int>() { 1, 2, 3, 4, 4, 5, 6, 6, 8, 8, 9, 9, 6, 7, 8, 4 };
            List<int> list4 = new List<int>() { 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3 };


            Console.WriteLine(string.Join("", EqualizeArray(list1)));
            Console.WriteLine(string.Join("", EqualizeArray(list2)));
            Console.WriteLine(string.Join("", EqualizeArray(list3)));
            Console.WriteLine(string.Join("", EqualizeArray(list4)));
        }

        static int EqualizeArray(List<int> list)
        {
            Dictionary<int, int> frequency = new Dictionary<int, int>();
            int maxFreq = 0;

            foreach (int num in list)
            {
                if (!frequency.ContainsKey(num))
                    frequency[num] = 0;
                frequency[num]++;

                if (frequency[num] > maxFreq)
                    maxFreq = frequency[num];
            }

            return list.Count - maxFreq;
        }
    }
}
