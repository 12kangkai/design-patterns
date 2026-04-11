using System;
using IteratorDemo.Simple;

namespace IteratorDemo
{
    // Iterator

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Iterator 迭代器模式 示例 ===");
            Console.WriteLine();
            Console.WriteLine("说明：在该项目的 Program.cs 中实现 Iterator 的示例代码，或引用其他文件进行组织。");
            Console.WriteLine();
            Console.WriteLine("运行命令（示例）：");
            Console.WriteLine($"dotnet run --project Behavioral/IteratorDemo/IteratorDemo.csproj");
            Console.WriteLine();

            var names = new NameCollection();
            names.Add("Alice");
            names.Add("Bob");
            names.Add("Charlie");

            var iterator = names.CreateIterator();

            while (iterator.MoveNext())
            {
                Console.WriteLine(iterator.Current);
            }
        }
    }
}
