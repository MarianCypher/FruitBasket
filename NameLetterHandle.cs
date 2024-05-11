using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitBasket
{
    class NameLetterHandle : AbstractHandler
    {
        public List<Fruit>? Tray { get; set; }
        public NameLetterHandle()
        {
            Tray = new List<Fruit>();
        }
        public override object Handle(Fruit request)
        {
            if (request.Name[0] is 'K')
            {
                Console.WriteLine("NameLetterHandle adding\n");
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
