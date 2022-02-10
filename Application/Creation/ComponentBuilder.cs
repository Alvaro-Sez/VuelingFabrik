using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingFabrik.Domain;

namespace VuelingFabrik.Application.Creation
{
    public class ComponentBuilder
    {
        private Component _cdom;
        private ComponentBuilder(Component cdom)=>_cdom = cdom;

        public static List<Component> BuildAllComponent(OrderDto order)
        {
            List<Component> components = new List<Component>();

            foreach (var component in order.Detail)
            {
                Component comp = BuildComponent(component)
                    .Polish()
                    .SetBrand()
                    .Build();
                components.Add(comp);
            }
            return components;
        }
        private static ComponentBuilder BuildComponent(ComponentDto cdto)
        {
            Component component = new Component()
            {
                ComponentType = cdto.ComponentType, 
                SubComponents = BuildSubComponent(cdto.SubComponents),
                PriceIncrement = cdto.PriceIncrement,
                NumComponents = cdto.NumComponents,
                Tests = cdto.Tests,
            };
            return new ComponentBuilder(component);
        } 
        private static List<SubComponent> BuildSubComponent (List<SubComponentDto> subComponentsDto)
        {
            List<SubComponent> subcomponents = new List<SubComponent>();
            foreach (SubComponentDto subComponentDto in subComponentsDto)
            {
                SubComponent subComponent = new SubComponent()
                {
                    Type = subComponentDto.Type,
                    Price = subComponentDto.Price,
                };

                subcomponents.Add(subComponent);
            }
            return subcomponents;
        }
        public ComponentBuilder Polish()
        {
            _cdom.Polished = true;
            return this;
        }
        public ComponentBuilder SetBrand()
        {
            _cdom.BrandSet = true;
            return this;
        }
        public Component Build()
        {
            return _cdom;
        }
    }
}