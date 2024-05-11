using System;
using System.Security.Cryptography.X509Certificates;

namespace FruitBasket
{
    /* Zaimplementuj za pomocą wzorca konfigurowalne sitko na owoce:
        Jedno z poziomów sitka przepuszcza tylko owoce danego koloru
        Jedno z poziomów sitka przepuszcza tylko owoce danej wagi
        Jedno z poziomów sitka przepuszcza tylko owoce określonych wymiarów
        Jedno z poziomów sitka przepuszcza tylko owoce zaczynające się na dana litere */
    class Client
    {
        public static void ClientCode(AbstractHandler handler, List<Fruit> groceries)
        {
            var leftovers = new List<Fruit>();
            foreach (var item in groceries)
            {
                Console.WriteLine($"Taking care of {item.Name}.");

                var result = handler.Handle(item);

                if (result != null)
                {   
                    leftovers.Add(item);
                }
            }
            Console.Write("After segregation ");
            if (leftovers.Count > 0)
            {
                foreach (var item in leftovers)
                {
                    Console.Write(item.Name + " ");
                }
            }
            else
            {
                Console.Write("nothing ");
            }
            Console.Write("was left untouched.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Fruit apple = new Fruit("apple", "red", 0.25, 2);
            Fruit pear = new Fruit("pear", "green", 0.2, 3);
            Fruit cherry = new Fruit("cherry", "red", 0.05, 1);
            Fruit pineapple = new Fruit("pineapple", "yellow", 3, 5);
            Fruit kiwi = new Fruit("kiwi", "brown", 0.3, 1);
            List<Fruit> groceries = new List<Fruit>() { apple, pear, cherry, pineapple, kiwi };

            var colorSieve = new ColorHandle();
            var weightSieve = new WeightHandle();
            var sizeSieve = new SizeHandle();
            var nameSieve = new NameLetterHandle();
            colorSieve.SetNext(weightSieve).SetNext(sizeSieve).SetNext(nameSieve);

            Client.ClientCode(colorSieve, groceries);
            Console.WriteLine();

            Console.Write("Lets take a look in Color Sieve. Here we have:");
            foreach (var item in colorSieve.Tray)
            {
                Console.Write(" " + item.Name);
            }
            Console.Write(".\n");
        }
    }
};