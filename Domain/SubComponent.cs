using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingFabrik.Application.Packaging;

namespace VuelingFabrik.Domain
{
    public class SubComponent : PackagePart
    {
        public string Type { get; set; }
        public double Price { get; set; }

        public override double GetPrice()
        {
            return Price;
        }
    }
}
