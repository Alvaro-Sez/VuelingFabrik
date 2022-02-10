using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingFabrik.Domain;

namespace VuelingFabrik.Application.Processing.Specification
{
    public class PistonSpec : ISpecification
    {

        public bool IsSatisfiedBy(Component comp)
        {
            return comp.ComponentType == "Piston" ? true : false;
        }
    }
}
