namespace StrategyDemo.Simple;

public class PercentageDiscountStrategy : IDiscountStrategy
{
    private readonly decimal _discountRate;

    public PercentageDiscountStrategy(decimal discountRate)
    {
        _discountRate = discountRate;
    }

    public decimal Calculate(decimal price)
    {
        return price * _discountRate;
    }
}
