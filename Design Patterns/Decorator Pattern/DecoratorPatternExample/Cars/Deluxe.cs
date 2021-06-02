namespace DecoratorPatternExample
{
    /// <summary>   
    /// Concrete Car   
    /// </summary>   
    public class Deluxe : ICar
    {
        public string GetDescription()
        {
            return "Deluxe Car";
        }

        public double GetCost()
        {
            return 750000.0;
        }
    }
}
