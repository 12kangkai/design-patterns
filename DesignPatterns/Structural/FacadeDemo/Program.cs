using System;
using FacadeDemo.Simple;

namespace FacadeDemo
{
    // Facade

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Facade 外观模式 示例 ===");
            Console.WriteLine();
            Console.WriteLine("说明：在该项目的 Program.cs 中实现 Facade 的示例代码，或引用其他文件进行组织。");
            Console.WriteLine();
            Console.WriteLine("运行命令（示例）：");
            Console.WriteLine($"dotnet run --project Structural/FacadeDemo/FacadeDemo.csproj");
            Console.WriteLine();

            var facade = new HomeTheaterFacade(
                new LightSystem(),
                new Projector(),
                new Player());
            
            facade.WatchMovie("Interstellar");
        }
    }
}
