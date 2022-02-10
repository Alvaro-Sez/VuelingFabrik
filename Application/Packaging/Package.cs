using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingFabrik.Application.Validation;
using VuelingFabrik.Domain;

namespace VuelingFabrik.Application.Packaging
{
    public class Package : CompoundPackage
    {
        private ValidationResult _validationResult;
        public override double GetPrice()
        {
            return _components.Sum(comp => comp.GetPrice());
        }
        public void AddValidationResult(ValidationResult result)
        {
            _validationResult = result;
        }
        public List<TestError> GetErrors()
        {
            if (!_validationResult.IsValid)
            {
                return _validationResult.ErrorList;
            } 
            else 
            {
                return null; 
            }
        }
    }
}
