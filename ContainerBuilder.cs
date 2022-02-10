using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingFabrik.Application.Printing;
using VuelingFabrik.Application.Processing.Processors;
using VuelingFabrik.Application.Processing.Specification;
using VuelingFabrik.Application.Validation;
using VuelingFabrik.Application.Validation.Tests;
using VuelingFabrik.Data;
using VuelingFabrik.Domain;

namespace VuelingFabrik
{
    public  class ContainerBuilder
    {
        public IServiceProvider ConfigureServices()
        {
            JsonDeserializer deserializer = new JsonDeserializer();
            OrderDto order = deserializer.GetOrder();
            HandleComponents handleCilindro = new HandleComponents(new CilindroSpec(), new CilindroPainter(order), null);
            /*Chain of Responsibility
             * aqui registraria un handle para cada componente , para el ejemplo solo lo hago con cilindro y Piston
             */

            var builder = new ServiceCollection();
            builder.AddTransient<IValidation, CorrectColorTest>();
            builder.AddTransient<IValidation, InOrderTest>();
            builder.AddTransient<IValidation, PolishmentTest>();
            builder.AddTransient<IValidateTests, ValidateTests>();

            builder.AddTransient<IHandler>(s => new HandleComponents(new PistonSpec(), new PistonPainter(order), handleCilindro) );


            return builder.BuildServiceProvider();
        }
    }
}
