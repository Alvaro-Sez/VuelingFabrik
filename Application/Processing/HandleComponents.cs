using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingFabrik.Application.Processing.Processors;
using VuelingFabrik.Application.Processing.Specification;
using VuelingFabrik.Domain;

namespace VuelingFabrik.Application.Printing
{
    public class HandleComponents : IHandler
    {
        private readonly ISpecification _specification;
        private readonly IProcessor _processor;
        private readonly IHandler _nextHandler;

        public HandleComponents(ISpecification specification, IProcessor processor, IHandler nextHandler)
        {
            _specification = specification;
            _processor = processor;
            _nextHandler = nextHandler;
        }

        public void Handle(Component comp)
        {
            if (_specification.IsSatisfiedBy(comp))
            {
                _processor.Process(comp);
            }
            else
            {
                _nextHandler?.Handle(comp);
            }
        }
    }
}
