namespace SalesByMatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SockMerchant(new List<int> { 10, 20, 20, 10, 10, 30, 50, 10, 20 }));
        }

        static int SockMerchant(List<int> socks)
        {
            if (socks == null || socks.Count == 0) return 0;

            Dictionary<int, int> sockCount = new Dictionary<int, int>();
            int pairs = 0;

            foreach (int sock in socks)
            {
                if (sockCount.ContainsKey(sock))
                    sockCount[sock]++;
                else
                    sockCount[sock] = 1;
            }

            foreach (var sock in sockCount)
            {
                pairs += sock.Value / 2;
            }

            return pairs;
        }
    }
}
