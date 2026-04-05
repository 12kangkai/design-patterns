namespace CompositeDemo.Simple;

public abstract class FileSystemItem
{
    public string Name { get; set; }

    protected FileSystemItem(string name)
    {
        Name = name;
    }

    public abstract void Display(int depth);
}
