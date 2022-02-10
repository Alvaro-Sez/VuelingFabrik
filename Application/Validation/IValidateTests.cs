using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingFabrik.Domain;

namespace VuelingFabrik.Application.Validation
{
    public interface IValidateTests
    {
        ValidationResult Validate(List<Component> components, OrderDto orderDto);
    }
}
