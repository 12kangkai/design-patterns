namespace StrategyDemo.Simple;

public class NoDiscountStrategy : IDiscountStrategy
{
    public decimal Calculate(decimal price)
    {
        return price;
    }
}
