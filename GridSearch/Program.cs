namespace GridSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        static string GridSearch(List<string> G, List<string> P)
        {
            int R = G.Count;
            int r = P.Count;

            int C = G[0].Length;
            int c = P[0].Length;

            for (int i = 0; i <= R - r; i++)
            {
                for (int j = 0; j <= C - c; j++)
                {
                    bool match = true;

                    for (int x = 0; x < r; x++)
                    {
                        if (G[i + x].Substring(j, c) != P[x])
                        {
                            match = false;
                            break;
                        }
                    }

                    if (match) return "YES";
                }
            }

            return "NO";
        }
    }
}
