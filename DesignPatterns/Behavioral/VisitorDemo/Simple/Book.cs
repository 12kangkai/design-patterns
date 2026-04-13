namespace VisitorDemo.Simple;

public class Book : IElement
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Book(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}

public class Fruit : IElement
{
    public string Name { get; set; }
    public decimal Weight { get; set; }
    public decimal UnitPrice { get; set; }

    public Fruit(string name, decimal weight, decimal unitPrice)
    {
        Name = name;
        Weight = weight;
        UnitPrice = unitPrice;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}
