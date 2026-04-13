namespace VisitorDemo.Simple;

public class ShoppingCart
{
    private readonly List<IElement>  _items = new ();

    public void Add(IElement element)
    {
        _items.Add(element);
    }
    
    public void Accept(IVisitor visitor)
    {
        foreach (var item in _items)
        {
            item.Accept(visitor);
        }
    }
    
}
