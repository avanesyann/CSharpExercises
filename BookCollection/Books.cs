namespace BookCollection
{
    public class Books
    {
        private List<(string isbn, string title)> _books;
        public int Count => _books.Count;

        public Books()
        {
            _books = new List<(string isbn, string title)>();
        }

        public string this[string isbn]
        {
            get
            {
                foreach (var book in _books)
                {
                    if (book.isbn == isbn)
                        return book.title;
                }

                throw new KeyNotFoundException($"ISBN '{isbn}' not found.");
            }
            set
            {
                for (int i = 0; i < Count; i++)
                {
                    if (_books[i].isbn == isbn)
                    {
                        _books[i] = (isbn, value);
                        return;
                    }
                }

                throw new KeyNotFoundException($"ISBN '{isbn}' not found.");
            }
        }
        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                    throw new ArgumentOutOfRangeException($"Index {index} is out of range.");

                return _books[index].title;
            }
        }

        public void AddBook(string isbn, string title)
        {
            foreach (var book in _books)
            {
                if (book.isbn == isbn)
                    throw new InvalidOperationException($"ISBN '{isbn}' already exists.");
            }
            _books.Add((isbn, title));
        }

    }
}
