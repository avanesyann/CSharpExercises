namespace BookCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Books library = new Books();
            library.AddBook("978-0134685997", "The Great Gatsby");
            library.AddBook("978-0154686998", "In Search of Lost Time");
            library.AddBook("000-0000000001", "The Epic of Gilgamesh");
            library.AddBook("978-0154616998", "One Hundred Years of Solitude");
            library.AddBook("978-0158195468", "Lolita");
            library.AddBook("978-0119935713", "Anna Karenina");
            library.AddBook("978-0112348385", "War and Peace");
            library.AddBook("978-0155812844", "Flowers For Algernon");
            library.AddBook("978-0112388345", "To Kill a Mockingbird");

            library["978-0158195468"] = "The Old Man and The Sea";

            Console.WriteLine(library[6]);
            Console.WriteLine(library[7]);
            Console.WriteLine(library[8]);
            Console.WriteLine(library[4]);
        }
    }
}
