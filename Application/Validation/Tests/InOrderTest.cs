using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingFabrik.Domain;

namespace VuelingFabrik.Application.Validation.Tests
{
    public class InOrderTest : IValidation
    {
        public void Validate(ValidationContext context)
        {
            OrderDto order = context.Order;
            List<Component> components = context.Components;

            foreach (Component component in components)
            {
                foreach (ComponentDto orderComponent in order.Detail)
                {
                    if (component.ComponentType == orderComponent.ComponentType)
                    {
                        component.IsInOrder = true;
                    }
                }
                if (!component.IsInOrder)
                {
                    TestError err = new TestError()
                    {
                        InvalidComponentId = component.Id,
                        message = "this component is not in the order"
                    };
                    context.AddError(err);
                }
            }
        }
    }
}
