using System;
using ObserverDemo.Simple;

namespace ObserverDemo
{
    // Observer

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Observer 观察者模式 示例 ===");
            Console.WriteLine();
            Console.WriteLine("说明：在该项目的 Program.cs 中实现 Observer 的示例代码，或引用其他文件进行组织。");
            Console.WriteLine();
            Console.WriteLine("运行命令（示例）：");
            Console.WriteLine($"dotnet run --project Behavioral/ObserverDemo/ObserverDemo.csproj");
            Console.WriteLine();

            var newsPublisher = new NewsPublisher();
            
            var mobileClient = new MobileClient();
            var emailClient = new EmailClient();

            newsPublisher.Attach(mobileClient);
            newsPublisher.Attach(emailClient);
            
            newsPublisher.PublishNews("OpenAI 发布了新的平台功能");
        }
    }
}
