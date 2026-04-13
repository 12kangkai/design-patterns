namespace StrategyDemo.Simple;

public class FixedAmountDiscountStrategy : IDiscountStrategy
{
    private readonly decimal _discountAmount;

    public FixedAmountDiscountStrategy(decimal discountAmount)
    {
        _discountAmount = discountAmount;
    }

    public decimal Calculate(decimal price)
    {
        var result = price - _discountAmount;
        return result < 0 ? 0 : result;
    }
}
