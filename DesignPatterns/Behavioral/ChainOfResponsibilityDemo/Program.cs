using System;
using ChainOfResponsibilityDemo.Simple;

namespace ChainOfResponsibilityDemo
{
    // Chain of Responsibility

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Chain of Responsibility 责任链模式 示例 ===");
            Console.WriteLine();
            Console.WriteLine("说明：在该项目的 Program.cs 中实现 Chain of Responsibility 的示例代码，或引用其他文件进行组织。");
            Console.WriteLine();
            Console.WriteLine("运行命令（示例）：");
            Console.WriteLine($"dotnet run --project Behavioral/ChainOfResponsibilityDemo/ChainOfResponsibilityDemo.csproj");
            Console.WriteLine();

            var leader = new TeamLeader();
            var manager = new Manager();
            var director = new Director();
            
            leader.SetNext(manager);
            manager.SetNext(director);
            
            leader.HandleRequest(8000);
        }
    }
}
