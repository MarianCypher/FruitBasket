using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitBasket
{
    public interface IHandler
    {
        public IHandler SetNext(IHandler handler);
        object Handle(Fruit request);
    }
}
