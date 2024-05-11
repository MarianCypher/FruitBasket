using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitBasket
{
    class WeightHandle : AbstractHandler
    {
        public List<Fruit>? Tray { get; set; }
        public WeightHandle()
        {
            Tray = new List<Fruit>();
        }
        public override object Handle(Fruit request)
        {
            if (request.Weight >= 3)
            {
                Console.WriteLine("WightHandle adding\n");
                Tray?.Add(request);
                return null;
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
