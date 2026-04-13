namespace StrategyDemo.Simple;

public interface IDiscountStrategy
{
    decimal Calculate(decimal price);
}
