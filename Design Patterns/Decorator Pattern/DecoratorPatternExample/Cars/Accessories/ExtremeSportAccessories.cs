namespace DecoratorPatternExample
{
    partial class Program
    {
        public class ExtremeSportAccessories : CarAccessoriesDecorator
        {
            public ExtremeSportAccessories(ICar aCar) : base(aCar)
            {
            }
            public override string GetDescription()
            {
                return base.GetDescription() + ",Extreme Sport Accessories";
            }
            public override double GetCost()
            {
                return base.GetCost() + 25000;
            }
        }
    }
}
