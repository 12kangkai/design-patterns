using System;
using ProxyDemo.Simple;

namespace ProxyDemo
{
    // Proxy

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Proxy 代理模式 示例 ===");
            Console.WriteLine();
            Console.WriteLine("说明：在该项目的 Program.cs 中实现 Proxy 的示例代码，或引用其他文件进行组织。");
            Console.WriteLine();
            Console.WriteLine("运行命令（示例）：");
            Console.WriteLine($"dotnet run --project Structural/ProxyDemo/ProxyDemo.csproj");
            Console.WriteLine();

            var image = new ImageProxy("product_detail.png");
            
            Console.WriteLine("第一次调用：");
            image.Display();

            Console.WriteLine();
            Console.WriteLine("第二次调用：");
            image.Display();            
            
        }
    }
}
