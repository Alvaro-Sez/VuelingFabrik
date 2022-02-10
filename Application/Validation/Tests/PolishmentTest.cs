using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingFabrik.Domain;

namespace VuelingFabrik.Application.Validation.Tests
{
    public class PolishmentTest : IValidation
    {
        public void Validate(ValidationContext context)
        {
            List<Component> components = context.Components;

            foreach(Component component in components)
            {
                if (!component.Polished)
                {
                    TestError err = new TestError()
                    {
                        InvalidComponentId = component.Id,
                        message = "this component is not correctly polished"
                    };
                    context.AddError(err);
                }
            }
        }
    }
}
