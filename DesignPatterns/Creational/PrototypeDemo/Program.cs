using System;
using PrototypeDemo.Simple;

namespace PrototypeDemo
{
    // Prototype

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Prototype 原型模式 示例 ===");
            Console.WriteLine();
            Console.WriteLine("说明：在该项目的 Program.cs 中实现 Prototype 的示例代码，或引用其他文件进行组织。");
            Console.WriteLine();
            Console.WriteLine("运行命令（示例）：");
            Console.WriteLine($"dotnet run --project Creational/PrototypeDemo/PrototypeDemo.csproj");
            Console.WriteLine();

            var template = new DocumentTemplate("周报模版", "1. 本周工作\n2. 下周计划");

            var copy1 = template.Clone();
            copy1.Title = "张三周报";

            var copy2 = template.Clone();
            copy2.Title = "李四周报";

            Console.WriteLine(template.Title);
            Console.WriteLine(copy1.Title);
            Console.WriteLine(copy2.Title);
        }
    }
}
