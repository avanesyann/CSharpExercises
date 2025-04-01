namespace SeparateNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SeparateNumbers("91011");
        }

        static void SeparateNumbers(string s)
        {
            List<string> splits = new List<string>();

            for (int i = 0; i < s.Length; i++)
            {
                splits.Add(s[i].ToString());
            }

            foreach (string splt in splits)
            {
                Console.WriteLine(splt);
            }
        }
    }
}
