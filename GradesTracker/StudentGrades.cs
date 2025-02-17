namespace GradesTracker
{
    public class StudentGrades
    {
        private List<int> _students;
        public int Count => _students.Count;

        public StudentGrades()
        {
            _students = new List<int>();
        }

        public int this[int key]
        {
            get
            {
                if (key < 0 || key >= _students.Count)
                throw new IndexOutOfRangeException("Invalid index.");

                return _students[key];
            }
            set 
            {
                if (key < 0)
                    throw new IndexOutOfRangeException("Index cannot be negative.");

                while (_students.Count <= key)
                    _students.Add(0);

                _students[key] = value; 
            }
        }

        public int AverageGrade()
        {
            return Count != 0 ? _students.Sum() / Count : 0;
        }
    }
}
