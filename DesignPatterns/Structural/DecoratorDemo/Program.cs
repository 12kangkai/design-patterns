using System;
using DecoratorDemo.Simple;

namespace DecoratorDemo
{
    // Decorator

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Decorator 装饰模式 示例 ===");
            Console.WriteLine();
            Console.WriteLine("说明：在该项目的 Program.cs 中实现 Decorator 的示例代码，或引用其他文件进行组织。");
            Console.WriteLine();
            Console.WriteLine("运行命令（示例）：");
            Console.WriteLine($"dotnet run --project Structural/DecoratorDemo/DecoratorDemo.csproj");
            Console.WriteLine();

            ICoffee coffee = new SimpleCoffee();
            Console.WriteLine($"{coffee.GetDescription()}，价格：{coffee.GetCost()}");
            
            coffee = new MilkDecorator(coffee);
            coffee = new SugarDecorator(coffee);
            Console.WriteLine($"{coffee.GetDescription()}，价格：{coffee.GetCost()}");
        }
    }
}
