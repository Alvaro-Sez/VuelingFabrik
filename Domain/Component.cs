using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingFabrik.Application.Packaging;

namespace VuelingFabrik.Domain
{
    public class Component : PackagePart
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string ComponentType { get; set; }
        public List<SubComponent> SubComponents { get; set; }
        public double PriceIncrement { get; set; }
        public int NumComponents { get; set; }
        public string Color { get; set; }
        public List<string> Tests { get; set; }
        public bool Polished { get; set; }
        public bool BrandSet { get; set; }
        public TestError error { get; set; }
        public bool IsInOrder { get; set; }
        public override double GetPrice()
        {
            double componentPrice = SubComponents.Sum(subcomp => subcomp.GetPrice()) + PriceIncrement;
            return (componentPrice * NumComponents);
        }
    }
}
