using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using VuelingFabrik.Application.Creation;
using VuelingFabrik.Application.Packaging;
using VuelingFabrik.Application.Printing;
using VuelingFabrik.Application.Processing.Processors;
using VuelingFabrik.Application.Processing.Specification;
using VuelingFabrik.Application.Validation;
using VuelingFabrik.Data;
using VuelingFabrik.Domain;
using VuelingFabrik.UI;

namespace VuelingFabrik
{
    internal class Program
    {
        private static readonly IServiceProvider container = new ContainerBuilder().ConfigureServices();
        static void Main(string[] args)
        {
            JsonDeserializer deserializer = new JsonDeserializer();
            OrderDto order = deserializer.GetOrder();

            /*Builder*/
            List<Component> components = ComponentBuilder.BuildAllComponent(order);

            /*CoR*/
            var handler = container.GetService<IHandler>();
            
            foreach (Component component in components)
            {
                handler.Handle(component);
            }

            var validator = container.GetService<IValidateTests>();
            var validationResult = validator.Validate(components, order);

            /*Composite*/
            Package package = new Package();
            foreach (Component component in components)
            {
                package.Add(component);
            }
            package.AddValidationResult(validationResult);


            package.Report();


        }
    }
}
