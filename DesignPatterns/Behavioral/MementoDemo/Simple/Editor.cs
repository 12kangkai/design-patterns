namespace MementoDemo.Simple;

public class Editor
{
    public string Content { get; set; }

    public Memento Save()
    {
        return new Memento(Content);
    }

    public void Restore(Memento memento)
    {
        Content = memento.State;
    }
}
