namespace CompositeDemo.Simple;

public class FileItem : FileSystemItem
{
    public FileItem(string name) : base(name)
    {
    }

    public override void Display(int depth)
    {
        Console.WriteLine(new String('-', depth) + Name);
    }
}
