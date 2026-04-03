using System;
using AbstractFactoryDemo.Simple;
using AbstractFactoryDemo.Simple.Mac;
using AbstractFactoryDemo.Simple.Win;

namespace AbstractFactoryDemo
{
    // Abstract Factory
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Abstract Factory 抽象工厂 示例 ===");
            Console.WriteLine();
            Console.WriteLine("说明：在该项目的 Program.cs 中实现 Abstract Factory 的示例代码，或引用其他文件进行组织。");
            Console.WriteLine();
            Console.WriteLine("运行命令（示例）：");
            Console.WriteLine($"dotnet run --project Creational/AbstractFactoryDemo/AbstractFactoryDemo.csproj");
            Console.WriteLine();

            // var factory = new WindowsFactory();
            var factory = new MacFactory();
            var app = new Application(factory);
            app.RenderUI();
            Console.WriteLine();
        }
    }
}
