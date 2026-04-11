namespace IteratorDemo.Simple;

public class NameCollection : IAggregate<string>
{
    private readonly List<string> names = new List<string>();
    
    public void Add(string name)
    {
        names.Add(name);
    }

    public string GetItem(int index)
    {
        return names[index];
    }
    
    public int Count => names.Count;
    
    public IIterator<string> CreateIterator()
    {
        return new NameIterator(this);
    }
}
