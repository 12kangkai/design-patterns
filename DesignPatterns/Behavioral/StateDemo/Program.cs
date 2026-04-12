using System;
using StateDemo.Simple;

namespace StateDemo
{
    // State

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== State 状态模式 示例 ===");
            Console.WriteLine();
            Console.WriteLine("说明：在该项目的 Program.cs 中实现 State 的示例代码，或引用其他文件进行组织。");
            Console.WriteLine();
            Console.WriteLine("运行命令（示例）：");
            Console.WriteLine($"dotnet run --project Behavioral/StateDemo/StateDemo.csproj");
            Console.WriteLine();
            
            var order = new OrderContext(new PendingState());
            
            order.Request(); // 支付
            order.Request(); // 发货
            order.Request(); // 完成
        }
    }
}
