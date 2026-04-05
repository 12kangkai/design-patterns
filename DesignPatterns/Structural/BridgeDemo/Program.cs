using System;
using BridgeDemo.Simple;

namespace BridgeDemo
{
    // Bridge

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Bridge 桥接模式 示例 ===");
            Console.WriteLine();
            Console.WriteLine("说明：在该项目的 Program.cs 中实现 Bridge 的示例代码，或引用其他文件进行组织。");
            Console.WriteLine();
            Console.WriteLine("运行命令（示例）：");
            Console.WriteLine($"dotnet run --project Structural/BridgeDemo/BridgeDemo.csproj");
            Console.WriteLine();

            var tv = new TV();
            var remote = new AdvancedRemote(tv);
            
            remote.TogglePower();
            remote.VolumeUp();
            remote.Mute();
        }
    }
}
