namespace MethodOverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>()
            {
                new Dog("Jimmy"),
                new Cat("Tom"),
                new Dog("Rocky"),
                new Cow("Flower"),
                new Cat("Micky")
            };

            foreach (Animal animal in animals)
            {
                animal.MakeSound();
            }
        }
    }
}
