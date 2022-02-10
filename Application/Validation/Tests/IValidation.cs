using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuelingFabrik.Application.Validation.Tests
{
    public interface IValidation
    {
        void Validate(ValidationContext context);
    }
}
