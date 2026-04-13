namespace VisitorDemo.Simple;

public class PriceVisitor : IVisitor
{
    public decimal TotalPrice { get; private set; }
    
    public void Visit(Book book)
    {
        TotalPrice += book.Price;
        Console.WriteLine($"图书：{book.Name}，价格：{book.Price}");
    }

    public void Visit(Fruit fruit)
    {
        var subtotal = fruit.Weight * fruit.UnitPrice;
        TotalPrice += subtotal;
        Console.WriteLine($"水果：{fruit.Name}，小计：{subtotal}");
    }
}
