namespace StrategyDemo.Simple;

public class PriceContext
{
    private IDiscountStrategy _strategy;

    public PriceContext(IDiscountStrategy strategy)
    {
        _strategy = strategy;
    }
    
    public void SetStrategy(IDiscountStrategy strategy)
    {
        _strategy = strategy;
    }

    public decimal GetFinalPrice(decimal price)
    {
        return _strategy.Calculate(price);
    }
    
}
