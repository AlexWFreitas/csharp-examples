using System;

namespace DecoratorPatternExample
{
    partial class Program
    {
        static void Main(string[] args)
        {
            // ICar is the main interface
            // Cars represent the interface implementation as concrete types
            // Accessories represent the decorator pattern implementation by wrapping a concrete car and adding functionality.
            // Decorator patterns can be used to extend functionality dynamically.

            // Create EcomomyCar instance.   
            ICar objCar = new EconomyCar();

            // Wrap EconomyCar instance with BasicAccessories.   
            CarAccessoriesDecorator objAccessoriesDecorator = new BasicAccessories(objCar);

            // Wrap EconomyCar instance with AdvancedAccessories instance.   
            objAccessoriesDecorator = new AdvancedAccessories(objAccessoriesDecorator);

            // Therefore EconomyCar was decorated with BasicAccessories and then AdvancedAccessories.

            Console.Write("Car Details: " + objAccessoriesDecorator.GetDescription());
            Console.WriteLine("\n\n");
            Console.Write("Total Price: " + objAccessoriesDecorator.GetCost());

            Console.Read();

        }
    }
}
