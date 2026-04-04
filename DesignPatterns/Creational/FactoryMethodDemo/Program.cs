using System;
using FactoryMethodDemo.Simple;

namespace FactoryMethodDemo
{
    // Factory Method

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Factory Method 工厂方法模式 示例 ===");
            Console.WriteLine();
            Console.WriteLine("说明：在该项目的 Program.cs 中实现 Factory Method 的示例代码，或引用其他文件进行组织。");
            Console.WriteLine();
            Console.WriteLine("运行命令（示例）：");
            Console.WriteLine($"dotnet run --project Creational/FactoryMethodDemo/FactoryMethodDemo.csproj");
            Console.WriteLine();
            
            LoggerFactory loggerFactory = new FileLoggerFactory();
            loggerFactory.Log("用户登陆成功");

            loggerFactory = new DatabaseLoggerFactory();
            loggerFactory.Log("已更新用户登陆状态");

        }
    }
}
