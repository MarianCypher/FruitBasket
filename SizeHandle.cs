using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitBasket
{
    class SizeHandle : AbstractHandler
    {
        public List<Fruit>? Tray { get; set; }
        public SizeHandle()
        {
            Tray = new List<Fruit>();
        }
        public override object Handle(Fruit request)
        {
            if (request.Size <= 3)
            {
                Console.WriteLine("SizeHandle adding\n");
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
