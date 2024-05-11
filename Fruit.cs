using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitBasket
{
    public class Fruit : IFruit
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public double Weight { get; set; }
        public int Size { get; set; }
        public Fruit(string name, string color, double weight, int size)
        {
            Name = name;
            Color = color;
            Weight = weight;
            Size = size;
        }
    }
}
