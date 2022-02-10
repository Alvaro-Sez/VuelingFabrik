using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingFabrik.Application.Validation.Tests;
using VuelingFabrik.Domain;

namespace VuelingFabrik.Application.Validation
{
    public class ValidateTests: IValidateTests
    {
        private readonly IEnumerable<IValidation> _validations;

        public ValidateTests(IEnumerable<IValidation> validations)
        {
            _validations = validations;
        }

        public ValidationResult Validate(List<Component> components, OrderDto orderDto)
        {
            ValidationContext validationContext = new ValidationContext()
            {
                Order = orderDto,
                Components = components
            };

            foreach(var validation in _validations)
            {
                validation.Validate(validationContext);
            }


            ValidationResult result = new ValidationResult();
            result.AddResult(validationContext);
            return result;
        }
    }
}
