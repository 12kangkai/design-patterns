using System;
using VisitorDemo.Simple;

namespace VisitorDemo
{
    // Visitor

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Visitor 访问者模式 示例 ===");
            Console.WriteLine();
            Console.WriteLine("说明：在该项目的 Program.cs 中实现 Visitor 的示例代码，或引用其他文件进行组织。");
            Console.WriteLine();
            Console.WriteLine("运行命令（示例）：");
            Console.WriteLine($"dotnet run --project Behavioral/VisitorDemo/VisitorDemo.csproj");
            Console.WriteLine();

            var cart = new ShoppingCart();
            cart.Add(new Book("设计模式", 88));
            cart.Add(new Fruit("苹果", 3,6));

            var priceVisitor = new PriceVisitor();
            cart.Accept(priceVisitor);
            Console.WriteLine($"总价：{priceVisitor.TotalPrice}");

            var exportVisitor = new ExportVisitor();
            cart.Accept(exportVisitor);
        }
    }
}
