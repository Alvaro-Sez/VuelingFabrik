using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingFabrik.Domain;

namespace VuelingFabrik.Application.Validation.Tests
{
    public class CorrectColorTest : IValidation
    {
        public void Validate(ValidationContext context)
        {
            OrderDto order = context.Order;
            List<Component> components = context.Components;
            foreach(Component component in components)
            {
                foreach (ComponentDto orderComponent in order.Detail)
                {
                    if (component.ComponentType == orderComponent.ComponentType)
                    {
                        if (component.Color != orderComponent.Color)
                        {
                            TestError err = new TestError()
                            {
                                InvalidComponentId = component.Id,
                                message = "this component does not match the correct color"
                            };
                            context.AddError(err);
                        }
                    }
                }

            }
        }
    }
}
