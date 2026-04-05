namespace DecoratorDemo.Simple;

public class SugarDecorator : CoffeeDecorator
{
    public SugarDecorator(ICoffee coffee) : base(coffee)
    {
    }

    public override string GetDescription()
    {
        return base.GetDescription() + " + 糖";
    }

    public override decimal GetCost()
    {
        return base.GetCost() + 1m;
    }
}
