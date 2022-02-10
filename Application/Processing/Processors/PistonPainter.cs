using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingFabrik.Domain;

namespace VuelingFabrik.Application.Processing.Processors
{
    public class PistonPainter : IProcessor
    {
        private readonly OrderDto _order;

        public PistonPainter(OrderDto order)
        {
            _order = order;
        }
        public void Process(Component component)
        {
            foreach (ComponentDto cdto in _order.Detail)
            {
                if (cdto.ComponentType == "Piston")
                {
                    component.Color = cdto.Color;
                }
            }
        }
    }
}
