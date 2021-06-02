namespace DecoratorPatternExample
{
    partial class Program
    {
        public class SuperLuxury : ICar
        {
            public string GetDescription()
            {
                return "Super Luxury Car";
            }

            public double GetCost()
            {
                return 1500000;
            }
        }
    }
}
