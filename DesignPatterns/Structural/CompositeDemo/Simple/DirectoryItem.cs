namespace CompositeDemo.Simple;

public class DirectoryItem : FileSystemItem
{
    private readonly List<FileSystemItem> _children = new ();
    
    public DirectoryItem(string name) : base(name)
    {
    }

    public void Add(FileSystemItem item)
    {
        _children.Add(item);
    }
    
    public void Remove(FileSystemItem item)
    {
        _children.Remove(item);
    }

    public override void Display(int depth)
    {
        Console.WriteLine(new String('-', depth) + Name);

        foreach (var child in _children)
        {
            child.Display(depth + 2);
        }
        
    }
}
