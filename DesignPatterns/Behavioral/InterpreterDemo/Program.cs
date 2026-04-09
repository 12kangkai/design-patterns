using System;
using InterpreterDemo.Simple;

namespace InterpreterDemo
{
    // Interpreter

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Interpreter 解释器模式 示例 ===");
            Console.WriteLine();
            Console.WriteLine("说明：在该项目的 Program.cs 中实现 Interpreter 的示例代码，或引用其他文件进行组织。");
            Console.WriteLine();
            Console.WriteLine("运行命令（示例）：");
            Console.WriteLine($"dotnet run --project Behavioral/InterpreterDemo/InterpreterDemo.csproj");
            Console.WriteLine();

            // 表达式：x + 3 - y
            var context = new Context();
            context.SetValue("x",10);
            context.SetValue("y",4);

            IExpression expression = 
                new SubtractExpression(
                new AddExpression(
                    new VariableExpression("x"),
                    new NumberExpression(3)
                ),
            new VariableExpression("y")
            );

            var result = expression.Interpret(context);
            Console.WriteLine(result);
        }
    }
}
