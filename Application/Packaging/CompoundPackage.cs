using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingFabrik.Application.Validation;
using VuelingFabrik.Domain;

namespace VuelingFabrik.Application.Packaging
{
    public abstract class CompoundPackage : PackagePart
    {
        protected List<Component> _components = new List<Component>();
        public void Add(Component component)
        {
            _components.Add(component);
        }
        
    }
}
