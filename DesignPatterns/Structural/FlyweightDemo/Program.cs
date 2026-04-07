using System;
using FlyweightDemo.Simple;

namespace FlyweightDemo
{
    // Flyweight

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Flyweight 享元模式 示例 ===");
            Console.WriteLine();
            Console.WriteLine("说明：在该项目的 Program.cs 中实现 Flyweight 的示例代码，或引用其他文件进行组织。");
            Console.WriteLine();
            Console.WriteLine("运行命令（示例）：");
            Console.WriteLine($"dotnet run --project Structural/FlyweightDemo/FlyweightDemo.csproj");
            Console.WriteLine();

            var factory = new CharacterFactory();
            
            var str = "ABABA";

            int x = 0;

            foreach (var c in str)
            {
                var character = factory.GetCharacter(c);
                character.Display(x++, 0);
            }
        }
    }
}
