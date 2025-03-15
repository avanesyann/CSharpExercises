namespace ACM_ICPC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var acmTeam = AcmTeam(new List<string> () { "10101", "11110", "00010"});

            foreach (var team in acmTeam)
            {
                Console.Write(team + " ");
            }
        }

        static List<int> AcmTeam(List<string> topic)
        {
            int maxTopics = 0;
            int teamCount = 0;

            for (int i = 0; i < topic.Count; i++)
            {
                for (int j = i + 1; j < topic.Count; j++)
                {
                    int topicsKnown = 0;
                    for (int k = 0; k < topic[i].Length; k++)
                    {
                        if (topic[i][k] == '1' || topic[j][k] == '1')
                            topicsKnown++;
                    }

                    if (topicsKnown > maxTopics)
                    {
                        maxTopics = topicsKnown;
                        teamCount = 1;
                    }
                    else if (topicsKnown == maxTopics)
                    {
                        teamCount++;
                    }
                }
            }

            return new List<int>() { maxTopics, teamCount };
        }
    }
}
