using System;
using MediatorDemo.Simple;

namespace MediatorDemo
{
    // Mediator

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Mediator 中介者模式 示例 ===");
            Console.WriteLine();
            Console.WriteLine("说明：在该项目的 Program.cs 中实现 Mediator 的示例代码，或引用其他文件进行组织。");
            Console.WriteLine();
            Console.WriteLine("运行命令（示例）：");
            Console.WriteLine($"dotnet run --project Behavioral/MediatorDemo/MediatorDemo.csproj");
            Console.WriteLine();

            var mediator = new RegisterDialogMediator();
            
            var checkBox = new CheckBox(mediator);
            var button = new Button(mediator);
            var textBox = new TextBox(mediator);
            
            mediator.SetControls(checkBox, button, textBox);
            
            button.SetEnabled(false);
            
            textBox.Input("alice");
            checkBox.Check();
            button.Click();
        }
    }
}
