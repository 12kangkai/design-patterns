namespace DecoratorDemo.Simple;

public class SimpleCoffee : ICoffee
{
    public string GetDescription()
    {
        return "原味咖啡";
    }

    public decimal GetCost()
    {
        return 10m;
    }
}
