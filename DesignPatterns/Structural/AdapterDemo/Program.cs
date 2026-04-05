using System;
using AdapterDemo.Simple;

namespace AdapterDemo
{
    // Adapter

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Adapter 适配器模式 示例 ===");
            Console.WriteLine();
            Console.WriteLine("说明：在该项目的 Program.cs 中实现 Adapter 的示例代码，或引用其他文件进行组织。");
            Console.WriteLine();
            Console.WriteLine("运行命令（示例）：");
            Console.WriteLine($"dotnet run --project Structural/AdapterDemo/AdapterDemo.csproj");
            Console.WriteLine();

            var legacySmsService = new LegacySmsService();
            INotification notification = new SmsAdapter(legacySmsService);

            var client = new MessageClinet(notification);
            client.Notify("Hello World");
            
        }
    }
}
