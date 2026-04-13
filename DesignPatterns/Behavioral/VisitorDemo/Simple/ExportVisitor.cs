namespace VisitorDemo.Simple;

public class ExportVisitor : IVisitor
{
    public void Visit(Book book)
    {
        Console.WriteLine($"导出图书：名称={book.Name}, 单价={book.Price}");
    }

    public void Visit(Fruit fruit)
    {
        Console.WriteLine($"导出水果：名称={fruit.Name}, 重量={fruit.Weight}, 单价={fruit.UnitPrice}");
    }
}
