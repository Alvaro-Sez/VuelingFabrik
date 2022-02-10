using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingFabrik.Application.Packaging;
using VuelingFabrik.Domain;

namespace VuelingFabrik.UI
{
    public static class Reporter
    {
        public static void Report(this Package package)
        {
            var pckgErrors = package.GetErrors();
            if(pckgErrors == null)
            {
                double price = package.GetPrice();
                Console.WriteLine("Everything is Ok\n");
                Console.WriteLine($"The Price of the Package is: {price}");
            }
            else
            {
                Console.WriteLine("Invalid Package\n");
                foreach(var error in pckgErrors)
                {
                    Console.WriteLine($"Component Id: {error.InvalidComponentId}");
                    Console.WriteLine($"error message: {error.message}\n");
                }
            }
        }
    }
}
