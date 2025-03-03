namespace PickingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PickNumbers(new List<int>() { 1, 2, 2, 3, 1, 2 }));
            Console.WriteLine(PickNumbers(new List<int>() { 4, 6, 5, 3, 3, 1, }));
        }

        static int PickNumbers(List<int> list)
        {
            if (list == null || list.Count == 0) return 0;

            Dictionary<int, int> numbers = new Dictionary<int, int>();

            foreach (int num in list)
            {
                if (!numbers.ContainsKey(num))
                    numbers[num] = 1;
                else
                    numbers[num]++; ;
            }

            int maxLength = 0;

            foreach (var key in numbers.Keys)
            {
                int currentLength = numbers[key];

                if (numbers.ContainsKey(key + 1))
                    currentLength += numbers[key + 1];

                maxLength = Math.Max(maxLength, currentLength);
            }

            return maxLength;
        }
    }
}
