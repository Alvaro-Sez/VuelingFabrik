using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingFabrik.Domain;

namespace VuelingFabrik.Application.Processing.Processors
{
    public interface IProcessor
    {
        public void Process(Component component);
    }
}
