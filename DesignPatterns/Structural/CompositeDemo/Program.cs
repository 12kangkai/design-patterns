using System;
using CompositeDemo.Simple;

namespace CompositeDemo
{
    // Composite

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Composite 组合模式 示例 ===");
            Console.WriteLine();
            Console.WriteLine("说明：在该项目的 Program.cs 中实现 Composite 的示例代码，或引用其他文件进行组织。");
            Console.WriteLine();
            Console.WriteLine("运行命令（示例）：");
            Console.WriteLine($"dotnet run --project Structural/CompositeDemo/CompositeDemo.csproj");
            Console.WriteLine();

            var root = new DirectoryItem("Root");

            var file1 = new FileItem("File1.txt");
            var file2 = new FileItem("File2.txt");

            var subDir = new DirectoryItem("SubDirectory");
            subDir.Add(new FileItem("File3.txt"));
            
            root.Add(file1);
            root.Add(file2);
            root.Add(subDir);
            
            root.Display(1);
            
        }
    }
}
