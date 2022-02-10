using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingFabrik.Domain;

namespace VuelingFabrik.Application.Processing.Processors
{
    internal class CilindroPainter : IProcessor
    {
        private readonly OrderDto _order;

        public CilindroPainter(OrderDto order)
        {
            _order = order;
        }
        public void Process(Component component)
        {
            foreach( ComponentDto cdto in _order.Detail)
            {
                if(cdto.ComponentType == "Cilindro")
                {
                    component.Color = cdto.Color;
                }
            }
        }
    }
}
