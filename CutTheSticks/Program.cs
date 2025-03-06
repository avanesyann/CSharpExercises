namespace CutTheSticks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sticks = CutTheSticks(new List<int>() { 5, 4, 4, 2, 2, 8 });
            List<int> sticks2 = CutTheSticks(new List<int>() { 1, 2, 2, 2, 2, 1 });
            List<int> sticks3 = CutTheSticks(new List<int>() { 0, 0, 0, 0, 0, 0 });

            Console.WriteLine(string.Join(" ", sticks));
            Console.WriteLine(string.Join(" ", sticks2));
            Console.WriteLine(string.Join(" ", sticks3));
        }


        /// <summary>
        /// Simulates cutting sticks iteratively until none remain.
        /// </summary>
        /// <param name="arr">List of stick lengths.</param>
        /// <returns>List of counts of sticks cut in each round.</returns>
        static List<int> CutTheSticks(List<int> arr)
        {
            if (arr == null || arr.Count == 0)
                return new List<int>();

            int shortestStick;
            int sticksCut;
            List<int> cuts = new List<int>();

            while (arr.Count != 0)
            {
                shortestStick = arr[0];
                for (int i = 1; i < arr.Count; i++)
                {
                    if (arr[i] < shortestStick)
                        shortestStick = arr[i];
                }


                sticksCut = 0;
                for (int i = 0; i < arr.Count; i++)
                {
                    arr[i] -= shortestStick;
                    sticksCut++;
                }
                arr.RemoveAll(x => x == 0);
                cuts.Add(sticksCut);
            }

            return cuts;
        }
    }
}
