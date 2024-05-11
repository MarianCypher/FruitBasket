using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitBasket
{
    class ColorHandle : AbstractHandler
    {
        public List<Fruit>? Tray { get; set; }
        public ColorHandle()
        {
            Tray = new List<Fruit>();
        }
        public override object Handle(Fruit request)
        {
            if (request.Color == "red")
            {
                Console.WriteLine("ColorHandle adding\n");
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
