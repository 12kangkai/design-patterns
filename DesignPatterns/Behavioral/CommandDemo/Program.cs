using System;
using CommandDemo.Simple;

namespace CommandDemo
{
    // Command

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Command 命令模式 示例 ===");
            Console.WriteLine();
            Console.WriteLine("说明：在该项目的 Program.cs 中实现 Command 的示例代码，或引用其他文件进行组织。");
            Console.WriteLine();
            Console.WriteLine("运行命令（示例）：");
            Console.WriteLine($"dotnet run --project Behavioral/CommandDemo/CommandDemo.csproj");
            Console.WriteLine();

            var player = new Player();
            var playCommand = new PlayCommand(player);
            var pauseCommand = new PauseCommand(player);
            var nextTrackCommand = new NextTrackCommand(player);

            var invoker = new PlayerInvoker();
            
            invoker.SetCommand(playCommand);
            invoker.PressButton();
            
            invoker.SetCommand(nextTrackCommand);
            invoker.PressButton();
            
            invoker.SetCommand(pauseCommand);
            invoker.PressButton();
        }
    }
}
