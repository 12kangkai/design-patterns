using System;
using StrategyDemo.Simple;

namespace StrategyDemo
{
    // Strategy

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Strategy 策略模式 示例 ===");
            Console.WriteLine();
            Console.WriteLine("说明：在该项目的 Program.cs 中实现 Strategy 的示例代码，或引用其他文件进行组织。");
            Console.WriteLine();
            Console.WriteLine("运行命令（示例）：");
            Console.WriteLine($"dotnet run --project Behavioral/StrategyDemo/StrategyDemo.csproj");
            Console.WriteLine();

            var context = new PriceContext(new NoDiscountStrategy());
            Console.WriteLine($"原价：{context.GetFinalPrice(100)}");
            
            context.SetStrategy(new PercentageDiscountStrategy(0.8m));
            Console.WriteLine($"八折价：{context.GetFinalPrice(100)}");
            
            context.SetStrategy(new FixedAmountDiscountStrategy(20));
            Console.WriteLine($"直减后：{context.GetFinalPrice(100)}");
            
        }
    }
}
