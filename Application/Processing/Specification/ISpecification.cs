using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingFabrik.Domain;

namespace VuelingFabrik.Application.Processing.Specification
{
    public interface ISpecification
    {
        bool IsSatisfiedBy(Component comp);
    }
}
