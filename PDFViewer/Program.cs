namespace PDFViewer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> heights = new List<int>() { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 7};

            string word = "zaba";

            Console.WriteLine(PdfViewer(heights, word));
        }

        static int PdfViewer(List<int> heights, string word)
        {
            int maxHeight = 0;

            foreach (char c in word)
            {
                maxHeight = Math.Max(maxHeight, heights[c - 'a']);
            }

            return maxHeight * word.Length;
        }
    }
}
