using System;
using MementoDemo.Simple;

namespace MementoDemo
{
    // Memento

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Memento 备忘录模式 示例 ===");
            Console.WriteLine();
            Console.WriteLine("说明：在该项目的 Program.cs 中实现 Memento 的示例代码，或引用其他文件进行组织。");
            Console.WriteLine();
            Console.WriteLine("运行命令（示例）：");
            Console.WriteLine($"dotnet run --project Behavioral/MementoDemo/MementoDemo.csproj");
            Console.WriteLine();

            var editor = new Editor();
            var history = new History();

            editor.Content = "A";
            history.Push(editor.Save());

            editor.Content = "AB";
            history.Push(editor.Save());
            
            editor.Content = "ABC";

            Console.WriteLine(editor.Content); // ABC
            
            editor.Restore(history.Pop());
            Console.WriteLine(editor.Content); // AB
            
            editor.Restore(history.Pop());
            Console.WriteLine(editor.Content);// A
            
        }
    }
}
