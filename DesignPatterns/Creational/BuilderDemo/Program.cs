using System;
using BuilderDemo.Simple;

namespace BuilderDemo
{
    // Builder

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Builder 建造者 示例 ===");
            Console.WriteLine();
            Console.WriteLine("说明：在该项目的 Program.cs 中实现 Builder 的示例代码，或引用其他文件进行组织。");
            Console.WriteLine();
            Console.WriteLine("运行命令（示例）：");
            Console.WriteLine($"dotnet run --project Creational/BuilderDemo/BuilderDemo.csproj");
            Console.WriteLine();

            
            var director = new ComputerDirector();

            // var computerBuilder = new GamingComputerBuilder();
            var computerBuilder = new OfficeComputerBuilder();
            director.Construct(computerBuilder);
            
            var computer = computerBuilder.GetComputer();
            computer.ShowConfig();
            
            Console.WriteLine();
        }
    }
}
