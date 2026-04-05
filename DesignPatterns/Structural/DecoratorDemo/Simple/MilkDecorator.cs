namespace DecoratorDemo.Simple;

public class MilkDecorator : CoffeeDecorator
{
    public MilkDecorator(ICoffee coffee) : base(coffee)
    {
    }

    public override string GetDescription()
    {
        return _coffee.GetDescription() + " + 牛奶";
    }

    public override decimal GetCost()
    {
        return _coffee.GetCost() + 2m;
    }
}
