using System;
using TemplateMethodDemo.Simple;

namespace TemplateMethodDemo
{
    // Template Method

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Template Method 模版方法 示例 ===");
            Console.WriteLine();
            Console.WriteLine("说明：在该项目的 Program.cs 中实现 Template Method 的示例代码，或引用其他文件进行组织。");
            Console.WriteLine();
            Console.WriteLine("运行命令（示例）：");
            Console.WriteLine($"dotnet run --project Behavioral/TemplateMethodDemo/TemplateMethodDemo.csproj");
            Console.WriteLine();

            var csvDataProcessor = new CsvDataProcessor();
            csvDataProcessor.Process();

            Console.WriteLine("----------");

            var jsonDataProcessor = new JsonDataProcessor();
            jsonDataProcessor.Process();
        }
    }
}
